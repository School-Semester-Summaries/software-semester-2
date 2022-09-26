using PotionShop.Logic.DalInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotionShop.Presentation
{
    public class Application : IApplication
    {
        IPotion _potion;
        public Application(IPotion potion)
        {
            _potion = potion;
        }
        public void Run()
        {
            _potion.Run();
        }
        public void AddPotion(string name, int cost)
        {
            _potion.AddPotion(name, cost);
        }
    }
}
