using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;

// to do
// clean up code
// code solid and oop
// keep track of misses late's and early's
// dont load everything at the same time try to split at some point
// maybe find an other way to move pbs down, foreachloops slowing down program too much

namespace FridayNightFruitSalade
{
    public partial class Ellare : Form
    {
        // Constants
        const int ShiftSpeedLabel = 1;
        const int DeadLine = -99;
        const int ShiftSpeedArrow = 14;
        const int StartLine = 0;

        // Fields
        int score = 0;
        int _arrowPlaceCounter = 0;
        string txtFile = "//Pattern" + Environment.NewLine;
        ArrowCollection _arrowCollection;
        LabelCollection _labelCollection;
        SoundPlayer _sP = new SoundPlayer(Properties.Resources.Ellare);

        // Methods
        public Ellare()
        {
            InitializeComponent();
            _arrowCollection = new ArrowCollection();
            _labelCollection = new LabelCollection();
            PB_LeftArrow.Size = new Size(75, 75);
            PB_UpArrow.Size = new Size(75, 75);
            PB_DownArrow.Size = new Size(75, 75);
            PB_RightArrow.Size = new Size(75, 75);
            AssembleAllArrows();
            CollectAllArrows();
            CollectAllLabels();
            _arrowCollection.SortAllLists();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Left || keyData == Keys.D)
            {
                if (_arrowCollection.SortedLeftArrowList.Count > 0 && CheckCollision(PB_LeftArrow, _arrowCollection.SortedLeftArrowList[0]))
                {
                    CalculateScoreAndShow(PB_LeftArrow.Location.Y, _arrowCollection.SortedLeftArrowList[0].Location.Y, LBL_Left);
                    RemoveFirstValue(_arrowCollection.SortedLeftArrowList);
                }
                txtFile += "LeftArrowAssemble(" + _arrowPlaceCounter + ");" + Environment.NewLine;
            }

            if (keyData == Keys.Up || keyData == Keys.F)
            {
                if (_arrowCollection.SortedUpArrowList.Count > 0 && CheckCollision(PB_UpArrow, _arrowCollection.SortedUpArrowList[0]))
                {
                    CalculateScoreAndShow(PB_UpArrow.Location.Y, _arrowCollection.SortedUpArrowList[0].Location.Y, LBL_Up);
                    RemoveFirstValue(_arrowCollection.SortedUpArrowList);
                }
                txtFile += "UpArrowAssemble(" + _arrowPlaceCounter + ");" + Environment.NewLine;
            }

            if (keyData == Keys.Down || keyData == Keys.J)
            {
                if (_arrowCollection.SortedDownArrowList.Count > 0 && CheckCollision(PB_DownArrow, _arrowCollection.SortedDownArrowList[0]))
                {
                    CalculateScoreAndShow(PB_DownArrow.Location.Y, _arrowCollection.SortedDownArrowList[0].Location.Y, LBL_Down);
                    RemoveFirstValue(_arrowCollection.SortedDownArrowList);
                }
                txtFile += "DownArrowAssemble(" + _arrowPlaceCounter + ");" + Environment.NewLine;
            }

            if (keyData == Keys.Right || keyData == Keys.K)
            {
                if (_arrowCollection.SortedRightArrowList.Count > 0 && CheckCollision(PB_RightArrow, _arrowCollection.SortedRightArrowList[0]))
                {
                    CalculateScoreAndShow(PB_RightArrow.Location.Y, _arrowCollection.SortedRightArrowList[0].Location.Y, LBL_Right);
                    RemoveFirstValue(_arrowCollection.SortedRightArrowList);
                }
                txtFile += "RightArrowAssemble(" + _arrowPlaceCounter + ");" + Environment.NewLine;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        void CalculateScoreAndShow(int baseArrow, int movingArrow, Label label)
        {
            int distance = baseArrow - movingArrow;

            label.Location = new Point(label.Location.X, 37);
            if (distance <= 18 && distance >= -70)
            {
                label.Text = "Perfect";
                label.BackColor = Color.Purple;
                label.ForeColor = Color.Magenta;
                label.Visible = Enabled;
                score += 3;
            }
            if (distance <= 25 && distance >= -50)
            {
                label.Text = "Great";
                label.BackColor = Color.DarkGoldenrod;
                label.ForeColor = Color.LightGoldenrodYellow;
                label.Visible = Enabled;
                score+=2;
            }
            else if (distance >= 99)
            {
                label.Text = "Miss";
                label.BackColor = Color.DarkRed;
                label.ForeColor = Color.Red;
                label.Visible = Enabled;
                score--;
            }
            else if (distance > 25 || distance < -50)
            {
                label.Text = "Good";
                label.BackColor = Color.Green;
                label.ForeColor = Color.Cyan;
                label.Visible = Enabled;
                score++;
            }
        }

        void RemoveFirstValue(List<PictureBox> pictureBoxList)
        {
            Controls.Remove(pictureBoxList[0]);
            pictureBoxList.RemoveAt(0);
        }

        bool CheckCollision(PictureBox Ctrl_One, PictureBox Ctrl_Two)
        {
            return (Ctrl_One.Bounds.IntersectsWith(Ctrl_Two.Bounds));
        }

        private void CollectAllLabels()
        {
            foreach (Control ctrl in Controls)
            {
                if (ctrl.Name.Contains("LBL"))
                {
                    _labelCollection.LabelList.Add((Label)ctrl);
                }
            }
        }



        void CollectAllArrows()
        {
            CollectAllLeftArrows();
            CollectAllUpArrows();
            CollectAllDownArrows();
            CollectAllRightArrows();
        }

        void CollectAllLeftArrows()
        {
            foreach (Control ctrl in Controls)
            {
                if (ctrl.BackColor == Color.Green)
                {
                    _arrowCollection.UnsortedLeftArrowList.Add((PictureBox)ctrl);
                }
            }
        }

        void CollectAllUpArrows()
        {
            foreach (Control ctrl in Controls)
            {
                if (ctrl.BackColor == Color.Red)
                {
                    _arrowCollection.UnsortedUpArrowList.Add((PictureBox)ctrl);
                }
            }
        }

        void CollectAllDownArrows()
        {
            foreach (Control ctrl in Controls)
            {
                if (ctrl.BackColor == Color.Magenta)
                {
                    _arrowCollection.UnsortedDownArrowList.Add((PictureBox)ctrl);
                }
            }
        }

        void CollectAllRightArrows()
        {
            foreach (Control ctrl in Controls)
            {
                if (ctrl.BackColor == Color.Blue)
                {
                    _arrowCollection.UnsortedRightArrowList.Add((PictureBox)ctrl);
                }
            }
        }

        void AssembleAllArrows()
        {
            // delta y 106



            //Pattern
            LeftArrowAssemble(3177);
            UpArrowAssemble(3231);
            DownArrowAssemble(3330);
            RightArrowAssemble(3402);
            DownArrowAssemble(3474);
            UpArrowAssemble(3564);
            LeftArrowAssemble(3618);
            UpArrowAssemble(3717);
            DownArrowAssemble(3771);
            RightArrowAssemble(3843);
            DownArrowAssemble(3906);
            UpArrowAssemble(3978);
            DownArrowAssemble(4068);
            RightArrowAssemble(5085);
            DownArrowAssemble(5175);
            RightArrowAssemble(5256);
            DownArrowAssemble(5310);
            UpArrowAssemble(5391);
            LeftArrowAssemble(5472);
            UpArrowAssemble(5535);
            DownArrowAssemble(5625);
            RightArrowAssemble(5697);
            DownArrowAssemble(5778);
            UpArrowAssemble(5859);
            LeftArrowAssemble(5949);
            DownArrowAssemble(6003);
            LeftArrowAssemble(7065);
            UpArrowAssemble(7137);
            DownArrowAssemble(7227);
            RightArrowAssemble(7290);
            DownArrowAssemble(7362);
            UpArrowAssemble(7470);
            LeftArrowAssemble(7542);
            UpArrowAssemble(7623);
            DownArrowAssemble(7695);
            UpArrowAssemble(7794);
            DownArrowAssemble(7866);
            RightArrowAssemble(7938);
            DownArrowAssemble(8010);
            DownArrowAssemble(9018);
            RightArrowAssemble(9108);
            DownArrowAssemble(9180);
            UpArrowAssemble(9252);
            LeftArrowAssemble(9333);
            UpArrowAssemble(9423);
            DownArrowAssemble(9576);
            RightArrowAssemble(9648);
            DownArrowAssemble(9729);
            UpArrowAssemble(9819);
            LeftArrowAssemble(9864);
            DownArrowAssemble(9972);
            UpArrowAssemble(10035);
            DownArrowAssemble(10116);
            LeftArrowAssemble(11853);
            UpArrowAssemble(11925);
            DownArrowAssemble(12033);
            RightArrowAssemble(12105);
            DownArrowAssemble(12267);
            RightArrowAssemble(12330);
            DownArrowAssemble(12420);
            UpArrowAssemble(12501);
            LeftArrowAssemble(12555);
            UpArrowAssemble(12654);
            LeftArrowAssemble(12825);
            UpArrowAssemble(12825);
            DownArrowAssemble(12834);
            RightArrowAssemble(12834);
            DownArrowAssemble(13086);
            RightArrowAssemble(13185);
            DownArrowAssemble(13248);
            UpArrowAssemble(13320);
            LeftArrowAssemble(13392);
            UpArrowAssemble(13527);
            LeftArrowAssemble(13761);
            UpArrowAssemble(13761);
            DownArrowAssemble(13770);
            RightArrowAssemble(13770);
            RightArrowAssemble(14076);
            DownArrowAssemble(14148);
            UpArrowAssemble(14256);
            LeftArrowAssemble(14337);
            UpArrowAssemble(14427);
            DownArrowAssemble(14508);
            RightArrowAssemble(14571);
            DownArrowAssemble(14634);
            DownArrowAssemble(15030);
            UpArrowAssemble(15138);
            DownArrowAssemble(15255);
            RightArrowAssemble(15345);
            DownArrowAssemble(15417);
            UpArrowAssemble(15507);
            LeftArrowAssemble(15588);
            UpArrowAssemble(15660);
            DownArrowAssemble(15723);
            UpArrowAssemble(15849);
            DownArrowAssemble(15921);
            UpArrowAssemble(16020);
            DownArrowAssemble(16119);
            UpArrowAssemble(16290);
            DownArrowAssemble(16353);
            UpArrowAssemble(16461);
            LeftArrowAssemble(16569);
            RightArrowAssemble(16740);
            DownArrowAssemble(16803);
            DownArrowAssemble(16884);
            UpArrowAssemble(17109);
            DownArrowAssemble(17172);
            UpArrowAssemble(17280);
            DownArrowAssemble(17352);
            LeftArrowAssemble(17442);
            RightArrowAssemble(17559);
            DownArrowAssemble(17631);
            UpArrowAssemble(17703);
            DownArrowAssemble(17784);
            DownArrowAssemble(18054);
            UpArrowAssemble(18162);
            RightArrowAssemble(18297);
            DownArrowAssemble(18351);
            LeftArrowAssemble(18486);
            UpArrowAssemble(18567);
            DownArrowAssemble(18612);
            UpArrowAssemble(18684);
            DownArrowAssemble(18765);
            DownArrowAssemble(19008);
            LeftArrowAssemble(19143);
            UpArrowAssemble(19260);
            RightArrowAssemble(19350);
            DownArrowAssemble(19413);
            UpArrowAssemble(19521);
            LeftArrowAssemble(19782);
            DownArrowAssemble(19863);
            UpArrowAssemble(19944);
            RightArrowAssemble(20016);
            LeftArrowAssemble(20205);
            LeftArrowAssemble(20295);
            LeftArrowAssemble(20421);
            UpArrowAssemble(20556);
            LeftArrowAssemble(20646);
            UpArrowAssemble(20817);
            UpArrowAssemble(21033);
            //DownArrowAssemble(21195);
            //UpArrowAssemble(21285);
            //DownArrowAssemble(21357);
            //UpArrowAssemble(21537);
            //RightArrowAssemble(21672);
            //DownArrowAssemble(21762);
            //UpArrowAssemble(21852);
            //LeftArrowAssemble(21951);
            //LeftArrowAssemble(22221);
            //UpArrowAssemble(22311);
            //DownArrowAssemble(22383);
            //UpArrowAssemble(22464);
            //DownArrowAssemble(22545);
            //RightArrowAssemble(22707);
            //DownArrowAssemble(22797);
            //UpArrowAssemble(22905);
            //LeftArrowAssemble(22977);
            //LeftArrowAssemble(23193);
            //UpArrowAssemble(23283);
            //DownArrowAssemble(23373);
            //UpArrowAssemble(23454);
            //DownArrowAssemble(23544);
            //UpArrowAssemble(23643);
            //DownArrowAssemble(23769);
            //RightArrowAssemble(24021);
            //LeftArrowAssemble(24165);
            //DownArrowAssemble(24264);
            //UpArrowAssemble(24336);
            //RightArrowAssemble(24417);
            //DownArrowAssemble(24534);
            //LeftArrowAssemble(24642);
            //UpArrowAssemble(24723);
            //DownArrowAssemble(24777);
            //UpArrowAssemble(24867);
            //RightArrowAssemble(25002);
            //DownArrowAssemble(25146);
            //LeftArrowAssemble(25263);
            //RightArrowAssemble(25344);
            //UpArrowAssemble(25452);
            //DownArrowAssemble(25524);
            //UpArrowAssemble(25659);
            //RightArrowAssemble(25749);
            //DownArrowAssemble(25830);
            //LeftArrowAssemble(25920);
            //DownArrowAssemble(26010);
            //UpArrowAssemble(26163);
            //DownArrowAssemble(26253);
            //LeftArrowAssemble(26334);
            //DownArrowAssemble(26415);
            //UpArrowAssemble(26496);
            //RightArrowAssemble(26577);
            //DownArrowAssemble(26667);
            //UpArrowAssemble(26766);
            //DownArrowAssemble(26838);
            //UpArrowAssemble(26928);
            //RightArrowAssemble(27000);
            //DownArrowAssemble(27081);
            //LeftArrowAssemble(27180);
            //UpArrowAssemble(27279);
            //DownArrowAssemble(27369);
            //UpArrowAssemble(27450);
            //RightArrowAssemble(27549);
            //DownArrowAssemble(27594);
            //UpArrowAssemble(27711);
            //DownArrowAssemble(27783);
            //LeftArrowAssemble(27963);
            //RightArrowAssemble(28134);
            //UpArrowAssemble(28233);
            //DownArrowAssemble(28305);
            //UpArrowAssemble(28404);
            //RightArrowAssemble(28485);
            //DownArrowAssemble(28566);
            //LeftArrowAssemble(28683);
            //DownArrowAssemble(28782);
            //UpArrowAssemble(28881);
            //LeftArrowAssemble(29088);
            //RightArrowAssemble(29097);
            //RightArrowAssemble(29196);
            //LeftArrowAssemble(29205);
            //UpArrowAssemble(29421);
            //DownArrowAssemble(29430);
            //RightArrowAssemble(29592);
            //LeftArrowAssemble(29682);
            //DownArrowAssemble(29754);
            //UpArrowAssemble(29835);
            //RightArrowAssemble(29907);
            //DownArrowAssemble(29979);
        } // dont open this

        void LeftArrowAssemble(int yIndex)
        {
            PictureBox pb = new PictureBox();
            pb.Location = new Point(107, StartLine + yIndex);
            pb.BackColor = Color.Green;
            pb.Image = Properties.Resources.LeftArrow;
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Size = new Size(75, 75);
            Controls.Add(pb);
        }

        void UpArrowAssemble(int yIndex)
        {
            PictureBox pb = new PictureBox();
            pb.Location = new Point(205, StartLine + yIndex);
            pb.BackColor = Color.Red;
            pb.Image = Properties.Resources.UpArrow;
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Size = new Size(75, 75);
            Controls.Add(pb);
        }

        void DownArrowAssemble(int yIndex)
        {
            PictureBox pb = new PictureBox();
            pb.Location = new Point(302, StartLine + yIndex);
            pb.BackColor = Color.Magenta;
            pb.Image = Properties.Resources.DownArrow;
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Size = new Size(75, 75);
            Controls.Add(pb);
        }

        void RightArrowAssemble(int yIndex)
        {
            PictureBox pb = new PictureBox();
            pb.Location = new Point(400, StartLine + yIndex);
            pb.BackColor = Color.Blue;
            pb.Image = Properties.Resources.RightArrow;
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Size = new Size(75, 75);
            Controls.Add(pb);
        }

        // Events
        private void TMR_ShiftControls_Tick(object sender, EventArgs e)
        {
            // dit maakt alles zo sloom
            _arrowPlaceCounter += ShiftSpeedArrow;

            foreach (PictureBox pb in _arrowCollection.SortedLeftArrowList)
            {
                pb.Location = new Point(pb.Location.X, pb.Location.Y - ShiftSpeedArrow);
            }
            if (_arrowCollection.SortedLeftArrowList.Count > 0 && _arrowCollection.SortedLeftArrowList[0].Location.Y <= DeadLine)
            {
                CalculateScoreAndShow(PB_LeftArrow.Location.Y, _arrowCollection.SortedLeftArrowList[0].Location.Y, LBL_Left);
                RemoveFirstValue(_arrowCollection.SortedLeftArrowList);
            }

            foreach (PictureBox pb in _arrowCollection.SortedUpArrowList)
            {
                pb.Location = new Point(pb.Location.X, pb.Location.Y - ShiftSpeedArrow);
            }
            if (_arrowCollection.SortedUpArrowList.Count > 0 && _arrowCollection.SortedUpArrowList[0].Location.Y <= DeadLine)
            {
                CalculateScoreAndShow(PB_UpArrow.Location.Y, _arrowCollection.SortedUpArrowList[0].Location.Y, LBL_Up);
                RemoveFirstValue(_arrowCollection.SortedUpArrowList);
            }

            foreach (PictureBox pb in _arrowCollection.SortedDownArrowList)
            {
                pb.Location = new Point(pb.Location.X, pb.Location.Y - ShiftSpeedArrow);
            }
            if (_arrowCollection.SortedDownArrowList.Count > 0 && _arrowCollection.SortedDownArrowList[0].Location.Y <= DeadLine)
            {
                CalculateScoreAndShow(PB_DownArrow.Location.Y, _arrowCollection.SortedDownArrowList[0].Location.Y, LBL_Down);
                RemoveFirstValue(_arrowCollection.SortedDownArrowList);
            }

            foreach (PictureBox pb in _arrowCollection.SortedRightArrowList)
            {
                pb.Location = new Point(pb.Location.X, pb.Location.Y - ShiftSpeedArrow);
            }
            if (_arrowCollection.SortedRightArrowList.Count > 0 && _arrowCollection.SortedRightArrowList[0].Location.Y <= DeadLine)
            {
                CalculateScoreAndShow(PB_RightArrow.Location.Y, _arrowCollection.SortedRightArrowList[0].Location.Y, LBL_Right);
                RemoveFirstValue(_arrowCollection.SortedRightArrowList);
            }

            foreach (Label lbl in _labelCollection.LabelList)
            {
                lbl.Location = new Point(lbl.Location.X, lbl.Location.Y - ShiftSpeedLabel);
            }

            lblScore.Text = "Score: " + score.ToString();
        }

        private void TestLevel_FormClosed(object sender, FormClosedEventArgs e)
        {
            string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            sCurrentDirectory = sCurrentDirectory.Remove(sCurrentDirectory.Length - 10, 10);
            sCurrentDirectory += "Resources\\Pattern.txt";
            File.WriteAllText(sCurrentDirectory, txtFile);
        }

        private void TestLevel_Load(object sender, EventArgs e)
        {
            _sP.Play();
            TMR_ShiftPictureBoxes.Start();
        }
    }
}


//bugs notes dont die by themself
