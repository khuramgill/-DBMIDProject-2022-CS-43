using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidProject.BL
{
    internal class GroupProject
    {

        public int ProjectId;
        public int GroupId;
        public DateTime AssignmentDate;


        public GroupProject(int ProjectId, int GroupId, DateTime AssignmentDate) { 
            this.ProjectId = ProjectId;
            this.GroupId = GroupId;
            this.AssignmentDate = AssignmentDate;
        }
    }
}
