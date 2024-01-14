using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logic
{
    public enum Forms
    {
        Button,
        Textbox,
        PictureBox
    }
    public class Player
    {
        public Player()
        {
            Hitbox = new Label();
            Hitbox.Size = new Size();
        }

        int movementSpeed = 5;
        public int XLocation { get; set; }
        public int YLocation { get; set; }
        public Point Location { get { return new Point(XLocation, YLocation); } }
        public Forms Form { get; private set; }
        public bool ImageFilled { get; private set; }
        public Control Hitbox { get; set; }

        public void MoveUp()
        {
            if (!(YLocation <= Wall.Up))
            {
                YLocation -= movementSpeed;
            }
        }
        public void MoveRight()
        {
            if (!(XLocation >= Wall.Right))
            {
                XLocation += movementSpeed;
            }
        }
        public void MoveDown()
        {
            if (!(YLocation >= Wall.Down))
            {
                YLocation += movementSpeed;
            }
        }
        public void MoveLeft()
        {
            if (!(XLocation <= Wall.Left))
            {
                XLocation -= movementSpeed;
            }
        }

        public void TransformIntoButton()
        {
            Form = Forms.Button;
        }
        public void TransformIntoTextbox()
        {
            Form = Forms.Textbox;
        }
        public void TransformIntoPictureBox()
        {
            Form = Forms.PictureBox;
        }
        public void FillImage()
        {
            ImageFilled = true;
        }
    }
}
