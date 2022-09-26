using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.NeoFighters
{
    public class Grarrl : NeoFighter
    {
        public Grarrl()
        {
            SetName(NeoFighterNames.Grarrl);
            SetHealth(320);
            SetAttackPower(32);
            SetCritRatio(5);
        }
    }
}
