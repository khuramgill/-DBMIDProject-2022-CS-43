using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidProject.BL
{
    internal class GroupStudent
    {

        public int GroupId;
        public int StudentId;
        public int Status;
        public DateTime AssignmentDate;

        public GroupStudent(int groupId, int studentId, int status, DateTime assignmentDate)
        {
            GroupId = groupId;
            StudentId = studentId;
            Status = status;
            AssignmentDate = assignmentDate;
        }
    }
}
