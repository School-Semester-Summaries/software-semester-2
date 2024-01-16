using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein_BetterForeachNoStatic
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
        List<Wagon> wagonList = new List<Wagon>();
        HerbivoreCollection herbivoreCollection = new HerbivoreCollection();
        CarnivoreCollection carnivoreCollection = new CarnivoreCollection();

        // Properties
        public List<Wagon> WagonList { get { return wagonList; } }

        // Methods
        public void AddWagon(Wagon wagon)
        {
            wagonList.Add(wagon);
        }


        // Methods - Deze methods bevatten logic
        public void SeperateAnimals(AnimalCollection animalCollection, Train train)
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
        public void SeperateHerbivores(AnimalCollection animalCollection, Train train) // naar herbivore collection
        {
            while (herbivoreCollection.ContainsAnimal(herbivoreCollection.AllHerbivores))
            {
                int herbivoreAmount = herbivoreCollection.AllHerbivores.Count;

                for (int i = 0; i < herbivoreAmount; i++)
                {
                    switch (herbivoreCollection.GetLast(herbivoreCollection.AllHerbivores).Size)
                    {
                        case SizeEnum.Big:
                            herbivoreCollection.AllBigHerbivores.Add(herbivoreCollection.GetLast(herbivoreCollection.AllHerbivores));
                            herbivoreCollection.RemoveLast(herbivoreCollection.AllHerbivores);
                            break;
                        case SizeEnum.Medium:
                            herbivoreCollection.AllMediumHerbivores.Add(herbivoreCollection.GetLast(herbivoreCollection.AllHerbivores));
                            herbivoreCollection.RemoveLast(herbivoreCollection.AllHerbivores);
                            break;
                        case SizeEnum.Small:
                            herbivoreCollection.AllSmallHerbivores.Add(herbivoreCollection.GetLast(herbivoreCollection.AllHerbivores));
                            herbivoreCollection.RemoveLast(herbivoreCollection.AllHerbivores);
                            break;
                    }
                }
            }
        }
        public void ClassifyCarnivores(Train train)
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
        public void Phase1_ClassifyBigHerbivoresWithMediumCarnivores(List<Wagon> wagonList, Train train)
        {
            bool phase2 = true;
            bool brokeOut = false;
            while (phase2)
            {
                foreach (Wagon wagon in WagonList)
                {
                    if (herbivoreCollection.ContainsAnimal(herbivoreCollection.AllBigHerbivores))
                    {
                        if (wagon.ContainsAnimal(FoodTypeEnum.Carnivore, SizeEnum.Medium) && wagon.GetWagonAnimalValue() <= bigHerbivoreMax)
                        {
                            MoveBigHerbivoreToWagon(wagon);
                            brokeOut = true;
                            break;
                        }
                    }
                    if (brokeOut == false)
                    {
                        phase2 = false;
                    }
                    brokeOut = false;
                }
            }
        }
        public void Phase2_ClassifyMediumHerbivores(List<Wagon> wagonList, Train train)
        {
            bool brokeOut = false;
            bool phase2 = true;
            while (phase2)
            {
                foreach (Wagon wagon in WagonList)
                {
                    if (wagon.ContainsAnimal(FoodTypeEnum.Carnivore, SizeEnum.Small) && herbivoreCollection.AllMediumHerbivores.Count >= 3 && wagon.GetWagonAnimalValue() == 1)
                    {
                        wagon.AddAnimal(herbivoreCollection.GetLast(herbivoreCollection.AllMediumHerbivores));
                        herbivoreCollection.RemoveLast(herbivoreCollection.AllMediumHerbivores);
                        wagon.AddAnimal(herbivoreCollection.GetLast(herbivoreCollection.AllMediumHerbivores));
                        herbivoreCollection.RemoveLast(herbivoreCollection.AllMediumHerbivores);
                        wagon.AddAnimal(herbivoreCollection.GetLast(herbivoreCollection.AllMediumHerbivores));
                        herbivoreCollection.RemoveLast(herbivoreCollection.AllMediumHerbivores);
                        break;
                    }
                    else if (!wagon.ContainsAnimal() && herbivoreCollection.AllMediumHerbivores.Count >= 3)
                    {
                        wagon.AddAnimal(herbivoreCollection.GetLast(herbivoreCollection.AllMediumHerbivores));
                        herbivoreCollection.RemoveLast(herbivoreCollection.AllMediumHerbivores);
                        wagon.AddAnimal(herbivoreCollection.GetLast(herbivoreCollection.AllMediumHerbivores));
                        herbivoreCollection.RemoveLast(herbivoreCollection.AllMediumHerbivores);
                        wagon.AddAnimal(herbivoreCollection.GetLast(herbivoreCollection.AllMediumHerbivores));
                        herbivoreCollection.RemoveLast(herbivoreCollection.AllMediumHerbivores);
                        break;
                    }
                    else if (herbivoreCollection.AllMediumHerbivores.Count <= 3)
                    {
                        phase2 = false;
                    }
                }
                if (brokeOut == false)
                {
                    phase2 = false;
                }
                brokeOut = false;
            }
        }
        public void Phase3_ClassifyRemainingBigHerbivoresAndMediumHerbivoresWithSmallCarnivores(List<Wagon> wagonList, Train train)
        {
            if (herbivoreCollection.ContainsAnimal(herbivoreCollection.AllBigHerbivores) || herbivoreCollection.ContainsAnimal(herbivoreCollection.AllMediumHerbivores))
            {
                bool brokeout = false;
                bool phase3 = true;
                while (phase3)
                {
                    foreach (Wagon wagon in WagonList)
                    {
                        if (wagon.ContainsAnimal(FoodTypeEnum.Carnivore, SizeEnum.Small))
                        {
                            // Nog Big H. && Nog Med H. && wagonValue == 1
                            if (herbivoreCollection.ContainsAnimal(herbivoreCollection.AllBigHerbivores) && herbivoreCollection.ContainsAnimal(herbivoreCollection.AllMediumHerbivores) && wagon.GetWagonAnimalValue()  == 1)
                            {
                                wagon.AddAnimal(herbivoreCollection.GetLast(herbivoreCollection.AllBigHerbivores));
                                herbivoreCollection.RemoveLast(herbivoreCollection.AllBigHerbivores);
                                wagon.AddAnimal(herbivoreCollection.GetLast(herbivoreCollection.AllMediumHerbivores));
                                herbivoreCollection.RemoveLast(herbivoreCollection.AllMediumHerbivores);
                                brokeout = true;
                                break;
                            }
                            // Nog Big H. && wagonValue == 1
                            else if (herbivoreCollection.ContainsAnimal(herbivoreCollection.AllBigHerbivores) && wagon.GetWagonAnimalValue() == 1)
                            {
                                wagon.AddAnimal(herbivoreCollection.GetLast(herbivoreCollection.AllBigHerbivores));
                                herbivoreCollection.RemoveLast(herbivoreCollection.AllBigHerbivores);
                                brokeout = true;
                                break;
                            }
                            // Nog Med H. && wagonValue == 7
                            else if (herbivoreCollection.ContainsAnimal(herbivoreCollection.AllMediumHerbivores) && wagon.GetWagonAnimalValue() <= mediumHerbivoreMax)
                            {
                                wagon.AddAnimal(herbivoreCollection.GetLast(herbivoreCollection.AllMediumHerbivores));
                                herbivoreCollection.RemoveLast(herbivoreCollection.AllMediumHerbivores);
                                brokeout = true;
                                break;
                            }
                        }

                    }
                    if (brokeout == false)
                    {
                        phase3 = false;
                    }
                    brokeout = false;
                }
            }
        }
        public void Phase4_ClassifyRemainingBigHerbivoresAndMediumHerbivores(List<Wagon> wagonList, Train train)
        {
            if (herbivoreCollection.ContainsAnimal(herbivoreCollection.AllBigHerbivores) || herbivoreCollection.ContainsAnimal(herbivoreCollection.AllMediumHerbivores))
            {
                bool phase4 = true;
                bool brokeout = false;
                while (phase4)
                {
                    foreach (Wagon wagon in WagonList)
                    {
                        if (herbivoreCollection.ContainsAnimal(herbivoreCollection.AllBigHerbivores))
                        {
                            if (wagon.ContainsAnimal(FoodTypeEnum.Herbivore) && !wagon.ContainsAnimal(FoodTypeEnum.Carnivore) && wagon.GetWagonAnimalValue() <= bigHerbivoreMax)
                            {
                                wagon.AddAnimal(herbivoreCollection.GetLast(herbivoreCollection.AllBigHerbivores));
                                herbivoreCollection.RemoveLast(herbivoreCollection.AllBigHerbivores);
                                brokeout = true;
                                break;
                            }
                            else if (!wagon.ContainsAnimal())
                            {
                                wagon.AddAnimal(herbivoreCollection.GetLast(herbivoreCollection.AllBigHerbivores));
                                herbivoreCollection.RemoveLast(herbivoreCollection.AllBigHerbivores);
                                brokeout = true;
                                break;
                            }
                        }
                        if (herbivoreCollection.ContainsAnimal(herbivoreCollection.AllMediumHerbivores))
                        {
                            if (wagon.ContainsAnimal(FoodTypeEnum.Herbivore) && !wagon.ContainsAnimal(FoodTypeEnum.Carnivore) && wagon.GetWagonAnimalValue() <= mediumHerbivoreMax)
                            {
                                wagon.AddAnimal(herbivoreCollection.GetLast(herbivoreCollection.AllMediumHerbivores));
                                herbivoreCollection.RemoveLast(herbivoreCollection.AllMediumHerbivores);
                                brokeout = true;
                                break;
                            }
                            if (!wagon.ContainsAnimal())
                            {
                                wagon.AddAnimal(herbivoreCollection.GetLast(herbivoreCollection.AllMediumHerbivores));
                                herbivoreCollection.RemoveLast(herbivoreCollection.AllMediumHerbivores);
                                brokeout = true;
                                break;
                            }
                        }
                    }
                    if (brokeout == false)
                    {
                        phase4 = false;
                    }
                    brokeout = false;
                }
            }
        }
        public void Phase5_ClassifySmallHerbivores(List<Wagon> wagonList, Train train)
        {
            if (herbivoreCollection.ContainsAnimal(herbivoreCollection.AllSmallHerbivores))
            {
                bool phase5 = true;
                bool brokeout = false;
                while (phase5)
                {
                    foreach (Wagon wagon in WagonList)
                    {
                        if (herbivoreCollection.ContainsAnimal(herbivoreCollection.AllSmallHerbivores))
                        {
                            if (!wagon.ContainsAnimal(FoodTypeEnum.Carnivore) && wagon.GetWagonAnimalValue() <= smallHerbivoreMax)
                            {
                                wagon.AddAnimal(herbivoreCollection.GetLast(herbivoreCollection.AllSmallHerbivores));
                                herbivoreCollection.RemoveLast(herbivoreCollection.AllSmallHerbivores);
                                brokeout = true;
                                break;
                            }
                        }
                    }
                    if (brokeout == false)
                    {
                        phase5 = false;
                    }
                    brokeout = false;
                }
            }
        }
        public void ClassifyHerbivores(Train train)
        {
            while (ThereAreHerbivoresLeft())
            {
                Wagon newWagon = new Wagon(train);

                Phase1_ClassifyBigHerbivoresWithMediumCarnivores(WagonList, train);
                Phase2_ClassifyMediumHerbivores(WagonList, train);
                Phase3_ClassifyRemainingBigHerbivoresAndMediumHerbivoresWithSmallCarnivores(WagonList, train);
                Phase4_ClassifyRemainingBigHerbivoresAndMediumHerbivores(WagonList, train);
                Phase5_ClassifySmallHerbivores(WagonList, train);

                if (!WagonList.Last().ContainsAnimal())
                {
                    WagonList.RemoveAt(wagonList.Count - 1);
                }
            }
        }

        // Methods - Deze methods maken andere methods korter en leesbaarder
        public void ClassifyAllAnimals(AnimalCollection animalCollection, Train train)
        {
            //animalCollection.SeperateAnimals(animalCollection, herbivoreCollection, carnivoreCollection, train);
            SeperateAnimals(animalCollection, train);
            //carnivoreCollection.ClassifyCarnivores(train, carnivoreCollection);
            ClassifyCarnivores(train);
            SeperateHerbivores(animalCollection, train);
            ClassifyHerbivores(train);
        }
        public void MoveBigHerbivoreToWagon(Wagon wagon)
        {
            wagon.AddAnimal(herbivoreCollection.GetLast(herbivoreCollection.AllBigHerbivores));
            herbivoreCollection.RemoveLast(herbivoreCollection.AllBigHerbivores);
        }
        public bool ThereAreHerbivoresLeft()
        {
            if (herbivoreCollection.AllBigHerbivores.Count > 0)
            {
                return true;
            }
            if (herbivoreCollection.AllMediumHerbivores.Count > 0)
            {
                return true;
            }
            if (herbivoreCollection.AllSmallHerbivores.Count > 0)
            {
                return true;
            }
            return false;
        }
    }
}

// for loop over foreach want modify list