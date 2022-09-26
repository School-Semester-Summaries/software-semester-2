using Logic;
using Logic.NeoFighters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace BattleSim_v3._0
{
    public partial class FRM_ChooseNeoFighter : Form
    {
        public FRM_ChooseNeoFighter(Form frm_titleScreen)
        {
            InitializeComponent();
            FRM_TitleScreen = frm_titleScreen;
        }

        public Form FRM_TitleScreen{ get; set; }

        private void FRM_Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            FRM_TitleScreen.Show();
        }

        private void BTN_Start_Click(object sender, EventArgs e)
        {
            Player player1 = new Player();
            SetNeoFighterPlayer(player1, RB_Player1_Korbat, RB_Player1_Grarrl, RB_Player1_Blumaroo);
            Player player2 = new Player();
            SetNeoFighterPlayer(player2, RB_Player2_Korbat, RB_Player2_Grarrl, RB_Player2_Blumaroo);
            this.Hide();
            new FRM_Battle(player1, player2).Show();
        }

        void SetNeoFighterPlayer(Player player, RadioButton RB_Player_Korbat, RadioButton RB_Player_Grarrl, RadioButton RB_Player_Blumaroo) // Radio button list
        {
            if (RB_Player_Korbat.Checked)
            {
                player.SetNeoFighter(new Korbat());
            }
            else if (RB_Player_Grarrl.Checked)
            {
                player.SetNeoFighter(new Grarrl());
            }
            else if (RB_Player_Blumaroo.Checked)
            {
                player.SetNeoFighter(new Blumaroo());
            }
        }
    }
}
