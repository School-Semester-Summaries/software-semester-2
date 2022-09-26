using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlankoMundo.Models
{
    public class WorkSpace : ReservationType
    {
        public User User { get; set; } // is dit nodig?
        public int SpotID { get; set; }
        public int UserID { get; set; }
        public int WorkroomID { get; set; }
        public int Available { get; set; }
        public int Floor { get; set; }
        public string Name { get; set; }
    }
}
