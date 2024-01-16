using CircusTrein_BetterForeachNoStatic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein_BetterForeachNoStatic
{
    public class CarnivoreCollection
    {
        // Constrcutors
        public CarnivoreCollection()
        {

        }

        // Fields
        List<Animal> allCarnivores = new List<Animal>();

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
        public void ClassifyCarnivores(Train train, CarnivoreCollection carnivoreCollection)
        {
            int allCarnivores = carnivoreCollection.AllCarnivores.Count;

            for (int i = 0; i < allCarnivores; i++)
            {
                Wagon wagon = new Wagon(train);
                wagon.AddAnimal(carnivoreCollection.GetLast());
                carnivoreCollection.RemoveLast();
            }

            //foreach (Animal animal in carnivoreCollection.AllCarnivores)
            //{
            //    Wagon wagon = new Wagon(train);
            //    wagon.AddAnimal(carnivoreCollection.GetLast());
            //    carnivoreCollection.RemoveLast();
            //}
            // gaat ni moidfy error
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
