using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SquareRPG
{
    public partial class FRM_GameOver : Form
    {
        // Methods
        public FRM_GameOver()
        {
            InitializeComponent();
        }

        // Events
        private void FRM_GameOver_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }
    }
}
