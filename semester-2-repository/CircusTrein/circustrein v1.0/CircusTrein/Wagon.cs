using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    public class Wagon
    {
        // Constructor
        public Wagon()
        {
            train.AddWagon(this);
        }

        // Fields
        List<Animal> animalList = new List<Animal>();
        static Train train = new Train();

        // Properties
        public List<Animal> AnimalList { get { return animalList; } }

        // Methods
        public void AddAnimal(Animal animal)
        {
            animalList.Add(animal);
        }
        public bool ContainsAnimal()
        {
            foreach (Animal animal in animalList)
            {
                return true;
            }
            return false;
        }
        public bool ContainsAnimal(FoodTypeEnum foodType)
        {
            foreach (Animal animal in animalList)
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
            foreach (Animal animal in animalList)
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
            foreach (Animal animal in animalList)
            {
                wagonAnimalValue += animal.SizeValue;
            }
            return wagonAnimalValue;
        }
    }
}
