using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotionShop.Logic.DalInterfaces
{
    public interface IPotionDAL
    {
        public void AddPotion(string name, int cost);
    }
}
