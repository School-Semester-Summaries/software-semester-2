using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    public class Train
    {
        // Constrcutors
        public Train()
        {

        }

        // Fields
        static List<Wagon> wagonList = new List<Wagon>();

        // Properties
        public List<Wagon> WagonList { get { return wagonList; } }

        // Methods
        public void AddWagon(Wagon wagon)
        {
            wagonList.Add(wagon);
        }
    }
}
