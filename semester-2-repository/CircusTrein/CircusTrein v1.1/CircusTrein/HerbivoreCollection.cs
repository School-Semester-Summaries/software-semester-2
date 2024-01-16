using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein_BetterForEach
{
    public class HerbivoreCollection
    {
        // Constrcutors
        public HerbivoreCollection()
        {

        }

        // Fields
        static List<Animal> allHerbivores = new List<Animal>();

        // Properties
        public List<Animal> AllHerbivores { get { return allHerbivores; } }

        // Methods
        public int CountSpecificAnimal(FoodTypeEnum foodType, SizeEnum size)
        {
            int animalCount = 0;
            foreach (Animal animal in allHerbivores)
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
            foreach (Animal animal in AllHerbivores)
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
            Animal lastAnimal = AllHerbivores.Last();
            return lastAnimal;
        }

        public void RemoveLast()
        {
            AllHerbivores.RemoveAt(AllHerbivores.Count() - 1);
        }

        //Unused Methods
        //public bool ContainsAnimal()
        //{
        //    foreach (Animal animal in AllHerbivores)
        //    {
        //        return true;
        //    }
        //    return false;
        //}
        //public bool ContainsAnimal(FoodTypeEnum foodType, SizeEnum size)
        //{
        //    foreach (Animal animal in AllHerbivores)
        //    {
        //        if (animal.FoodType == foodType && animal.Size == size)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}
        //public List<Animal> GetAll()
        //{
        //    return AllHerbivores;
        //}
        //public int Count()
        //{
        //    return allHerbivores.Count;
        //}
    }
}
