using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReverseHangmanForms
{
    public partial class FRM_Rules : Form
    {
        public FRM_Rules(Form FRM_Menu)
        {
            InitializeComponent();
            this.FRM_Menu = FRM_Menu;
        }

        // Properties
        public Form FRM_Menu;

        private void FRM_Rules_FormClosed(object sender, FormClosedEventArgs e)
        {
            FRM_Menu.Show();
        }
    }
}
