using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.NeoFighters
{
    public class Blumaroo : NeoFighter
    {
        public Blumaroo()
        {
            SetName(NeoFighterNames.Blumaroo);
            SetHealth(300);
            SetAttackPower(29);
            SetCritRatio(10);
        }
    }
}
