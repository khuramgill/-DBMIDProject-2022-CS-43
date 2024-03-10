using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidProject.BL
{
    internal class Project
    {
        public int ID;
        public string Description;
        public string Title;

        public Project(int ID, string Description, string Title) {
            this.ID = ID;
            this.Description = Description;
            this.Title = Title;
        }

        public Project(int ID, string Title)
        {
            this.ID = ID;
            this.Title = Title;
        }

    }
}
