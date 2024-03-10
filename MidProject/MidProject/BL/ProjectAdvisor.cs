using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidProject.BL
{
    internal class ProjectAdvisor
    {
        public int AdvisorId;
        public int ProjectId;
        public int AdvisorRole;
        public DateTime AssignmentDate;

        public ProjectAdvisor(int advisorId, int projectId, int advisorRole, DateTime assignmentDate)
        {
            AdvisorId = advisorId;
            ProjectId = projectId;
            AdvisorRole = advisorRole;
            AssignmentDate = assignmentDate;
        }
    }
}
