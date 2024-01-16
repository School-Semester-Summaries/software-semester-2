using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein_Perfect
{
    public class AnimalCollection
    {
        // Constructors
        public AnimalCollection()
        {

        }

        // Fields
        readonly List<Animal> allAnimals = new List<Animal>();

        // Properties
        public List<Animal> AllAnimals { get { return allAnimals; } }

        // Methods - Big
        public void SeperateAnimals(AnimalCollection animalCollection, HerbivoreCollection herbivoreCollection, CarnivoreCollection carnivoreCollection)
        {
            while (animalCollection.ContainsAnimal(animalCollection.AllAnimals))
            {
                int animalAmount = animalCollection.AllAnimals.Count;

                for (int i = 0; i < animalAmount; i++)
                {
                    if (animalCollection.GetLast().FoodType == FoodTypeEnum.Carnivore)
                    {
                        carnivoreCollection.AllCarnivores.Add(animalCollection.GetLast());
                        animalCollection.RemoveLast();
                    }
                    else if (animalCollection.GetLast().FoodType == FoodTypeEnum.Herbivore)
                    {
                        herbivoreCollection.AllHerbivores.Add(animalCollection.GetLast());
                        animalCollection.RemoveLast();
                    }
                }
            }
        }
        public void OnlyRandomAnimals(int nAnimals)
        {
            Random rnd = new Random();
            for (int i = 0; i < nAnimals; i++)
            {
                int randomAnimal = rnd.Next(1, 7);
                switch (randomAnimal)
                {
                    case 1:
                        new Animal(FoodTypeEnum.Carnivore, SizeEnum.Big, this);
                        break;
                    case 2:
                        new Animal(FoodTypeEnum.Carnivore, SizeEnum.Medium, this);
                        break;
                    case 3:
                        new Animal(FoodTypeEnum.Carnivore, SizeEnum.Small, this);
                        break;
                    case 4:
                        new Animal(FoodTypeEnum.Herbivore, SizeEnum.Small, this);
                        break;
                    case 5:
                        new Animal(FoodTypeEnum.Herbivore, SizeEnum.Medium, this);
                        break;
                    case 6:
                        new Animal(FoodTypeEnum.Herbivore, SizeEnum.Big, this);
                        break;
                }
            }
        } // inheritance?

        // Methods - Small
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
        public bool ContainsAnimal(List<Animal> animalList)
        {
            return animalList.Count > 0;
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
    }
}
