using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein_Perfect
{
    public class HerbivoreCollection
    {
        // Constrcutors
        public HerbivoreCollection()
        {

        }

        // Fields
        readonly List<Animal> allHerbivores = new List<Animal>();
        readonly List<Animal> allBigHerbivores = new List<Animal>();
        readonly List<Animal> allMediumHerbivores = new List<Animal>();
        readonly List<Animal> allSmallHerbivores = new List<Animal>();

        // Properties
        public List<Animal> AllHerbivores { get { return allHerbivores; } }
        public List<Animal> AllBigHerbivores { get { return allBigHerbivores; } }
        public List<Animal> AllMediumHerbivores { get { return allMediumHerbivores; } }
        public List<Animal> AllSmallHerbivores { get { return allSmallHerbivores; } }

        // Methods - Big
        public void SeperateHerbivores()
        {
            while (ContainsAnimal(AllHerbivores))
            {
                int herbivoreAmount = AllHerbivores.Count;

                for (int i = 0; i < herbivoreAmount; i++)
                {
                    switch (GetLast(AllHerbivores).Size)
                    {
                        case SizeEnum.Big:
                            AllBigHerbivores.Add(GetLast(AllHerbivores));
                            RemoveLast(AllHerbivores);
                            break;
                        case SizeEnum.Medium:
                            AllMediumHerbivores.Add(GetLast(AllHerbivores));
                            RemoveLast(AllHerbivores);
                            break;
                        case SizeEnum.Small:
                            AllSmallHerbivores.Add(GetLast(AllHerbivores));
                            RemoveLast(AllHerbivores);
                            break;
                    }
                }
            }
        }
        public void DistributeHerbivores(Train train)
        {
            while (ThereAreHerbivoresLeft())
            {
                new Wagon(train);

                Phase1_DistributeBigHerbivoresWithMediumCarnivores(train);
                Phase2_DistributePer3MediumHerbivores(train);
                Phase3_DistributeBigHerbivoresAndMediumHerbivoresWithSmallCarnivores(train);
                Phase4_DistributeRemainingBigHerbivoresAndMediumHerbivores(train);
                Phase5_DistributeSmallHerbivores(train);

                if (!train.WagonList.Last().ContainsAnimal())
                {
                    train.WagonList.RemoveAt(train.WagonList.Count - 1);
                }
            }
        } // figure out of dat breakout while if bla bla allemaal wel moet
        public void Phase1_DistributeBigHerbivoresWithMediumCarnivores(Train train)
        {
            foreach (Wagon wagon in train.WagonList)
            {
                if (ContainsAnimal(AllBigHerbivores))
                {
                    if (wagon.ContainsAnimal(FoodTypeEnum.Carnivore, SizeEnum.Medium) && wagon.GetWagonAnimalValue() <= 5)
                    {
                        MoveHerbivoreToWagon(SizeEnum.Big, wagon);
                    }
                }
            }
        }
        public void Phase2_DistributePer3MediumHerbivores(Train train)
        {
            foreach (Wagon wagon in train.WagonList)
            {
                if (wagon.ContainsAnimal(FoodTypeEnum.Carnivore, SizeEnum.Small) && AllMediumHerbivores.Count >= 3 && wagon.GetWagonAnimalValue() == 1) // kan met een || er langs maar dan wordt de statement heel lang
                {
                    for (int i = 0; i < 3; i++)
                    {
                        MoveHerbivoreToWagon(SizeEnum.Medium, wagon);
                    }
                }
                else if (!wagon.ContainsAnimal() && AllMediumHerbivores.Count >= 3)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        MoveHerbivoreToWagon(SizeEnum.Medium, wagon);
                    }
                }
                if (AllMediumHerbivores.Count <= 3)
                {
                    break;
                }
            }
        }
        public void Phase3_DistributeBigHerbivoresAndMediumHerbivoresWithSmallCarnivores(Train train)
        {
            if (ContainsAnimal(AllBigHerbivores) || ContainsAnimal(AllMediumHerbivores))
            {
                bool brokeOut = false;
                bool phase3 = true;
                while (phase3)
                {
                    foreach (Wagon wagon in train.WagonList)
                    {
                        if (wagon.ContainsAnimal(FoodTypeEnum.Carnivore, SizeEnum.Small))
                        {
                            // Nog Big H. && Nog Med H. && wagonValue == 1
                            if (ContainsAnimal(AllBigHerbivores) && ContainsAnimal(AllMediumHerbivores) && wagon.GetWagonAnimalValue() == 1)
                            {
                                MoveHerbivoreToWagon(SizeEnum.Big, wagon);
                                MoveHerbivoreToWagon(SizeEnum.Medium, wagon);
                                brokeOut = true;
                                break;
                            }
                            // Nog Big H. && wagonValue == 1
                            else if (ContainsAnimal(AllBigHerbivores) && wagon.GetWagonAnimalValue() == 1)
                            {
                                MoveHerbivoreToWagon(SizeEnum.Big, wagon);
                                brokeOut = true;
                                break;
                            }
                            // Nog Med H. && wagonValue == 7
                            else if (ContainsAnimal(AllMediumHerbivores) && wagon.GetWagonAnimalValue() <= 7)
                            {
                                MoveHerbivoreToWagon(SizeEnum.Medium, wagon);
                                brokeOut = true;
                                break;
                            }
                        }

                    }
                    if (brokeOut == false)
                    {
                        phase3 = false;
                    }
                    brokeOut = false;
                }
            }
        }
        public void Phase4_DistributeRemainingBigHerbivoresAndMediumHerbivores(Train train)
        {
            if (ContainsAnimal(AllBigHerbivores) || ContainsAnimal(AllMediumHerbivores))
            {
                bool phase4 = true;
                bool brokeout = false;
                while (phase4)
                {
                    foreach (Wagon wagon in train.WagonList)
                    {
                        if (ContainsAnimal(AllBigHerbivores))
                        {
                            if (wagon.ContainsAnimal(FoodTypeEnum.Herbivore) && !wagon.ContainsAnimal(FoodTypeEnum.Carnivore) && wagon.GetWagonAnimalValue() <= 5)
                            {
                                MoveHerbivoreToWagon(SizeEnum.Big, wagon);
                                brokeout = true;
                                break;
                            }
                            else if (!wagon.ContainsAnimal())
                            {
                                MoveHerbivoreToWagon(SizeEnum.Big, wagon);
                                brokeout = true;
                                break;
                            }
                        }
                        if (ContainsAnimal(AllMediumHerbivores))
                        {
                            if (wagon.ContainsAnimal(FoodTypeEnum.Herbivore) && !wagon.ContainsAnimal(FoodTypeEnum.Carnivore) && wagon.GetWagonAnimalValue() <= 7)
                            {
                                MoveHerbivoreToWagon(SizeEnum.Medium, wagon);
                                brokeout = true;
                                break;
                            }
                            if (!wagon.ContainsAnimal())
                            {
                                MoveHerbivoreToWagon(SizeEnum.Medium, wagon);
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
        public void Phase5_DistributeSmallHerbivores(Train train)
        {
            bool phase5 = true;
            bool brokeout = false;
            while (phase5)
            {
                foreach (Wagon wagon in train.WagonList)
                {
                    if (ContainsAnimal(AllSmallHerbivores))
                    {
                        if (!wagon.ContainsAnimal(FoodTypeEnum.Carnivore) && wagon.GetWagonAnimalValue() <= 9)
                        {
                            MoveHerbivoreToWagon(SizeEnum.Small, wagon);
                            brokeout = true;
                            break;
                        }
                    }
                    else
                    {
                        phase5 = false;
                    }
                }
                if (brokeout == false)
                {
                    phase5 = false;
                }
                brokeout = false;
            }

        }

        // Methods - Small
        public bool ThereAreHerbivoresLeft()
        {
            return AllBigHerbivores.Count > 0 || AllMediumHerbivores.Count > 0 || AllSmallHerbivores.Count > 0;
        }
        public bool ContainsAnimal(List<Animal> animalList)
        {
            return animalList.Count > 0;
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

        // Methods - !
        public void MoveHerbivoreToWagon(SizeEnum size, Wagon wagon)
        {
            switch (size)
            {
                case SizeEnum.Big:
                    wagon.AddAnimal(GetLast(AllBigHerbivores));
                    RemoveLast(AllBigHerbivores);
                    break;
                case SizeEnum.Medium:
                    wagon.AddAnimal(GetLast(AllMediumHerbivores));
                    RemoveLast(AllMediumHerbivores);
                    break;
                case SizeEnum.Small:
                    wagon.AddAnimal(GetLast(allSmallHerbivores));
                    RemoveLast(allSmallHerbivores);
                    break;
            }
        } // Remove switch with 3 seperate herbivore classes & inheritance

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
