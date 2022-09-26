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
    public partial class FRM_CijfersInvoeren : Form
    {
        public FRM_CijfersInvoeren(Account account)
        {
            InitializeComponent();
            this.account = account;
        }

        // Fields
        Account account;
        ToetsCollection toetsCollection = new ToetsCollection();
        static AccountCollection accountCollection = new AccountCollection();
        static List<NumericUpDown> nudList = new List<NumericUpDown>();

        // Methods
        public void SpawnTextboxes()
        {
            int y = 90;

            foreach (Account student in accountCollection.StudentList)
            {
                TextBox TB_Student = new TextBox();
                TB_Student.Size = new Size(150, 24);
                TB_Student.Location = new Point(12, y);
                TB_Student.ReadOnly = true;
                TB_Student.Text = student.Username;
                Controls.Add(TB_Student);

                NumericUpDown NUD_Mark = new NumericUpDown();
                NUD_Mark.Size = new Size(40, 24);
                NUD_Mark.Location = new Point(162, y);
                NUD_Mark.Increment = 0.1M;
                NUD_Mark.Maximum = 10;
                NUD_Mark.Minimum = 1;
                NUD_Mark.DecimalPlaces = 1;
                Controls.Add(NUD_Mark);
                nudList.Add(NUD_Mark);

                y += 24;
            }
        }

        // Events
        private void FRM_CijfersInvoeren_Load(object sender, EventArgs e)
        {
            foreach (Toets toets in toetsCollection.AlleToetsen)
            {
                CB_Toets.Items.Add(toets.Schoolvak + " - " + toets.Name);
            }
        }

        private void BTN_Confirm_Click(object sender, EventArgs e)
        {
            if (CB_Toets.SelectedIndex != -1)
            {
                GB_Schoolvak.Enabled = false;
                SpawnTextboxes();
                BTN_CijfersOpslaan.Enabled = true;
            }
        }

        private void BTN_CijfersOpslaan_Click(object sender, EventArgs e)
        {
            int nToets = CB_Toets.SelectedIndex;
            for (int i = 0; i < accountCollection.StudentList.Count; i++)
            {
                accountCollection.StudentList[i].AddCijfer(nToets, nudList[i].Value);
            }
        }
    }
}
