using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformsStaticLogin.DAL;
using WinformsStaticLogin.Models;

namespace WinformsStaticLogin
{
    public partial class FRM_Reservation : Form
    {
        public FRM_Reservation(User user)
        {
            InitializeComponent();
            User = user;
        }

        Database dB = new Database();

        public User User { get; }

        private void FRM_Reservation_Load(object sender, EventArgs e)
        {
            LBL_User.Text = User.Username; 
        }
    }
}
