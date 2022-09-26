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
    public partial class FRM_CheckCijfers : Form
    {
        // Constrcutors
        public FRM_CheckCijfers(Account account)
        {
            this.account = account;
            InitializeComponent();
        }

        // Fields
        AccountCollection accountCollection = new AccountCollection();
        Account account;
        Account student;

        // Methods
        public void ClearListboxes()
        {
            LB_Wiskunde.Items.Clear();
            LB_Natuurkunde.Items.Clear();
            LB_Scheikunde.Items.Clear();
            LB_Nederlands.Items.Clear();
            LB_Engels.Items.Clear();
        }

        // Events
        private void FRM_CheckCijfers_Load(object sender, EventArgs e)
        {
            foreach (Account account in accountCollection.AccountList)
            {
                if (account.Role == Roles.Leerling)
                {
                    CB_Leerlingen.Items.Add(account.Username);
                }
            }
        }

        private void CB_Leerlingen_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearListboxes();

            for (int i = 0; i < accountCollection.AccountList.Count; i++)
            {
                if (accountCollection.AccountList[i].Username == CB_Leerlingen.SelectedIndex.ToString())
                {
                    student = accountCollection.AccountList[i];
                }
            }

            LB_Wiskunde.Items.Add(Schoolvakken.Wiskunde);
            LB_Natuurkunde.Items.Add(Schoolvakken.Natuurkunde);
            LB_Scheikunde.Items.Add(Schoolvakken.Scheikunde);
            LB_Nederlands.Items.Add(Schoolvakken.Nederlands);
            LB_Engels.Items.Add(Schoolvakken.Engels);

            if (account.ToetsLijst != null)
            {
                student = accountCollection.StudentList[CB_Leerlingen.SelectedIndex];
                foreach (Toets toets in student.ToetsLijst)
                {
                    switch (toets.Schoolvak)
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

// army , golem wizard
// kazerne, wizard, 