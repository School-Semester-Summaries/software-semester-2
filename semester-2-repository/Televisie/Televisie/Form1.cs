using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Televisie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] zenders = new string[10];
        int nextFreeChannel = 0;
        bool AddStandaardZendersOnlyOnce = true;
        bool DisplayOnlyOnce = true;

        private void BTN_Aan_Click(object sender, EventArgs e)
        {
            LBL_TvState.Text = "Aan";
            AddStandardZenders();
            DisplayZenders();
            UpdateChannelLabel();
        }

        private void BTN_Uit_Click(object sender, EventArgs e)
        {
            LBL_TvState.Text = "Uit";
            DeleteZendersUitListbox();
            UpdateChannelLabel();
            DisplayOnlyOnce = true;
        }
        private void BTN_AddZenders_Click(object sender, EventArgs e)
        {
            if (nextFreeChannel == 10)
            {
                MessageBox.Show("Stop met kanalen toevoegen sukkeltje vdb");
                return;
            }
            zenders[nextFreeChannel] = TB_AddZender.Text;
            nextFreeChannel++;
            UpdateChannelLabel();
        }

        public void AddStandardZenders()
        {
            if (AddStandaardZendersOnlyOnce)
            {
                zenders[nextFreeChannel] = "NOS0";
                nextFreeChannel = nextFreeChannel + 1;
                zenders[nextFreeChannel] = "NOS1";
                nextFreeChannel = nextFreeChannel + 1;
                zenders[nextFreeChannel] = "NOS2";
                nextFreeChannel = nextFreeChannel + 1;
                AddStandaardZendersOnlyOnce = false;
            }
        }

        public void DisplayZenders()
        {
            if (DisplayOnlyOnce)
            {
                for (int i = 0; i < nextFreeChannel; i++)
                {
                    LB_Zenders.Items.Add(zenders[i]);
                }
                DisplayOnlyOnce = false;
            }
        }

        public void DeleteZendersUitListbox()
        {
            LB_Zenders.Items.Clear();
        }

        public void UpdateChannelLabel()
        {
            LBL_Channels.Text = "Channels: " + nextFreeChannel;
        }
    }
}
