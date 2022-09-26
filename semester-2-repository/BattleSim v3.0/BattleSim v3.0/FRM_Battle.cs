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
    public partial class FRM_Battle : Form
    {
        public FRM_Battle(Player player1, Player player2)
        {
            InitializeComponent();
            Player1 = player1;
            Player2 = player2;
        }

        Random rnd = new Random();
        public Player Player1 { get; private set; }
        public Player Player2 { get; private set; }




        void LoadCorrectNeoFighterImage(PictureBox PB_Player_NeoFighter, Player player)
        {
            if (player.NeoFighter.Name == NeoFighterNames.Korbat)
            {
                PB_Player_NeoFighter.Image = Properties.Resources.Korbat;
            }
            else if (player.NeoFighter.Name == NeoFighterNames.Grarrl)
            {
                PB_Player_NeoFighter.Image = Properties.Resources.Grarrl;
            }
            else if (player.NeoFighter.Name == NeoFighterNames.Blumaroo)
            {
                PB_Player_NeoFighter.Image = Properties.Resources.Blumaroo;
            }
        } // not nice
        void MirrorImage(PictureBox PB_Player_NeoFighter)
        {
            PB_Player_NeoFighter.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            PB_Player_NeoFighter.Invalidate();
        }
        void SwitchTurn()
        {
            BTN_Player1_Attack.Enabled = !BTN_Player1_Attack.Enabled;
            BTN_Player2_Attack.Enabled = !BTN_Player2_Attack.Enabled;
        }
        void UpdateHealth()
        {
            LBL_Player1_Health.Text = Player1.NeoFighter.Health.ToString();
            LBL_Player2_Health.Text = Player2.NeoFighter.Health.ToString();
        }

        private void FRM_Battle_Load(object sender, EventArgs e)
        {
            LoadCorrectNeoFighterImage(PB_Player1_NeoFighter, Player1);
            LoadCorrectNeoFighterImage(PB_Player2_NeoFighter, Player2);
            MirrorImage(PB_Player2_NeoFighter);
            UpdateHealth();
        }
        private void BTN_Player1_Attack_Click(object sender, EventArgs e)
        {
            Player2.NeoFighter.LoseHealth(Player1.NeoFighter.Attack(rnd, Player1.NeoFighter.AttackPower)); // waarom mag ik korbat methods niet aanroepen
            UpdateHealth();
            SwitchTurn();
        }
        private void BTN_Player2_Attack_Click(object sender, EventArgs e)
        {
            Player1.NeoFighter.LoseHealth(Player2.NeoFighter.Attack(rnd, Player2.NeoFighter.AttackPower));
            UpdateHealth();
            SwitchTurn();
        }
    }
}
