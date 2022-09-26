using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlankoMundo.Models
{
    public class MeetingRoom : ReservationType
    {
        public User User { get; set; } // is dit nodig?
        public int RoomID { get; set; }
        public int UserID { get; set; }
        public int Available { get; set; }
        public int Monitors { get; set; }
        public int Seats { get; set; }
        public int Floor { get; set; }
        public string Name { get; set; }
    }
}
