using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidProject.BL
{
    internal class GroupEvaluation
    {
        public int GroupId;
        public int EvaluationId;
        public int ObtainedMarks;
        public DateTime EvaluationDate;


        public GroupEvaluation(int GroupId, int EvaluationId, int ObtainedMarks, DateTime EvaluationDate) 
        {
            this.GroupId = GroupId;
            this.EvaluationId = EvaluationId;   
            this.EvaluationDate = EvaluationDate;
            this.ObtainedMarks = ObtainedMarks;        
        }


    }
}
