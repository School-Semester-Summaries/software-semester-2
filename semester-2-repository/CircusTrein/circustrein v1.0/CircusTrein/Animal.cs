using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    public enum FoodTypeEnum
    {
        Carnivore,
        Herbivore
    }
    public enum SizeEnum
    {
        Small = 1,
        Medium = 3,
        Big = 5
    }


    public class Animal
    {
        // Constructors
        public Animal() { } // dit bestaat aleen zodat ik de shit hierin kan accessen, ?
        public Animal(FoodTypeEnum foodType, SizeEnum size)
        {
            FoodType = foodType;
            Size = size;
            animalCollection.AllAnimals.Add(this);
        }

        // Fields
        static AnimalCollection animalCollection = new AnimalCollection();

        // Properties
        public FoodTypeEnum FoodType { get; private set; }
        public SizeEnum Size { get; private set; }
        public string Name { get { return Size.ToString() + " " + FoodType.ToString(); } }
        public int SizeValue { get { return (int)Size; } }

        //Unused Methods
        //public void Create(FoodTypeEnum foodType, SizeEnum size)
        //{
        //    Animal animal = new Animal(foodType, size);
        //}
    }
}
