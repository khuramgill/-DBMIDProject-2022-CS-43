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
using MidProject.BL;
using System.Windows.Forms;

namespace MidProject.Advisor
{
    public partial class UpdateAdvisorForm : Form
    {
        private int advisorId;

        public UpdateAdvisorForm(int id)
        {
            InitializeComponent();
            advisorId = id;

            // Load advisor details based on the ID
            LoadAdvisorDetails();
        }

        private void LoadAdvisorDetails()
        {
            try
            {
                var connection = Configuration.getInstance().getConnection();

                // Prepare the SQL query to retrieve advisor details based on the ID
                string query = @"SELECT * FROM [dbo].[Advisor] Natural join Person";

                // Create a SqlCommand object
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    // Execute the query and read the results
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Fill form fields with advisor details
                            FirstName_textBox.Text = reader["FirstName"].ToString();
                            LastName_textBox.Text = reader["LastName"].ToString();
                            Email_textBox.Text = reader["Email"].ToString();
                            Designation_CB.SelectedItem = reader["Designation"].ToString();
                            Salary_textBox.Text = reader["Salary"].ToString();
                            MessageBox.Show("Load Advisor Detail 3");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            // Get updated advisor details from form fields
            string firstName = FirstName_textBox.Text.Trim();
            string lastName = LastName_textBox.Text.Trim();
            string email = Email_textBox.Text.Trim();
            string contact = Contact_textBox.Text.Trim();
            string designation = Designation_CB.SelectedItem?.ToString().Trim();
            DateTime DateOfBirth = dateTimePicker1.Value;
            // If Salary_textBox is a TextBox, get the text and parse it as decimal
            decimal salary;
            if (!decimal.TryParse(Salary_textBox.Text.Trim(), out salary))
            {
                MessageBox.Show("Please enter a valid salary.");
                return;
            }

            // Update advisor record in the database
            UpdateAdvisor(firstName, lastName, email, designation,salary,contact,DateOfBirth);

            // Close the update form
            this.Close();
        }

        private int GetDesignationId(string designation)
        {
            int designationId = -1; // Default value indicating failure to find a match

            try
            {
                var connection = Configuration.getInstance().getConnection();

                // Prepare the SQL query
                string query = @"SELECT Id FROM [dbo].[Lookup] WHERE Value = @Designation";

                // Create a SqlCommand object
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameter for the designation
                    command.Parameters.AddWithValue("@Designation", designation);

                    // Execute the query and retrieve the designationId
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        designationId = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return designationId;
        }

        private void UpdateAdvisor(string firstName, string lastName, string email, string designation, decimal salary, string contact,DateTime DateOfBirth)
        {
            try
            {
                var connection = Configuration.getInstance().getConnection();

                // Prepare the SQL query to update advisor details

                string query = @"UPDATE [dbo].[Person] SET FirstName = @FirstName, LastName = @LastName, Email = @Email,Contact = @Contact,DateOfBirth = @DateOfBirth WHERE Id = @Id;
                                    Update Advisor Set Designation = @Designation,Salary = @Salary where Id = @Id";

                // Create a SqlCommand object
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the query
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Designation", GetDesignationId(designation));
                    command.Parameters.AddWithValue("@Id", advisorId);
                    command.Parameters.AddWithValue("@Salary", salary);
                    command.Parameters.AddWithValue("@Contact", contact);
                    command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);

                    // Execute the query
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Advisor data updated successfully.");
                        // Optionally, you can refresh the DataGridView here to reflect the updated data
                    }
                    else
                    {
                        MessageBox.Show("No advisor data found with the given ID.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }

}

