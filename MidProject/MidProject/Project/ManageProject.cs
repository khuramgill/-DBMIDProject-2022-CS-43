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

namespace MidProject.Project
{
    public partial class ManageProject : Form
    {
        public ManageProject()
        {
            InitializeComponent();
            DisplayProjectsOnDataGridView();
        }

        private void DisplayProjectsOnDataGridView()
        {
            try
            {
                var connection = Configuration.getInstance().getConnection();

                // Prepare the SQL query
                string query = @"SELECT * FROM [dbo].[Project]";

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

        private void Insert_btn_Click(object sender, EventArgs e)
        {
            if (ValidateInputData())
            {
                string ProjectTitle = ProjectTitle_textBox.Text.Trim();
                string Description = Description_textBox.Text.Trim();

                InsertProject(ProjectTitle, Description);
                DisplayProjectsOnDataGridView();

            }
        }

        private bool ValidateInputData()
        {
            string ProjectTitle = ProjectTitle_textBox.Text.Trim();
            string Description = Description_textBox.Text.Trim();
            string ProjectID = ProjectID_textBox.Text.Trim();

            // Validate first name
            if (string.IsNullOrEmpty(ProjectTitle))
            {
                MessageBox.Show("ProjectTitle cannot be empty");
                return false;
            }

            // Validate last name
            if (string.IsNullOrEmpty(Description))
            {
                MessageBox.Show("Description cannot be empty");
                return false;
            }

            //// Validate ProjectID (should be a number)
            //if (string.IsNullOrEmpty(ProjectID) || !int.TryParse(ProjectID, out _))
            //{
            //    MessageBox.Show("ProjectID should be a number");
            //    return false;
            //}

            
            return true;
        }
        private void InsertProject(string title, string description)
        {
            try
            {
                var connection = Configuration.getInstance().getConnection();

                // Prepare the SQL query
                string query = @"INSERT INTO [dbo].[Project] ([Title], [Description]) 
                         VALUES (@Title, @Description)";

                // Create a SqlCommand object
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the query
                    command.Parameters.AddWithValue("@Title", title);
                    command.Parameters.AddWithValue("@Description", description);

                    // Execute the query
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Project inserted successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            if (ValidateInputData())
            {
                string ProjectID = ProjectID_textBox.Text.Trim();
                if (string.IsNullOrEmpty(ProjectID) || !int.TryParse(ProjectID, out _))
                    {
                        MessageBox.Show("ProjectID should be a number");
                        return;
                    }
                string ProjectTitle = ProjectTitle_textBox.Text.Trim();
                string Description = Description_textBox.Text.Trim();
                int p = int.Parse(ProjectID);
                UpdateProject(p,ProjectTitle, Description);
                DisplayProjectsOnDataGridView();
            }
        }

        private void UpdateProject(int projectId, string title, string description)
        {
            try
            {
                var connection = Configuration.getInstance().getConnection();

                // Prepare the SQL query
                string query = @"UPDATE [dbo].[Project] 
                         SET [Title] = @Title, [Description] = @Description 
                         WHERE [Id] = @Id";

                // Create a SqlCommand object
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the query
                    command.Parameters.AddWithValue("@Title", title);
                    command.Parameters.AddWithValue("@Description", description);
                    command.Parameters.AddWithValue("@Id", projectId);

                    // Execute the query
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Project updated successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            if (ValidateInputData())
            {

                if (string.IsNullOrEmpty(ProjectID_textBox.Text) || !int.TryParse(ProjectID_textBox.Text, out _))
                {
                    MessageBox.Show("ProjectID should be a number");
                    return;
                }

                int p = int.Parse(ProjectID_textBox.Text);
                DeleteProject(p);
                DisplayProjectsOnDataGridView();
            }
        }

        private void DeleteProject(int projectId)
        {
            try
            {
                var connection = Configuration.getInstance().getConnection();

                // Prepare the SQL query
                string query = @"DELETE FROM [dbo].[Project] WHERE [Id] = @Id";

                // Create a SqlCommand object
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the query
                    command.Parameters.AddWithValue("@Id", projectId);

                    // Execute the query
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Project deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("No project found with the given ID.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }
    }
}
