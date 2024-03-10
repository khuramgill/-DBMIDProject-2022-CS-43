using MidProject.BL;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MidProject.Student
{
    public partial class ManageStudent : Form
    {
        public ManageStudent()
        {
            InitializeComponent();
        }

        private void ManageStudent_Load(object sender, EventArgs e)
        {
            DisplayDataOnDataGridView();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {

            string firstName = FirstName_textBox.Text.Trim();
            string lastName = LastName_textBox.Text.Trim();
            string registrationNo = RegNo_textBox.Text.Trim();

            DeleteStudent(firstName,lastName,registrationNo);
        }

        private void DeleteStudent(string firstName, string lastName, string registrationNo)
        {
            try
            {
                var connection = Configuration.getInstance().getConnection();

                // Prepare the SQL query
                string query = @"Delete From [dbo].[Student] Where Id in (Select Id From [dbo].[Person] where RegistrationNo = @registrationNo AND  FirstName = @FirstName AND LastName = @LastName)";

                // Create a SqlCommand object
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the query
                    command.Parameters.AddWithValue("@firstName", firstName);
                    command.Parameters.AddWithValue("@lastName", lastName);
                    command.Parameters.AddWithValue("@registrationNo", registrationNo);

                    // Execute the query
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Student data deleted successfully.");
                        DisplayDataOnDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("No student data found with the given ID.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void Insert_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = FirstName_textBox.Text.Trim();
                string lastName = LastName_textBox.Text.Trim();
                string contact = Contact_textBox.Text.Trim();
                string email = Email_textBox.Text.Trim();
                DateTime dateOfBirth = dateTimePicker.Value.Date;
                string registrationNo = RegNo_textBox.Text.Trim();

                if (!ValidateInputData())
                {
                    return;
                }
                var connection = Configuration.getInstance().getConnection();

                // Check if the student already exists
                string queryCheck = @"SELECT COUNT(*) FROM [dbo].[Person] p
                              INNER JOIN [dbo].[Student] s ON p.Id = s.Id
                              WHERE s.RegistrationNo = @RegistrationNo AND p.FirstName = @FirstName AND p.LastName = @LastName AND p.Contact = @Contact";
                SqlCommand commandCheck = new SqlCommand(queryCheck, connection);
                commandCheck.Parameters.AddWithValue("@RegistrationNo", registrationNo);
                commandCheck.Parameters.AddWithValue("@FirstName", firstName);
                commandCheck.Parameters.AddWithValue("@LastName", lastName);
                commandCheck.Parameters.AddWithValue("@Contact", contact);

                int count = (int)commandCheck.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("User already exists");
                    return;
                }

                // Prepare the SQL query
                string query = @"INSERT INTO [dbo].[Person] ([FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) 
                         VALUES (@FirstName, @LastName, @Contact, @Email, @DateOfBirth, @Gender);
                         INSERT INTO [dbo].[Student] ([Id], [RegistrationNo]) VALUES (SCOPE_IDENTITY(), @RegistrationNo);";

                // Create a SqlCommand object
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the query
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@Contact", contact);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                    command.Parameters.AddWithValue("@Gender", Gender_CB.SelectedItem?.ToString() == "Male" ? 1 :2);
                    command.Parameters.AddWithValue("@RegistrationNo", registrationNo);

                    // Execute the query
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Record inserted successfully.");

                // Display updated data on DataGridView
                DisplayDataOnDataGridView();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        // Helper method to validate email format
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

        // Method to display data on DataGridView
        public void DisplayDataOnDataGridView()
        {
            try
            {
                var connection = Configuration.getInstance().getConnection();
                string query = @"SELECT p.FirstName, p.LastName, p.Contact, p.Email, p.DateOfBirth, l.Value AS Gender, s.RegistrationNo
                         FROM [dbo].[Person] p
                         INNER JOIN [dbo].[Student] s ON p.Id = s.Id
                         INNER JOIN [dbo].[Lookup] l ON p.Gender = l.Id";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }


        // Method to validate input data
        private bool ValidateInputData()
        {
            string firstName = FirstName_textBox.Text.Trim();
            string lastName = LastName_textBox.Text.Trim();
            string contact = Contact_textBox.Text.Trim();
            string email = Email_textBox.Text.Trim();
            DateTime dateOfBirth = dateTimePicker.Value.Date;
            string registrationNo = RegNo_textBox.Text.Trim();
            string gender = Gender_CB.SelectedItem?.ToString();

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

            // Validate registration number
            if (string.IsNullOrEmpty(registrationNo))
            {
                MessageBox.Show("Registration number cannot be empty");
                return false;
            }

            // Validate gender
            if (string.IsNullOrEmpty(gender) || (gender.ToLower() != "male" && gender.ToLower() != "female"))
            {
                MessageBox.Show("Invalid Gender");
                return false;
            }

            return true;
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                // Get search criteria from user input
                string firstName = FirstName_textBox.Text.Trim();
                string lastName = LastName_textBox.Text.Trim();
                string registrationNo = RegNo_textBox.Text.Trim();

                // Search for the student based on the entered criteria

                Students student = SearchStudent(firstName, lastName, registrationNo);


                // If the student is found, open the update form with the student's details
                if (student != null)
                {
                    // Pass the student details to the update form
                    Update updateForm = new Update(student);
                    updateForm.ShowDialog();
                    DisplayDataOnDataGridView();
                }
                else
                {
                    MessageBox.Show("Student not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        private Students SearchStudent(string firstName, string lastName, string registrationNo)
        {
            Students student = null;

            try
            {
                var connection = Configuration.getInstance().getConnection();

                // Prepare the SQL query to search for the student
                string query = @"SELECT * FROM [dbo].[Person] p 
                         JOIN [dbo].[Student] s ON p.Id = s.Id 
                         WHERE p.FirstName = @FirstName 
                         AND p.LastName = @LastName 
                         AND s.RegistrationNo = @RegistrationNo";

                // Create a SqlCommand object
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the query
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@RegistrationNo", registrationNo);

                    // Execute the query and read the student details
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        student = new Students
                        {
                            Id = (int)reader["Id"],
                            FirstName = (string)reader["FirstName"],
                            LastName = (string)reader["LastName"],
                            Contact = (string)reader["Contact"],
                            Email = (string)reader["Email"],
                            DateOfBirth = (DateTime)reader["DateOfBirth"],
                            Gender = (int)reader["Gender"],
                            RegistrationNo = (string)reader["RegistrationNo"]
                        };
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return student;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }


}

