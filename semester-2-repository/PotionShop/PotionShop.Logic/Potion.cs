using PotionShop.Logic.DalInterfaces;

namespace PotionShop.Logic
{
    public class Potion : IPotion
    {
        // Constructor
        public Potion(IPotionDAL potionDAL)
        {

            _dal = potionDAL;
        } 

        // Fields
        public IPotionDAL _dal;
        
        // Properties
        public string Name { get; private set; }
        public int Cost { get; private set; }

        public void Run()
        {
            System.Console.WriteLine("gg");
        }
        public void AddPotion(string name, int cost)
        {
            _dal.AddPotion(name, cost);
        }

    }
}
