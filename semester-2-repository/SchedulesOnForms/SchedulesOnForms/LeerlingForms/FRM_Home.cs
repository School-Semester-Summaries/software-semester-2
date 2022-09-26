using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchedulesOnForms.Models;

namespace SchedulesOnForms.LeerlingForms
{
    public partial class FRM_Home : Form
    {
        // Constrcutor
        public FRM_Home(Account account)
        {
            this.account = account;
            InitializeComponent();
        }

        // Field
        Account account;

        private void FRM_Home_Load(object sender, EventArgs e)
        {
            LB_Wiskunde.Items.Add(Schoolvakken.Wiskunde);
            LB_Natuurkunde.Items.Add(Schoolvakken.Natuurkunde);
            LB_Scheikunde.Items.Add(Schoolvakken.Scheikunde);
            LB_Nederlands.Items.Add(Schoolvakken.Nederlands);
            LB_Engels.Items.Add(Schoolvakken.Engels);
            if (account.ToetsLijst != null)
            {
                foreach (Toets toets in account.ToetsLijst)
                {
                    switch(toets.Schoolvak)
                    {
                        case Schoolvakken.Wiskunde:
                            LB_Wiskunde.Items.Add(toets.Cijfer);
                            break;
                        case Schoolvakken.Natuurkunde:
                            LB_Natuurkunde.Items.Add(toets.Cijfer);
                            break;
                        case Schoolvakken.Scheikunde:
                            LB_Scheikunde.Items.Add(toets.Cijfer);
                            break;
                        case Schoolvakken.Nederlands:
                            LB_Nederlands.Items.Add(toets.Cijfer);
                            break; 
                        case Schoolvakken.Engels:
                            LB_Engels.Items.Add(toets.Cijfer);
                            break;
                    }
                }
            }            
        }
    }
}
