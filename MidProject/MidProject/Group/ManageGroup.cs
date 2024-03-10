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

namespace MidProject.Group
{
    public partial class ManageGroup : Form
    {
        public ManageGroup()
        {
            InitializeComponent();
            // Initialize DataGridView columns
            InitializeDataGridViewColumns();
            // Display all students in DataGridView
            DisplayStudentsOnDataGridView();
        }
        private void InitializeDataGridViewColumns()
        {
            // Add columns to DataGridView
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("FirstName", "First Name");
            dataGridView1.Columns.Add("LastName", "Last Name");
            dataGridView1.Columns.Add("Group", "Group");
            // Add checkbox column
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "Select";
            checkBoxColumn.Name = "Select";
            dataGridView1.Columns.Add(checkBoxColumn);
        }

        private void DisplayStudentsOnDataGridView()
        {
            try
            {
                var connection = Configuration.getInstance().getConnection();

                // Prepare the SQL query
                string query = @"SELECT * FROM [dbo].[Student]";

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

                    // Add a new column for checkboxes
                    DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
                    checkBoxColumn.HeaderText = "Select";
                    checkBoxColumn.Name = "Select";
                    checkBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    checkBoxColumn.FlatStyle = FlatStyle.Standard;
                    checkBoxColumn.CellTemplate = new DataGridViewCheckBoxCell();

                    // Add the checkbox column to the DataGridView
                    dataGridView1.Columns.Insert(0, checkBoxColumn);

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }


        private void ManageGroup_Load(object sender, EventArgs e)
        {

        }

        private void Search_btn_Click_1(object sender, EventArgs e)
        {
            // Get the student ID to search for
            string studentID = ID_textBox.Text.Trim();

            // Search for the student in the DataGridView
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["ID"].Value.ToString() == studentID)
                {
                    // Select the row and bring it to the top
                    row.Selected = true;
                    dataGridView1.CurrentCell = row.Cells[0];
                    break;
                }
            }
        }

        private void MakeGroup_btn_Click(object sender, EventArgs e)
        {
            // Initialize a counter for the number of selected students
            int selectedCount = 0;
            // Create a list to store the IDs of selected students
            List<int> selectedStudentIDs = new List<int>();

            // Iterate through DataGridView rows
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = row.Cells["Select"] as DataGridViewCheckBoxCell;
                // Check if the checkbox is selected
                if (checkBoxCell != null && (bool)checkBoxCell.Value)
                {
                    selectedCount++;
                    // Retrieve the student ID and add it to the list
                    int studentID = Convert.ToInt32(row.Cells["ID"].Value);
                    selectedStudentIDs.Add(studentID);
                }
            }

            // Validate the number of selected students
            if (selectedCount < 1 || selectedCount > 4)
            {
                MessageBox.Show("A group must contain between 1 and 4 students.");
                return;
            }

            // Insert the selected students into the Group table
            try
            {
                var connection = Configuration.getInstance().getConnection();
                // Prepare the SQL query to insert into the Group table
                string query = @"INSERT INTO [dbo].[Group] (GroupID, StudentID) VALUES (@GroupID, @StudentID)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Generate a unique GroupID
                    int groupID = GetNextGroupID(connection);
                    // Add parameters to the query
                    foreach (int studentID in selectedStudentIDs)
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@GroupID", groupID);
                        command.Parameters.AddWithValue("@StudentID", studentID);
                        // Execute the query for each selected student
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("Group created successfully.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                MessageBox.Show("Failed to create group.");
            }
        }
        private int GetNextGroupID(SqlConnection connection)
        {
            string query = "SELECT ISNULL(MAX(GroupID), 0) + 1 FROM [dbo].[Group]";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                return (int)command.ExecuteScalar();
            }
        }

    }
    


}
