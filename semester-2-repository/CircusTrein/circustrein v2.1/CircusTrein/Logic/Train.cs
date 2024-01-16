using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein_Perfect
{
    public class Train
    {
        // Constrcutors
        public Train()
        {

        }

        // Fields
        readonly List<Wagon> wagonList = new List<Wagon>();

        // Properties
        public List<Wagon> WagonList { get { return wagonList; } }

        // Methods
        public void DistributeAllAnimals(Train train, AnimalCollection animalCollection, HerbivoreCollection herbivoreCollection, CarnivoreCollection carnivoreCollection)
        {
            animalCollection.SeperateAnimals(animalCollection, herbivoreCollection, carnivoreCollection);
            carnivoreCollection.DistributeCarnivores(train, carnivoreCollection);
            herbivoreCollection.SeperateHerbivores();
            herbivoreCollection.DistributeHerbivores(train);
        }
        public void AddWagon(Wagon wagon)
        {
            wagonList.Add(wagon);
        }
    }
}

// for loop over foreach want modify list