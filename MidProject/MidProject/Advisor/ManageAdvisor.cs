using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MidProject.BL;

namespace MidProject.Advisor
{
    public partial class ManageAdvisor : Form
    {
        public ManageAdvisor()
        {
            InitializeComponent();
            DisplayAdvisorsOnDataGridView();
        }

        private int GetLookupId(string category, string value)
        {
            int id = -1; // Default value if not found
            try
            {
                var connection = Configuration.getInstance().getConnection();
                string query = @"SELECT [Id] FROM [dbo].[Lookup] WHERE [Category] = @Category AND [Value] = @Value";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Category", category);
                    command.Parameters.AddWithValue("@Value", value);
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        id = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error fetching lookup ID: " + ex.Message);
            }
            return id;
        }

        private void InsertAdvisor(string firstName, string lastName, string contact, string email, DateTime dateOfBirth, string gender, string designation, decimal salary)
        {
            try
            {
                // Resolve gender and designation to their corresponding IDs
                int genderId = GetLookupId("GENDER", gender);
                if (genderId == -1)
                {
                    MessageBox.Show("Invalid gender.");
                    return;
                }

                int designationId = GetLookupId("DESIGNATION", designation);
                if (designationId == -1)
                {
                    MessageBox.Show("Invalid designation.");
                    return;
                }

                // Get the connection
                var connection = Configuration.getInstance().getConnection();

                // Prepare the SQL query
                string query = @"INSERT INTO [dbo].[Person] ([FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) 
                         VALUES (@FirstName, @LastName, @Contact, @Email, @DateOfBirth, @Gender);
                         DECLARE @PersonId INT = SCOPE_IDENTITY();
                         INSERT INTO [dbo].[Advisor] ([Id], [Designation], [Salary]) VALUES (@PersonId, @DesignationId, @Salary);";

                // Create a SqlCommand object
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the query
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@Contact", contact);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                    command.Parameters.AddWithValue("@Gender", genderId);
                    command.Parameters.AddWithValue("@DesignationId", designationId);
                    command.Parameters.AddWithValue("@Salary", salary);

                    // Execute the query
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Advisor inserted successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void Insert_btn_Click(object sender, EventArgs e)
        {
            if (ValidateInputData())
            {
                string firstName = FirstName_textBox.Text.Trim();
                string lastName = LastName_textBox.Text.Trim();
                string contact = Contact_textBox.Text.Trim();
                string email = Email_textBox.Text.Trim();
                DateTime dateOfBirth = dateTimePicker.Value.Date;
                string salary = Salary_textBox.Text.Trim();
                int s = int.Parse(salary);
                string gender = Gender_CB.SelectedItem?.ToString();
                string designation = Designation_CB.SelectedItem?.ToString();


                InsertAdvisor(firstName,lastName,contact,email,dateOfBirth,gender,designation,s);
                DisplayAdvisorsOnDataGridView();

            }
        }

        private bool ValidateInputData()
        {
            string firstName = FirstName_textBox.Text.Trim();
            string lastName = LastName_textBox.Text.Trim();
            string contact = Contact_textBox.Text.Trim();
            string email = Email_textBox.Text.Trim();
            DateTime dateOfBirth = dateTimePicker.Value.Date;
            string salary = Salary_textBox.Text.Trim();
            string gender = Gender_CB.SelectedItem?.ToString();
            string designation = Designation_CB.SelectedItem?.ToString();

            // Validate first name
            if (string.IsNullOrEmpty(firstName))
            {
                MessageBox.Show("First name cannot be empty");
                return false;
            }

            // Validate last name
            if (string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Last name cannot be empty");
                return false;
            }

            // Validate contact
            if (string.IsNullOrEmpty(contact))
            {
                MessageBox.Show("Contact cannot be empty");
                return false;
            }

            // Validate email
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Email cannot be empty");
                return false;
            }
            else if (!IsValidEmail(email))
            {
                MessageBox.Show("Invalid email format");
                return false;
            }

            // Validate salary (should be a number)
            if (string.IsNullOrEmpty(salary) || !int.TryParse(salary, out _))
            {
                MessageBox.Show("Salary should be a number");
                return false;
            }

            // Validate gender
            if (string.IsNullOrEmpty(gender) || (gender.ToLower() != "male" && gender.ToLower() != "female"))
            {
                MessageBox.Show("Invalid Gender");
                return false;
            }

            // Validate designation
            if (string.IsNullOrEmpty(designation))
            {
                MessageBox.Show("Invalid Designation");
                return false;
            }

            return true;
        }


        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            string Id = Id_textBox.Text.Trim();
            int ID = int.Parse(Id);

            DeleteAdvisor(ID);
            DisplayAdvisorsOnDataGridView();
        }

        private void DeleteAdvisor(int Id)
        {
            try
            {
                var connection = Configuration.getInstance().getConnection();

                // Prepare the SQL query
                string query = @"DELETE FROM [dbo].[Advisor] WHERE Id = @Id";

                // Create a SqlCommand object
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the query
                    command.Parameters.AddWithValue("@Id", Id);

                    // Execute the query
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Advisor data deleted successfully.");
                        // Refresh data in DataGridView if needed
                        DisplayAdvisorsOnDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("No advisor data found with the given details.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void DisplayAdvisorsOnDataGridView()
        {
            try
            {
                var connection = Configuration.getInstance().getConnection();

                // Prepare the SQL query with aliases for column names to match the DataTable
                string query = @"SELECT Advisor.Id, FirstName, LastName, Contact, Email, Designation, Gender, Salary, DateOfBirth 
                        FROM [dbo].[Advisor] AS Advisor
                        INNER JOIN [dbo].[Person] AS Person ON Advisor.Id = Person.Id";

                // Create a SqlCommand object
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Create a DataTable to store the results
                    DataTable dataTable = new DataTable();

                    // Create a SqlDataAdapter to fill the DataTable
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        // Fill the DataTable with data from the database
                        adapter.Fill(dataTable);
                    }

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }


        private void Update_btn_Click(object sender, EventArgs e)
        {
            // Get the ID from the ID_textBox
            if (!int.TryParse(Id_textBox.Text, out int advisorId))
            {
                MessageBox.Show("Please enter a valid ID.");
                return;
            }

            // Check if the advisor with the given ID exists
            if (AdvisorExists(advisorId))
            {
                // Open the update form with the advisor details
                UpdateAdvisorForm updateForm = new UpdateAdvisorForm(advisorId);
                updateForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("No advisor found with the given ID.");
            }
        }

        private bool AdvisorExists(int advisorId)
        {
            try
            {
                var connection = Configuration.getInstance().getConnection();

                // Prepare the SQL query to check if the advisor with the given ID exists
                string query = @"SELECT COUNT(*) FROM [dbo].[Advisor] WHERE Id = @Id";

                // Create a SqlCommand object
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the query
                    command.Parameters.AddWithValue("@Id", advisorId);

                    // Execute the query
                    int count = (int)command.ExecuteScalar();

                    // Return true if the count is greater than 0, indicating the advisor exists
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Gender_CB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Salary_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Email_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Contact_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LastName_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FirstName_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Id_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Designation_CB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
