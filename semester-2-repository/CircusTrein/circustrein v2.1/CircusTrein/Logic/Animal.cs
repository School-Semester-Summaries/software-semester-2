using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein_Perfect
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
        public Animal(FoodTypeEnum foodType, SizeEnum size, AnimalCollection animalCollection)
        {
            FoodType = foodType;
            Size = size;
            animalCollection.AllAnimals.Add(this);
        }

        // Properties
        public FoodTypeEnum FoodType { get; private set; }
        public SizeEnum Size { get; private set; }
        public string Name { get { return Size.ToString() + " " + FoodType.ToString(); } }
    }
}
