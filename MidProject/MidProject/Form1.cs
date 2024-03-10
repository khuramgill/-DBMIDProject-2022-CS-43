using MidProject.Advisor;
using MidProject.Project;
using MidProject.Student;
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

namespace MidProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Student_btn_Click(object sender, EventArgs e)
        {
            ManageStudent manageStudent = new ManageStudent();
            manageStudent.Show();
            this.Hide();
        }

        private void Advisor_btn_Click(object sender, EventArgs e)
        {
            ManageAdvisor manageAdvisor = new ManageAdvisor();
            manageAdvisor.Show();
            this.Hide();
        }

        private void Project_btn_Click(object sender, EventArgs e)
        {
            ManageProject manageProject = new ManageProject();
            manageProject.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
