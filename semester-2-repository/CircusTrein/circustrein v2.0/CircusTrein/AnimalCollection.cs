using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein_BetterForeachNoStatic
{
    public class AnimalCollection
    {
        // Constructors
        public AnimalCollection()
        {

        }

        // Fields
        List<Animal> allAnimals = new List<Animal>();

        // Properties
        public List<Animal> AllAnimals { get { return allAnimals; } }

        // Methods
        public void SeperateAnimals(AnimalCollection animalCollection, HerbivoreCollection herbivoreCollection, CarnivoreCollection carnivoreCollection, Train train)
        {
            while (animalCollection.AllAnimalsContains(FoodTypeEnum.Carnivore) || animalCollection.AllAnimalsContains(FoodTypeEnum.Herbivore))
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
        public void OnlyRandomAnimals(int nAnimals, AnimalCollection animalCollection)
        {
            Random rnd = new Random();
            for (int i = 0; i < nAnimals; i++)
            {
                int randomNumber = rnd.Next(1, 7);
                switch (randomNumber)
                {
                    case 1:
                        Animal animal1 = new Animal(FoodTypeEnum.Carnivore, SizeEnum.Big, animalCollection);
                        //allAnimals.Add(animal1);
                        break;
                    case 2:
                        Animal animal2 = new Animal(FoodTypeEnum.Carnivore, SizeEnum.Medium, animalCollection);
                        //allAnimals.Add(animal2);
                        break;
                    case 3:
                        Animal animal3 = new Animal(FoodTypeEnum.Carnivore, SizeEnum.Small, animalCollection);
                        //allAnimals.Add(animal3);
                        break;
                    case 4:
                        Animal animal4 = new Animal(FoodTypeEnum.Herbivore, SizeEnum.Small, animalCollection);
                        //allAnimals.Add(animal4);
                        break;
                    case 5:
                        Animal animal5 = new Animal(FoodTypeEnum.Herbivore, SizeEnum.Medium, animalCollection);
                        //allAnimals.Add(animal5);
                        break;
                    case 6:
                        Animal animal6 = new Animal(FoodTypeEnum.Herbivore, SizeEnum.Big, animalCollection);
                        //allAnimals.Add(animal6);
                        break;
                }
            }
        }
        public bool AllAnimalsContains(FoodTypeEnum foodType)
        {
            return ContainsAnimal(foodType);
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
