using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircusTrein_BetterForEach
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
            int nthWagon = 1;
            foreach (Wagon wagon in train.WagonList)
            {
                LB_Wagons.Items.Add("Wagon " + nthWagon + " - (Value: " + wagon.GetWagonAnimalValue() + ")");
                foreach (Animal animal in wagon.AnimalList)
                {
                    LB_Wagons.Items.Add(animal.Name);
                }
                LB_Wagons.Items.Add("");
                nthWagon++;
            }
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
            train.ClassifyAllAnimals();
            DisplayEverythingInListbox();
        }
    }
}

// om perfect te maken, sorteer lijst op vleeseters, medium plant, small plant, big plant?