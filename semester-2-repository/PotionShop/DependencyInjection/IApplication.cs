using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotionShop.Presentation
{
    public interface IApplication
    {
        public void Run();
        public void AddPotion(string name, int cost);
    }
}
