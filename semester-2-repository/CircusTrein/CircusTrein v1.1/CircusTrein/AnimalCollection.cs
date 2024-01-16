using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein_BetterForEach
{
    public class AnimalCollection
    {
        // Constructors
        public AnimalCollection()
        {

        }

        // Fields
        static List<Animal> allAnimals = new List<Animal>();

        // Properties
        public List<Animal> AllAnimals { get { return allAnimals; } }

        // Methods
        public int CountSpecificAnimal(FoodTypeEnum foodType, SizeEnum size)
        {
            int animalCount = 0;
            foreach (Animal animal in allAnimals)
            {
                if (animal.FoodType == foodType && animal.Size == size)
                {
                    animalCount++;
                }
            }
            return animalCount;
        }

        public bool ContainsAnimal(FoodTypeEnum foodType)
        {
            foreach (Animal animal in AllAnimals)
            {
                if (animal.FoodType == foodType)
                {
                    return true;
                }
            }
            return false;
        }

        public Animal GetLast()
        {
            Animal lastAnimal = AllAnimals.Last();
            return lastAnimal;
        }

        public void RemoveLast()
        {
            AllAnimals.RemoveAt(AllAnimals.Count() - 1);
        }

        //Unused Methods
        //public List<Animal> GetAll()
        //{
        //    return AllAnimals;
        //}

        //public int Count()
        //{
        //    return allAnimals.Count;
        //}

        //public bool ContainsAnimal()
        //{
        //    foreach (Animal animal in AllAnimals)
        //    {
        //        return true;
        //    }
        //    return false;
        //}

        //public bool ContainsAnimal(FoodTypeEnum foodType, SizeEnum size)
        //{
        //    foreach (Animal animal in AllAnimals)
        //    {
        //        if (animal.FoodType == foodType && animal.Size == size)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}
    }
}
