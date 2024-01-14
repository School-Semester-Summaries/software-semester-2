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

namespace FormsAdventure
{
    public partial class FRM_Puzzle1 : Form
    {
        public FRM_Puzzle1()
        {
            InitializeComponent();
            UpdateLocation();
            TB_Player.Visible = false;
            PB_Player.Visible = false;
        }
        Player player = new Player();

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            PlayerMovement(keyData);
            UpdateLocation();
            Interactions();
            UpdateForm();
            return base.ProcessCmdKey(ref msg, keyData);
        }

        void UpdateLocation()
        {
            BTN_Player.Location = new Point(player.XLocation, player.YLocation);
            TB_Player.Location = new Point(player.XLocation, player.YLocation);
            PB_Player.Location = new Point(player.XLocation, player.YLocation);
        }

        private void BTN_Player_Click(object sender, EventArgs e)
        {
            if (CheckCollisions(BTN_Player, LBL_BTN_Click))
            {
                LBL_BTN_Click.Location = new Point(-200, -200);
                Controls.Remove(LBL_BTN_Click);
            }
            else
            {
                MessageBox.Show("Not yet!");
            }
        }

        void UpdateForm()
        {
            switch (player.Form)
            {
                case Forms.Button:
                    Activate(BTN_Player);
                    Deactivate(TB_Player);
                    Deactivate(PB_Player);
                    break;
                case Forms.Textbox:
                    Activate(TB_Player);
                    Deactivate(BTN_Player);
                    Deactivate(PB_Player);
                    break;
                case Forms.PictureBox:
                    Activate(PB_Player);
                    Deactivate(BTN_Player);
                    Deactivate(TB_Player);
                    break;
            }

        }

        void Activate(Control control)
        {
            control.Visible = true;
            control.Enabled = true;
        }
        void Deactivate(Control control)
        {
            control.Visible = false;
            control.Enabled = false;
        }

        void PlayerMovement(Keys keyData)
        {
            if (keyData == Keys.Up)
            {
                player.MoveUp();
            }
            if (keyData == Keys.Right)
            {
                player.MoveRight();
            }
            if (keyData == Keys.Down)
            {
                player.MoveDown();
            }
            if (keyData == Keys.Left)
            {
                player.MoveLeft();
            }
            if (keyData == Keys.Space)
            {
                UpdateForm();
            }
        }

        void Interactions()
        {
            ButtonInteractions();
            TextBoxInteractions();
            PictureBoxInteractions();
        }

        void ButtonInteractions()
        {
            if (BTN_Player.Visible)
            {
                if (CheckCollisions(BTN_Player, LBL_Textbox))
                {
                    player.TransformIntoTextbox();
                }
                if (CheckCollisions(BTN_Player, LBL_PictureBox))
                {
                    player.TransformIntoPictureBox();
                }
                if (CheckCollisions(BTN_Player, PB_PictureBox))
                {
                    MessageBox.Show("Cannot implicitly convert type 'System.Windows.Forms.PictureBox' to 'System.Windows.Forms.Button'");
                }
            }
        }
        void TextBoxInteractions()
        {
            if (TB_Player.Visible)
            {
                if (CheckCollisions(TB_Player, LBL_Button1) || CheckCollisions(TB_Player, LBL_Button2) || CheckCollisions(TB_Player, LBL_Button3) || CheckCollisions(TB_Player, LBL_BTN_Click))
                {
                    player.TransformIntoButton();
                }
                if (CheckCollisions(TB_Player, LBL_PictureBox))
                {
                    player.TransformIntoPictureBox();
                }
                if (CheckCollisions(TB_Player, PB_PictureBox))
                {
                    MessageBox.Show("Cannot implicitly convert type 'System.Windows.Forms.PictureBox' to 'System.Windows.Forms.TextBox'");
                }
            }
        }
        void PictureBoxInteractions()
        {
            if (PB_Player.Visible)
            {
                if (CheckCollisions(PB_Player, LBL_Button1) || CheckCollisions(PB_Player, LBL_Button2) || CheckCollisions(PB_Player, LBL_Button3) || CheckCollisions(PB_Player, LBL_BTN_Click))
                {
                    player.TransformIntoButton();
                }
                if (CheckCollisions(PB_Player, LBL_Textbox))
                {
                    player.TransformIntoTextbox();
                }
                if (CheckCollisions(PB_Player, PB_PictureBox))
                {
                    PB_Player.Image = Properties.Resources.PictureBox2;
                    player.FillImage();
                }
                if (CheckCollisions(PB_Player, PB_PutImageHere) && player.ImageFilled)
                {
                    PB_PutImageHere.Image = PB_Player.Image;
                    MessageBox.Show("Type 'press' in TextBox to press your button");
                    this.Close();
                }
            }
        }

        void TransformIntoTextbox()
        {
            foreach (Control control in Controls)
            {
                if (CheckCollisions(player.Hitbox, control))
                {
                    MessageBox.Show(control.Name);
                }
            }
        }


        bool CheckCollisions(Control Form_One, Control Form_Two)
        {
            return (Form_One.Bounds.IntersectsWith(Form_Two.Bounds));
        }


        private void TB_Player_TextChanged(object sender, EventArgs e)
        {
            if (TB_Player.Text == "help")
            {
                MessageBox.Show("no");
                TB_Player.Text = "";
            }
        }
    }
}

// doel: zorg ervoor dat ik iets in de form kan slepen, en dat het dan gerecognized wordt als object (muur)
// all kinds of interaction:
// transform
// wall
// if (control.name.contains LBL_Button)
// { transformintobutton(); }