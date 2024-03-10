using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidProject.BL
{
    public class Group
    {
        public int Id { get; set; }
        public string GroupName { get; set; }
        public DateTime CreationDate { get; set; }
        public List<Students> Students { get; set; } 

        public Group()
        {
            Students = new List<Students>();
        }
    }
}
