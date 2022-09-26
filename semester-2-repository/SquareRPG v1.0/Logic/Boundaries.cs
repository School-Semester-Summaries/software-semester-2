using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Boundaries
    {
        // Properties
        static public List<int[]> BoundariesList { get { return _boundariesList; } }

        // Fields
        static List<int[]> _boundariesList = new List<int[]>();

        // Methods
        static public void AddBoundaries(int up, int right, int down, int left)
        {
            int[] boundaries = { up, right, down, left };
            _boundariesList.Add(boundaries);
        }
    }
}
