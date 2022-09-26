using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrawlhallaBot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_Start_Click(object sender, EventArgs e)
        {
            TMR_Input.Enabled = true;
        }

        private void BTN_Stop_Click(object sender, EventArgs e)
        {
            TMR_Input.Enabled = false;
        }

        private void TMR_Input_Tick(object sender, EventArgs e)
        {
            string input = TB_Input.Text;
            SendKeys.Send(input);
        }
    }
}
