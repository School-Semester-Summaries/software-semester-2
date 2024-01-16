using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein_BetterForeachNoStatic
{
    public class Wagon
    {
        // Constructor
        public Wagon(Train train)
        {
            train.AddWagon(this);
        }

        // Fields 
        List<Animal> animalList = new List<Animal>();

        // Properties
        public List<Animal> AnimalList { get { return animalList; } }

        // Methods
        public void AddAnimal(Animal animal)
        {
            AnimalList.Add(animal);
        }
        public bool ContainsAnimal()
        {
            return animalList.Count != 0;
        }
        public bool ContainsAnimal(FoodTypeEnum foodType)
        {
            foreach (Animal animal in AnimalList)
            {
                if (animal.FoodType == foodType)
                {
                    return true;
                }
            }
            return false;
        }
        public bool ContainsAnimal(FoodTypeEnum foodType, SizeEnum size)
        {
            foreach (Animal animal in AnimalList)
            {
                if (animal.FoodType == foodType && animal.Size == size)
                {
                    return true;
                }
            }
            return false;
        }
        public int GetWagonAnimalValue()
        {
            int wagonAnimalValue = 0; // because empty
            foreach (Animal animal in AnimalList)
            {
                wagonAnimalValue += (int)animal.Size;
            }
            return wagonAnimalValue;
        }
    }
}
