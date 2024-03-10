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

namespace MidProject.Student
{
    public partial class Update : Form
    {
        private Students student;
        public Update(Students student)
        {
            InitializeComponent();
            this.student = student;

            // Populate the form fields with student details
            FirstName_textBox.Text = student.FirstName;
            LastName_textBox.Text = student.LastName;
            Contact_textBox.Text = student.Contact;
            Email_textBox.Text = student.Email;
            dateTimePicker1.Value = student.DateOfBirth;
            Gender_CB.SelectedItem = student.Gender;
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            // Get updated student details from form fields
            string firstName = FirstName_textBox.Text.Trim();
            string lastName = LastName_textBox.Text.Trim();
            string contact = Contact_textBox.Text.Trim();
            string email = Email_textBox.Text.Trim();
            DateTime dateOfBirth = dateTimePicker1.Value;
            string gender = Gender_CB.SelectedItem?.ToString();

            // Update student record in the database
            UpdateStudent(student.Id, firstName, lastName, contact, email, dateOfBirth, gender);

            ManageStudent m = new ManageStudent();

            // Close the update form
            this.Close();
        }

        private void UpdateStudent(int studentId, string firstName, string lastName, string contact, string email, DateTime dateOfBirth, string gender)
        {
            try
            {
                // Get the connection
                var connection = Configuration.getInstance().getConnection();

                // Prepare the SQL query
                string query = @"UPDATE [dbo].[Person] SET [FirstName] = @FirstName, [LastName] = @LastName, [Contact] = @Contact, [Email] = @Email, [DateOfBirth] = @DateOfBirth, [Gender] = @Gender WHERE [Id] = @StudentId";

                // Create a SqlCommand object
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the query
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@Contact", contact);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                    command.Parameters.AddWithValue("@Gender", gender == "Male" ?1:2);
                    command.Parameters.AddWithValue("@StudentId", studentId);

                    // Execute the query
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Student record updated successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

    }
}
