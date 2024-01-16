using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein_BetterForeachNoStatic
{
    public class HerbivoreCollection
    {
        // Constrcutors
        public HerbivoreCollection()
        {

        }

        // Fields
        List<Animal> allHerbivores = new List<Animal>();
        List<Animal> allBigHerbivores = new List<Animal>();
        List<Animal> allMediumHerbivores = new List<Animal>();
        List<Animal> allSmallHerbivores = new List<Animal>();

        // Properties
        public List<Animal> AllHerbivores { get { return allHerbivores; } }
        public List<Animal> AllBigHerbivores { get { return allBigHerbivores; } }
        public List<Animal> AllMediumHerbivores { get { return allMediumHerbivores; } }
        public List<Animal> AllSmallHerbivores { get { return allSmallHerbivores; } }

        // Methods
        public bool ContainsAnimal(List<Animal> animalList)
        {
            foreach (Animal animal in animalList)
            {
                return true;
            }
            return false;
        }
        public Animal GetLast(List<Animal> animalList)
        {
            Animal lastAnimal = animalList.Last();
            return lastAnimal;
        }
        public void RemoveLast(List<Animal> animalList)
        {
            animalList.RemoveAt(animalList.Count() - 1);
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
