using CircusTrein_Perfect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein_Perfect
{
    public class CarnivoreCollection
    {
        // Constrcutors
        public CarnivoreCollection()
        {

        }

        // Fields
        readonly List<Animal> allCarnivores = new List<Animal>();

        // Properties
        public List<Animal> AllCarnivores { get { return allCarnivores; } }

        // Methods
        public Animal GetLast()
        {
            Animal lastAnimal = AllCarnivores.Last();
            return lastAnimal;
        }
        public void RemoveLast()
        {
            AllCarnivores.RemoveAt(AllCarnivores.Count() - 1);
        }
        public void DistributeCarnivores(Train train, CarnivoreCollection carnivoreCollection)
        {
            int allCarnivores = carnivoreCollection.AllCarnivores.Count;

            for (int i = 0; i < allCarnivores; i++) // foreach gives modify error
            {
                Wagon wagon = new Wagon(train);
                wagon.AddAnimal(carnivoreCollection.GetLast());
                carnivoreCollection.RemoveLast();
            }
        }
    }
}
