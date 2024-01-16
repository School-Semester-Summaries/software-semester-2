using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein_BetterForEach
{
    public class Train
    {
        // Constrcutors
        public Train()
        {

        }

        // Constants
        const int bigHerbivoreMax = 5;
        const int mediumHerbivoreMax = 7;
        const int smallHerbivoreMax = 9;

        // Fields
        static List<Wagon> wagonList = new List<Wagon>();
        AnimalCollection animalCollection = new AnimalCollection();
        HerbivoreCollection herbivoreCollection = new HerbivoreCollection();

        // Properties
        public List<Wagon> WagonList { get { return wagonList; } }

        // Methods
        public void AddWagon(Wagon wagon)
        {
            wagonList.Add(wagon);
        }


        // Methods - Deze methods bevatten logic
        public void ClassifyCarnivores()
        {
            while (AllAnimalsConatins(FoodTypeEnum.Carnivore) || AllAnimalsConatins(FoodTypeEnum.Herbivore))
            {
                int animalAmount = animalCollection.AllAnimals.Count;

                for (int i = 0; i < animalAmount; i++)
                {
                    if (animalCollection.GetLast().FoodType == FoodTypeEnum.Carnivore)
                    {
                        Wagon wagon = new Wagon();
                        wagon.AddAnimal(animalCollection.GetLast());
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
        // func nest statuic
        public void ClassifyBigHerbivores(Wagon wagon)
        {
            if (wagon.ContainsAnimal(FoodTypeEnum.Carnivore, SizeEnum.Medium) && wagon.GetWagonAnimalValue() <= bigHerbivoreMax)
            {
                MoveAnimalToWagon(wagon);
            }
            else if (wagon.ContainsAnimal(FoodTypeEnum.Herbivore, SizeEnum.Medium) && wagon.GetWagonAnimalValue() <= bigHerbivoreMax)
            {
                MoveAnimalToWagon(wagon);
            }
            else if (wagon.ContainsAnimal(FoodTypeEnum.Herbivore, SizeEnum.Small) && wagon.GetWagonAnimalValue() <= bigHerbivoreMax)
            {
                MoveAnimalToWagon(wagon);
            }
            // bij small carnivore? solution -> big herbivores bewaren voor het laatst, begin met medium dan small dan big?
            else if (!wagon.ContainsAnimal())
            {
                MoveAnimalToWagon(wagon);
            }
        }
        public void ClassifyMediumHerbivores(Wagon wagon)
        {
            if (wagon.ContainsAnimal(FoodTypeEnum.Carnivore, SizeEnum.Small) && wagon.GetWagonAnimalValue() <= mediumHerbivoreMax)
            {
                MoveAnimalToWagon(wagon);
            }
            else if (wagon.ContainsAnimal(FoodTypeEnum.Herbivore, SizeEnum.Medium) && wagon.GetWagonAnimalValue() <= mediumHerbivoreMax)
            {
                MoveAnimalToWagon(wagon);
            }
            else if (wagon.ContainsAnimal(FoodTypeEnum.Herbivore, SizeEnum.Small) && wagon.GetWagonAnimalValue() <= mediumHerbivoreMax)
            {
                MoveAnimalToWagon(wagon);
            }
            else if (wagon.ContainsAnimal(FoodTypeEnum.Herbivore, SizeEnum.Big) && !wagon.ContainsAnimal(FoodTypeEnum.Carnivore) && wagon.GetWagonAnimalValue() <= mediumHerbivoreMax)
            {
                MoveAnimalToWagon(wagon);
            }
            else if (!wagon.ContainsAnimal())
            {
                MoveAnimalToWagon(wagon);
            }
        }
        public void ClassifySmallHerbivores(Wagon wagon)
        {
            if (!wagon.ContainsAnimal(FoodTypeEnum.Carnivore) && wagon.GetWagonAnimalValue() <= smallHerbivoreMax)
            {
                MoveAnimalToWagon(wagon);
            }
        }
        public void ClassifyHerbivores()
        {
            while (ThereAreHerbivoresInHerbivoreList())
            {
                Wagon newWagon = new Wagon();

                foreach (Wagon wagon in WagonList)
                {
                    if (ThereAreHerbivoresInHerbivoreList())
                    {
                        switch (herbivoreCollection.GetLast().Size)
                        {
                            case SizeEnum.Big:
                                ClassifyBigHerbivores(wagon);
                                break;
                            case SizeEnum.Medium:
                                ClassifyMediumHerbivores(wagon);
                                break;
                            case SizeEnum.Small:
                                ClassifySmallHerbivores(wagon);
                                break;
                        }
                    }
                }
            }
        }

        // Methods - Deze methods maken andere methods korter en leesbaarder
        public void ClassifyAllAnimals()
        {
            ClassifyCarnivores();
            ClassifyHerbivores();
        }
        public void MoveAnimalToWagon(Wagon wagon)
        {
            wagon.AddAnimal(herbivoreCollection.GetLast());
            herbivoreCollection.RemoveLast();
        }
        public bool ThereAreHerbivoresInHerbivoreList()
        {
            return herbivoreCollection.ContainsAnimal(FoodTypeEnum.Herbivore);
        }
        public bool AllAnimalsConatins(FoodTypeEnum foodType)
        {
            return animalCollection.ContainsAnimal(foodType);
        }
    }
}
