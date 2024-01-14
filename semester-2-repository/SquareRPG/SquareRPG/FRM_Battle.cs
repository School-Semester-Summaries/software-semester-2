using Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SquareRPG
{
    public partial class FRM_Battle : Form
    {
        // Fields
        readonly Form _frmMap;
        readonly Player _player;
        readonly Enemy _enemy;
        int _count = 0;

        // Methods
        public FRM_Battle(Form frmMap, Player player, Enemy enemy)
        {
            _frmMap = frmMap;
            _player = player;
            _enemy = enemy;

            InitializeComponent();
        }

        void PlayerAttack()
        {
            // Logic
            int damage = _player.AttackPower;
            _enemy.LoseHealth(damage);
            // View
            LBL_EnemyAction.Text = "-" + damage;
            LBL_EnemyAction.Visible = true;
            LBL_PlayerAction.Visible = false;
            LBL_EventTracker.Text = "Player used Attack";
            LBL_EnemyHealth.Text = "Health " + _enemy.Health.ToString();
            GB_Moveset.Enabled = false;
            if (_enemy.Health <= 0)
            {
                this.Close();
                _frmMap.Show();
            }
        }

        void EnemyAttack()
        {
            // Logic
            int damage = _enemy.AttackPower;
            _player.LoseHealth(_enemy.AttackPower);
            // View
            LBL_PlayerAction.Text = "-" + damage;
            LBL_PlayerAction.Visible = true;
            LBL_EnemyAction.Visible = false;
            LBL_EventTracker.Text = "Enemy used Attack";
            LBL_PlayerHealth.Text = "Health " + _player.Health.ToString();
            GB_Moveset.Enabled = true;
            if (_player.Health <= 0)
            {
                this.Close();
                new FRM_GameOver().Show();
            }
        }

        // Events
        private void FRM_Battle_Load(object sender, EventArgs e)
        {
            LBL_PlayerHealth.Text = "Health " + _player.Health.ToString();
            LBL_EnemyHealth.Text = "Health " + _enemy.Health.ToString();
            LBL_EventTracker.Text = "";
        }

        private void BTN_Attack_Click(object sender, EventArgs e)
        {
            PlayerAttack();
            TMR_EnemyDelay.Start();
        }

        private void TMR_EnemyDelay_Tick(object sender, EventArgs e)
        {
            if (_count == 100)
            {
                EnemyAttack();
                _count = 0;
                TMR_EnemyDelay.Stop();
            }
            else
            {
                _count++;
            }
        }

        private void FRM_Battle_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
