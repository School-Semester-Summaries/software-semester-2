using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircusTrein
{
    public partial class FRM_CircusTrein : Form
    {
        // Constructors
        public FRM_CircusTrein()
        {
            InitializeComponent();
        }

        // Fields
        FoodTypeEnum foodTypeEnum;
        SizeEnum sizeEnum;
        AnimalCollection animalCollection = new AnimalCollection();
        HerbivoreCollection herbivoreCollection = new HerbivoreCollection();
        Train train = new Train();
        int bigHerbivoreMax = 5;
        int mediumHerbivoreMax = 7;
        int smallHerbivoreMax = 9;
        int startoverForLoop = -1;

        // Methods - Deze methods hebben direct iets te maken met de form
        public FoodTypeEnum DeclareFoodType()
        {
            if (RB_Carnivore.Checked)
            {
                foodTypeEnum = FoodTypeEnum.Carnivore;
            }
            else if (RB_Herbivore.Checked)
            {
                foodTypeEnum = FoodTypeEnum.Herbivore;
            }
            return foodTypeEnum;
        }
        public SizeEnum DeclareSize()
        {
            if (RB_Big.Checked)
            {
                sizeEnum = SizeEnum.Big;
            }
            else if (RB_Medium.Checked)
            {
                sizeEnum = SizeEnum.Medium;
            }
            else if (RB_Small.Checked)
            {
                sizeEnum = SizeEnum.Small;
            }
            return sizeEnum;
        }
        public void UpdateTextboxes()
        {
            TB_BigCarnivore.Text = animalCollection.CountSpecificAnimal(FoodTypeEnum.Carnivore, SizeEnum.Big).ToString();
            TB_MediumCarnivore.Text = animalCollection.CountSpecificAnimal(FoodTypeEnum.Carnivore, SizeEnum.Medium).ToString();
            TB_SmallCarnivore.Text = animalCollection.CountSpecificAnimal(FoodTypeEnum.Carnivore, SizeEnum.Small).ToString();
            TB_BigHerbivore.Text = animalCollection.CountSpecificAnimal(FoodTypeEnum.Herbivore, SizeEnum.Big).ToString();
            TB_MediumHerbivore.Text = animalCollection.CountSpecificAnimal(FoodTypeEnum.Herbivore, SizeEnum.Medium).ToString();
            TB_SmallHerbivore.Text = animalCollection.CountSpecificAnimal(FoodTypeEnum.Herbivore, SizeEnum.Small).ToString();
        }
        public void DisplayEverythingInListbox()
        {
            foreach (Wagon wagon in train.WagonList)
            {
                int nthWagon = 1;
                LB_Wagons.Items.Add("Wagon " + nthWagon + " - (Value: " + wagon.GetWagonAnimalValue() + ")");
                foreach (Animal animal in wagon.AnimalList)
                {
                    LB_Wagons.Items.Add(animal.Name);
                }
                LB_Wagons.Items.Add("");
                nthWagon++;
            }
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
        public void ClassifyBigHerbivores(int nthWagon)
        {
            if (WagonContainsAnimal(nthWagon, FoodTypeEnum.Carnivore, SizeEnum.Medium) && train.WagonList[nthWagon].GetWagonAnimalValue() <= bigHerbivoreMax)
            {
                MoveAnimalToWagon(nthWagon);
                nthWagon = startoverForLoop;
            }
            else if (WagonContainsAnimal(nthWagon, FoodTypeEnum.Herbivore, SizeEnum.Medium) && train.WagonList[nthWagon].GetWagonAnimalValue() <= bigHerbivoreMax)
            {
                MoveAnimalToWagon(nthWagon);
                nthWagon = startoverForLoop;
            }
            else if (WagonContainsAnimal(nthWagon, FoodTypeEnum.Herbivore, SizeEnum.Small) && train.WagonList[nthWagon].GetWagonAnimalValue() <= bigHerbivoreMax)
            {
                MoveAnimalToWagon(nthWagon);
                nthWagon = startoverForLoop;
            }
            // bij small carnivore? solution -> big herbivores bewaren voor het laatst, begin met medium dan small dan big?
            else if (!WagonContainsAnimal(nthWagon))
            {
                MoveAnimalToWagon(nthWagon);
                nthWagon = startoverForLoop;
            }
        }
        public void ClassifyMediumHerbivores(int nthWagon)
        {
            if (WagonContainsAnimal(nthWagon, FoodTypeEnum.Carnivore, SizeEnum.Small) && train.WagonList[nthWagon].GetWagonAnimalValue() <= mediumHerbivoreMax)
            {
                MoveAnimalToWagon(nthWagon);
                nthWagon = startoverForLoop;
            }
            else if (WagonContainsAnimal(nthWagon, FoodTypeEnum.Herbivore, SizeEnum.Medium) && train.WagonList[nthWagon].GetWagonAnimalValue() <= mediumHerbivoreMax)
            {
                MoveAnimalToWagon(nthWagon);
                nthWagon = startoverForLoop;
            }
            else if (WagonContainsAnimal(nthWagon, FoodTypeEnum.Herbivore, SizeEnum.Small) && train.WagonList[nthWagon].GetWagonAnimalValue() <= mediumHerbivoreMax)
            {
                MoveAnimalToWagon(nthWagon);
                nthWagon = startoverForLoop;
            }
            else if (WagonContainsAnimal(nthWagon, FoodTypeEnum.Herbivore, SizeEnum.Big) && !WagonContainsAnimal(nthWagon, FoodTypeEnum.Carnivore) && train.WagonList[nthWagon].GetWagonAnimalValue() <= mediumHerbivoreMax)
            {
                MoveAnimalToWagon(nthWagon);
                nthWagon = startoverForLoop;
            }
            else if (!WagonContainsAnimal(nthWagon))
            {
                MoveAnimalToWagon(nthWagon);
                nthWagon = startoverForLoop;
            }
        }
        public void ClassifySmallHerbivores(int nthWagon)
        {
            if (!WagonContainsAnimal(nthWagon, FoodTypeEnum.Carnivore) && train.WagonList[nthWagon].GetWagonAnimalValue() <= smallHerbivoreMax)
            {
                MoveAnimalToWagon(nthWagon);
                nthWagon = startoverForLoop;
            }
        }
        public void ClassifyHerbivores()
        {
            while (ThereAreHerbivoresLeft())
            {
                Wagon wagon = new Wagon();

                for (int nthWagon = 0; nthWagon < train.WagonList.Count(); nthWagon++) // foreach?
                {
                    if (ThereAreHerbivoresLeft())
                    {
                        switch (herbivoreCollection.GetLast().Size)
                        {
                            case SizeEnum.Big:
                                ClassifyBigHerbivores(nthWagon);
                                break;
                            case SizeEnum.Medium:
                                ClassifyMediumHerbivores(nthWagon);
                                break;
                            case SizeEnum.Small:
                                ClassifySmallHerbivores(nthWagon);
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

        public void MoveAnimalToWagon(int i)
        {
            train.WagonList[i].AddAnimal(herbivoreCollection.GetLast());
            herbivoreCollection.RemoveLast();
        }

        public bool ThereAreHerbivoresLeft()
        {
            return herbivoreCollection.ContainsAnimal(FoodTypeEnum.Herbivore);
        }
        public bool AllAnimalsConatins(FoodTypeEnum foodType)
        {
            return animalCollection.ContainsAnimal(foodType);
        }

        public bool WagonContainsAnimal(int nthWagon)
        {
            return train.WagonList[nthWagon].ContainsAnimal();
        }
        public bool WagonContainsAnimal(int wagonNumber, FoodTypeEnum foodType)
        {
            return train.WagonList[wagonNumber].ContainsAnimal(foodType);
        }
        public bool WagonContainsAnimal(int wagonNumber, FoodTypeEnum foodType, SizeEnum size)
        {
            return train.WagonList[wagonNumber].ContainsAnimal(foodType, size);
        }


        // Events
        private void BTN_AddAnimal_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < NUD_AnimalMultiplier.Value; i++)
            {
                Animal animal = new Animal(DeclareFoodType(), DeclareSize());
            }
            UpdateTextboxes();
        }
        private void BTN_ClassifyAnimals_Click(object sender, EventArgs e)
        {
            GB_AddAnimals.Enabled = false;
            ClassifyAllAnimals();
            DisplayEverythingInListbox();
        }
    }
}
