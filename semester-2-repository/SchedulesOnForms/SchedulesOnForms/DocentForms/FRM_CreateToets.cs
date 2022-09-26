using SchedulesOnForms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulesOnForms.DocentForms
{
    public partial class FRM_CreateToets : Form
    {
        // Constructor
        public FRM_CreateToets()
        {
            InitializeComponent();
        }

        // Fields
        ToetsCollection toetsCollection = new ToetsCollection();

        // Events
        private void FRM_CreateToets_Load(object sender, EventArgs e)
        {
            CB_Schoolvak.Items.Add(Schoolvakken.Wiskunde);
            CB_Schoolvak.Items.Add(Schoolvakken.Natuurkunde);
            CB_Schoolvak.Items.Add(Schoolvakken.Scheikunde);
            CB_Schoolvak.Items.Add(Schoolvakken.Nederlands);
            CB_Schoolvak.Items.Add(Schoolvakken.Engels);

            foreach (Toets toets in toetsCollection.AlleToetsen)
            {
                LB_Toetsen.Items.Add(toets.Schoolvak + " - " + toets.Name);
            }
        }

        private void CB_Schoolvak_SelectedIndexChanged(object sender, EventArgs e)
        {
            GB_Weging.Enabled = true;
        }

        private void NUD_Weging_ValueChanged(object sender, EventArgs e)
        {
            if (NUD_Weging.Value != 0)
            {
                GB_Naam.Enabled = true;
            }
            else
            {
                GB_Naam.Enabled = false;
                BTN_Create.Enabled = false;
            }
        }

        private void TB_ToetsNaam_TextChanged(object sender, EventArgs e)
        {
            if (TB_ToetsNaam.TextLength > 0)
            {
                BTN_Create.Enabled = true;
            }
            else
            {
                BTN_Create.Enabled = false;
            }
        }

        private void BTN_Create_Click(object sender, EventArgs e)
        {
            Toets toets = new Toets(Convert.ToInt32(NUD_Weging.Value), TB_ToetsNaam.Text, CB_Schoolvak.SelectedItem.ToString());
            LB_Toetsen.Items.Add(toets.Schoolvak + " - " + toets.Name);

            MessageBox.Show(TB_ToetsNaam.Text + " gecreërd");
            TB_ToetsNaam.Text = "";
            NUD_Weging.Value = 0;

        }
    }
}
