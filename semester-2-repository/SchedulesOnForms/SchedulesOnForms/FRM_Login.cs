using SchedulesOnForms.DocentForms;
using SchedulesOnForms.LeerlingForms;
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

namespace SchedulesOnForms
{
    public partial class FRM_Login : Form
    {
        // Constructor
        public FRM_Login()
        {
            InitializeComponent();
            CreateAccounts();
        }

        // Fields
        AccountCollection accountCollection = new AccountCollection();

        // Methods
        public void CreateAccounts()
        {
            Account account1 = new Account("d", "d", Roles.Docent);
            Account account2 = new Account("l", "l", Roles.Leerling);
            Account account3 = new Account("Wouter Verschuren", "wv", Roles.Leerling);
            Account account4 = new Account("Furkan Unal", "fv", Roles.Leerling);
        }

        // Events
        private void BTN_Login_Click(object sender, EventArgs e)
        {
            foreach (Account account in accountCollection.AccountList)
            {
                if(TB_Username.Text == account.Username && TB_Password.Text == account.Password)
                {
                    if (account.Role == Roles.Leerling)
                    {
                        LeerlingForms.FRM_Home frm_home = new LeerlingForms.FRM_Home(account);
                        frm_home.Show();
                    }
                    if (account.Role == Roles.Docent)
                    {
                        DocentForms.FRM_Home frm_home = new DocentForms.FRM_Home(account);
                        frm_home.Show();
                    }
                }
            }
        }
    }
}
