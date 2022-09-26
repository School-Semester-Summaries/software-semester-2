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
    public partial class FRM_Home : Form
    {
        // Constructors
        public FRM_Home(Account account)
        {
            this.account = account;
            InitializeComponent();
        }

        // Fields
        Account account;

        // Events
        private void FRM_Home_Load(object sender, EventArgs e)
        {
            this.Text = "Logged in as " + account.Username;
        }

        private void BTN_CreateToets_Click(object sender, EventArgs e)
        {
            FRM_CreateToets frm_CreateToets = new FRM_CreateToets();
            frm_CreateToets.Show();
        }

        private void BTN_CheckCijfers_Click(object sender, EventArgs e)
        {
            FRM_CheckCijfers frm_CheckCijfers = new FRM_CheckCijfers(account);
            frm_CheckCijfers.Show();
        }

        private void BTN_CijfersInvoeren_Click(object sender, EventArgs e)
        {
            FRM_CijfersInvoeren frm_CijfersInvoeren = new FRM_CijfersInvoeren(account);
            frm_CijfersInvoeren.Show();
        }
    }
}
