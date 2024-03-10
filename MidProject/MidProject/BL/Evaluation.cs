using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidProject.BL
{
    internal class Evaluation
    {
        public int ID;
        public string Name;
        public int TotalMarks;
        public int TotalWeightage;

        public Evaluation(int ID, string Name, int TotalMarks, int TotalWeightage)
        {
            this.ID = ID;
            this.Name = Name;
            this.TotalMarks = TotalMarks;
            this.TotalWeightage = TotalWeightage;   

        }

    }
}
