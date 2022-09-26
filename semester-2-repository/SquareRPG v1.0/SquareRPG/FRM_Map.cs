using Logic;
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
    public partial class FRM_SquareRpg : Form
    {
        // Fields
        Player _player = new Player();
        EnemyCollection _enemyCollection = new EnemyCollection();

        // Methods
        public FRM_SquareRpg()
        {
            InitializeComponent();
            TMR_Game.Start();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            PlayerMovement(keyData);
            return base.ProcessCmdKey(ref msg, keyData);
        }

        void PlayerMovement(Keys keyData)
        {
            if (keyData == Keys.W)
            {
                _player.MoveUpPlus();
            }
            if (keyData == Keys.D)
            {
                _player.MoveRightPlus();
            }
            if (keyData == Keys.S)
            {
                _player.MoveDownPlus();
            }
            if (keyData == Keys.A)
            {
                _player.MoveLeftPlus();
            }
        }

        void UpdateLocations()
        {
            PB_Player.Location = new Point(_player.XLocation, _player.YLocation);
        }

        List<PictureBox> GetAllBlackPictureBoxes()
        {
            List<PictureBox> pictureBoxList = new List<PictureBox>();
            foreach (var @object in Controls)
            {
                Control control = (Control)@object;
                if (control.Name.Contains("pictureBox") && control.BackColor == Color.Black)
                {
                    pictureBoxList.Add((PictureBox)control);
                }
            }
            return pictureBoxList;
        }

        List<PictureBox> GetAllRedPictureBoxes()
        {
            List<PictureBox> pictureBoxList = new List<PictureBox>();
            foreach (var @object in Controls)
            {
                Control control = (Control)@object;
                if (control.Name.Contains("pictureBox") && control.BackColor == Color.Red)
                {
                    pictureBoxList.Add((PictureBox)control);
                }
            }
            return pictureBoxList;
        }

        bool CheckCollision(Control Ctrl_One, Control Ctrl_Two)
        {
            return (Ctrl_One.Bounds.IntersectsWith(Ctrl_Two.Bounds));
        }

        private void CheckEnemyCollision()
        {
            List<PictureBox> allRedPictureBoxes = GetAllRedPictureBoxes();
            for (int nEnemy = 0; nEnemy < allRedPictureBoxes.Count; nEnemy++)
            {
                if (CheckCollision(PB_Player, allRedPictureBoxes[nEnemy]))
                {
                    StartBattle(allRedPictureBoxes, nEnemy);
                }
            }
        }

        public void StartBattle(List<PictureBox> allRedPictureBoxes, int nEnemy)
        {
            FRM_Battle frmBattle = new FRM_Battle(this, _player, _enemyCollection.EnemyList[nEnemy]);
            this.Hide();
            _player.StopMoving();
            frmBattle.Show();
            _enemyCollection.EnemyList.Remove(_enemyCollection.EnemyList[nEnemy]);
            Controls.Remove(allRedPictureBoxes[nEnemy]);
        }

        // Events
        private void FRM_Map_Load(object sender, EventArgs e)
        {
            // Set size
            PB_Player.Size = new Size(Player.XSize, Player.YSize);

            // put all black picturebox in boundarieslist
            List<PictureBox> blackPictureBoxList = GetAllBlackPictureBoxes();
            foreach (PictureBox pictureBox in blackPictureBoxList)
            {
                Boundaries.AddBoundaries(pictureBox.Bounds.Top, pictureBox.Bounds.Right, pictureBox.Bounds.Bottom, pictureBox.Bounds.Left);
            }

            // put all Red Pictureboxes in enemylist
            List<PictureBox> redPictureBoxList = GetAllRedPictureBoxes();
            foreach (PictureBox pictureBox in redPictureBoxList)
            {
                _enemyCollection.AddEnemy(new Enemy(3, 1));
            }
        }

        private void TMR_Game_Tick(object sender, EventArgs e)
        {
            _player.MovementPlus();
            CheckEnemyCollision();
            UpdateLocations();
        }
    }
}
