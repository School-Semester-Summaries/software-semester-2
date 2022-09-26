using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlankoMundo.Models
{
    public class Animal
    {
        public Animal(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }
        public int IsMeetingRoom { get; private set; }

        public string ChangeName(string newName)
        {
            Name = newName;
            return Name;
        }
        public void ChangeIsMeetingRoom(int fakeBoolLol)
        {
            IsMeetingRoom = fakeBoolLol;
        }
    }
}
