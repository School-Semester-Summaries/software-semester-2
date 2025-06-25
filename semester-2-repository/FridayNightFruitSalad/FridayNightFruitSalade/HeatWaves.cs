using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;

// to do
// clean up code // clean up code
// code solid and oop
// keep track of misses late's and early's
// dont load everything at the same time try to split at some point
// maybe find an other way to move pbs down, foreachloops slowing down program too much

namespace FridayNightFruitSalade
{
    public partial class HeatWaves : Form
    {
        // Constants
        const int ShiftSpeedLabel = 1;
        const int DeadLine = -99;
        const int ShiftSpeedArrow = 9;
        const int StartLine = -20;

        // Fields
        string txtFile = "//Pattern" + Environment.NewLine;
        int _score = 0;
        int _arrowPlaceCounter = 0;
        ArrowCollection _arrowCollection;
        LabelCollection _labelCollection;
        SoundPlayer _sP = new SoundPlayer(Properties.Resources.Glass_Animals___Heat_Waves__Official_Video_);

        // Methods
        public HeatWaves()
        {
            InitializeComponent();
            _arrowCollection = new ArrowCollection();
            _labelCollection = new LabelCollection();
            SetBaseArrowSize();
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
            if (distance <= 10 && distance >= -20)
            {
                label.Text = "Perfect";
                label.BackColor = Color.Purple;
                label.ForeColor = Color.Magenta;
                label.Visible = Enabled;
                _score += 3;
            }
            else if (distance <= 35 && distance >= -50)
            {
                label.Text = "Great";
                label.BackColor = Color.DarkGoldenrod;
                label.ForeColor = Color.LightGoldenrodYellow;
                label.Visible = Enabled;
                _score += 2;
            }
            else if (distance >= 99)
            {
                label.Text = "Miss";
                label.BackColor = Color.DarkRed;
                label.ForeColor = Color.Red;
                label.Visible = Enabled;
                _score--;
            }
            else if (distance > 35 || distance < -50)
            {
                label.Text = "Good";
                label.BackColor = Color.Green;
                label.ForeColor = Color.Cyan;
                label.Visible = Enabled;
                _score++;
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

        void SetBaseArrowSize()
        {
            PB_LeftArrow.Size = new Size(75, 75);
            PB_UpArrow.Size = new Size(75, 75);
            PB_DownArrow.Size = new Size(75, 75);
            PB_RightArrow.Size = new Size(75, 75);
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
            //Pattern
            //RightArrowAssemble(504);
            //DownArrowAssemble(585);
            //LeftArrowAssemble(1251);
            //UpArrowAssemble(1341);
            //UpArrowAssemble(2016);
            //DownArrowAssemble(2124);
            //RightArrowAssemble(2781);
            //LeftArrowAssemble(2898);
            //LeftArrowAssemble(3582);
            //UpArrowAssemble(3681);
            //DownArrowAssemble(4338);
            //RightArrowAssemble(4437);
            //DownArrowAssemble(4680);
            //UpArrowAssemble(4923);
            //UpArrowAssemble(5112);
            //LeftArrowAssemble(5337);
            //UpArrowAssemble(5580);
            //UpArrowAssemble(5976);
            //DownArrowAssemble(6183);
            //LeftArrowAssemble(6282);
            //DownArrowAssemble(6381);
            //UpArrowAssemble(6597);
            //RightArrowAssemble(6795);
            //DownArrowAssemble(6903);
            //LeftArrowAssemble(7434);
            //UpArrowAssemble(7677);
            //DownArrowAssemble(7776);
            //DownArrowAssemble(7992);
            //UpArrowAssemble(8307);
            //RightArrowAssemble(8487);
            //DownArrowAssemble(8604);
            //DownArrowAssemble(8793);
            //LeftArrowAssemble(8901);
            //DownArrowAssemble(9009);
            //UpArrowAssemble(9108);
            //RightArrowAssemble(9351);
            //DownArrowAssemble(9558);
            //DownArrowAssemble(9774);
            //UpArrowAssemble(9783);
            //RightArrowAssemble(9783);
            //LeftArrowAssemble(9783);
            //DownArrowAssemble(9990);
            //UpArrowAssemble(10206);
            //RightArrowAssemble(10305);
            //DownArrowAssemble(10521);
            //LeftArrowAssemble(10638);
            //DownArrowAssemble(10719);
            //UpArrowAssemble(10827);
            //DownArrowAssemble(11043);
            //DownArrowAssemble(11160);
            //DownArrowAssemble(11403);
            //UpArrowAssemble(11520);
            //RightArrowAssemble(11637);
            //DownArrowAssemble(11754);
            //LeftArrowAssemble(11889);
            //DownArrowAssemble(12006);
            //UpArrowAssemble(12258);
            //RightArrowAssemble(12366);
            //DownArrowAssemble(12456);
            //UpArrowAssemble(12591);
            //RightArrowAssemble(12672);
            //DownArrowAssemble(12789);
            //LeftArrowAssemble(12996);
            //RightArrowAssemble(13203);
            //LeftArrowAssemble(13212);
            //LeftArrowAssemble(13392);
            //RightArrowAssemble(13401);
            //DownArrowAssemble(13644);
            //UpArrowAssemble(13716);
            //RightArrowAssemble(13851);
            //DownArrowAssemble(13959);
            //LeftArrowAssemble(14067);
            //DownArrowAssemble(14076);
            //UpArrowAssemble(14265);
            //RightArrowAssemble(14265);
            //UpArrowAssemble(14472);
            //DownArrowAssemble(14481);
            //RightArrowAssemble(14697);
            //LeftArrowAssemble(14922);
            //DownArrowAssemble(15003);
            //UpArrowAssemble(15102);
            //RightArrowAssemble(15183);
            //DownArrowAssemble(15291);
            //LeftArrowAssemble(15426);
            //DownArrowAssemble(15516);
            //UpArrowAssemble(15606);
            //RightArrowAssemble(15723);
            //DownArrowAssemble(15831);
            //LeftArrowAssemble(15894);
            //UpArrowAssemble(16011);
            //DownArrowAssemble(16119);
            //RightArrowAssemble(16218);
            //LeftArrowAssemble(16425);
            //RightArrowAssemble(16425);
            //DownArrowAssemble(16632);
            //UpArrowAssemble(16641);
            //DownArrowAssemble(16830);
            //LeftArrowAssemble(16920);
            //RightArrowAssemble(17028);
            //DownArrowAssemble(17244);
            //UpArrowAssemble(17343);
            //RightArrowAssemble(17496);
            //DownArrowAssemble(17586);
            //LeftArrowAssemble(17712);
            //DownArrowAssemble(17784);
            //UpArrowAssemble(17892);
            //DownArrowAssemble(18108);
            //UpArrowAssemble(18315);
            //RightArrowAssemble(18576);
            //DownArrowAssemble(18666);
            //RightArrowAssemble(18765);
            //DownArrowAssemble(18963);
            //UpArrowAssemble(19197);
            //LeftArrowAssemble(19323);
            //UpArrowAssemble(19431);
            //DownArrowAssemble(19503);
            //UpArrowAssemble(19629);
            //RightArrowAssemble(19863);
            //DownArrowAssemble(19953);
            //UpArrowAssemble(20061);
            //LeftArrowAssemble(20277);
            //DownArrowAssemble(20475);
            //UpArrowAssemble(20664);
            //RightArrowAssemble(20898);
            //DownArrowAssemble(20988);
            //UpArrowAssemble(21096);
            //LeftArrowAssemble(21195);
            //UpArrowAssemble(21312);
            //DownArrowAssemble(21555);
            //UpArrowAssemble(21753);
            //RightArrowAssemble(21969);
            //DownArrowAssemble(22068);
            //UpArrowAssemble(22167);
            //DownArrowAssemble(22383);
            //LeftArrowAssemble(22617);
            //UpArrowAssemble(22689);
            //DownArrowAssemble(22806);
            //UpArrowAssemble(22914);
            //RightArrowAssemble(23031);
            //DownArrowAssemble(23148);
            //UpArrowAssemble(23274);
            //DownArrowAssemble(23355);
            //LeftArrowAssemble(23472);
            //DownArrowAssemble(23670);
            //UpArrowAssemble(23778);
            //DownArrowAssemble(23886);
            //UpArrowAssemble(24111);
            //RightArrowAssemble(24336);
            //DownArrowAssemble(24426);
            //UpArrowAssemble(24543);
            //LeftArrowAssemble(24642);
            //UpArrowAssemble(24741);
            //DownArrowAssemble(24966);
            //UpArrowAssemble(25173);
            //DownArrowAssemble(25380);
            //UpArrowAssemble(25479);
            //LeftArrowAssemble(25641);
            //UpArrowAssemble(25731);
            //DownArrowAssemble(25866);
            //UpArrowAssemble(25965);
            //RightArrowAssemble(26091);
            //DownArrowAssemble(26199);
            //UpArrowAssemble(26289);
            //LeftArrowAssemble(26406);
            //UpArrowAssemble(26496);
            //DownArrowAssemble(26613);
            //UpArrowAssemble(26703);
            //DownArrowAssemble(26784);
            //UpArrowAssemble(26901);
            //DownArrowAssemble(27099);
            //UpArrowAssemble(27306);
            //DownArrowAssemble(27477);
            //LeftArrowAssemble(27702);
            //RightArrowAssemble(27792);
            //UpArrowAssemble(27936);
            //DownArrowAssemble(28035);
            //UpArrowAssemble(28161);
            //Pattern
            //Pattern
            RightArrowAssemble(612);
            DownArrowAssemble(729);
            LeftArrowAssemble(1458);
            UpArrowAssemble(1575);
            DownArrowAssemble(2034);
            DownArrowAssemble(2241);
            RightArrowAssemble(2943);
            UpArrowAssemble(3141);
            LeftArrowAssemble(3771);
            DownArrowAssemble(3996);
            UpArrowAssemble(4095);
            RightArrowAssemble(4617);
            UpArrowAssemble(4842);
            DownArrowAssemble(4932);
            LeftArrowAssemble(5436);
            UpArrowAssemble(5652);
            UpArrowAssemble(5877);
            DownArrowAssemble(6102);
            UpArrowAssemble(6201);
            DownArrowAssemble(6318);
            LeftArrowAssemble(6516);
            LeftArrowAssemble(7137);
            DownArrowAssemble(7362);
            UpArrowAssemble(7479);
            DownArrowAssemble(7686);
            RightArrowAssemble(7983);
            UpArrowAssemble(8226);
            DownArrowAssemble(8325);
            UpArrowAssemble(8559);
            LeftArrowAssemble(8856);
            DownArrowAssemble(9072);
            UpArrowAssemble(9288);
            RightArrowAssemble(9504);
            DownArrowAssemble(9720);
            UpArrowAssemble(9918);
            DownArrowAssemble(10125);
            UpArrowAssemble(10323);
            LeftArrowAssemble(10332);
            DownArrowAssemble(10332);
            RightArrowAssemble(10341);
            DownArrowAssemble(10575);
            LeftArrowAssemble(10791);
            RightArrowAssemble(10863);
            DownArrowAssemble(11187);
            UpArrowAssemble(11277);
            RightArrowAssemble(11367);
            DownArrowAssemble(11448);
            UpArrowAssemble(11556);
            LeftArrowAssemble(11646);
            DownArrowAssemble(11754);
            UpArrowAssemble(12078);
            UpArrowAssemble(12285);
            RightArrowAssemble(12483);
            DownArrowAssemble(12699);
            LeftArrowAssemble(12789);
            RightArrowAssemble(12924);
            DownArrowAssemble(13014);
            UpArrowAssemble(13131);
            LeftArrowAssemble(13203);
            UpArrowAssemble(13320);
            DownArrowAssemble(13455);
            DownArrowAssemble(13770);
            UpArrowAssemble(14022);
            RightArrowAssemble(14103);
            DownArrowAssemble(14202);
            UpArrowAssemble(14292);
            LeftArrowAssemble(14373);
            DownArrowAssemble(14634);
            UpArrowAssemble(14742);
            DownArrowAssemble(14841);
            UpArrowAssemble(14913);
            RightArrowAssemble(15048);
            DownArrowAssemble(15147);
            UpArrowAssemble(15228);
            LeftArrowAssemble(15309);
            UpArrowAssemble(15498);
            DownArrowAssemble(15516);
            RightArrowAssemble(15516);
            LeftArrowAssemble(15525);
            UpArrowAssemble(15714);
            LeftArrowAssemble(15723);
            DownArrowAssemble(15723);
            RightArrowAssemble(15723);
            DownArrowAssemble(15930);
            UpArrowAssemble(16029);
            RightArrowAssemble(16155);
            DownArrowAssemble(16254);
            UpArrowAssemble(16371);
            LeftArrowAssemble(16479);
            UpArrowAssemble(16560);
            DownArrowAssemble(16731);
            UpArrowAssemble(16965);
            DownArrowAssemble(16965);
            RightArrowAssemble(16974);
            LeftArrowAssemble(16992);
            UpArrowAssemble(17199);
            LeftArrowAssemble(17208);
            DownArrowAssemble(17217);
            RightArrowAssemble(17217);
            DownArrowAssemble(17433);
            UpArrowAssemble(17667);
            RightArrowAssemble(17865);
            DownArrowAssemble(17946);
            UpArrowAssemble(18054);
            LeftArrowAssemble(18162);
            UpArrowAssemble(18279);
            DownArrowAssemble(18369);
            UpArrowAssemble(18468);
            DownArrowAssemble(18702);
            LeftArrowAssemble(18909);
            UpArrowAssemble(19170);
            DownArrowAssemble(19242);
            UpArrowAssemble(19332);
            RightArrowAssemble(19557);
            DownArrowAssemble(19755);
            UpArrowAssemble(19854);
            DownArrowAssemble(19962);
            UpArrowAssemble(20061);
            LeftArrowAssemble(20169);
            UpArrowAssemble(20304);
            DownArrowAssemble(20412);
            UpArrowAssemble(20511);
            DownArrowAssemble(20619);
            RightArrowAssemble(20826);
            DownArrowAssemble(21024);
            UpArrowAssemble(21240);
            DownArrowAssemble(21456);
            UpArrowAssemble(21564);
            LeftArrowAssemble(21681);
            UpArrowAssemble(21798);
            UpArrowAssemble(21915);
            DownArrowAssemble(22320);
            LeftArrowAssemble(22527);
            RightArrowAssemble(22635);
            DownArrowAssemble(22725);
            UpArrowAssemble(22842);
            DownArrowAssemble(23004);
            UpArrowAssemble(23202);
            RightArrowAssemble(23283);
            DownArrowAssemble(23373);
            UpArrowAssemble(23445);
            LeftArrowAssemble(23535);
            UpArrowAssemble(23625);
            DownArrowAssemble(23733);
            UpArrowAssemble(23841);
            DownArrowAssemble(23913);
            UpArrowAssemble(24030);
            RightArrowAssemble(24255);
            DownArrowAssemble(24462);
            UpArrowAssemble(24678);
            DownArrowAssemble(24912);
            UpArrowAssemble(25020);
            DownArrowAssemble(25110);
            LeftArrowAssemble(25335);
            UpArrowAssemble(25578);
            DownArrowAssemble(25686);
            UpArrowAssemble(25767);
            RightArrowAssemble(25983);
            DownArrowAssemble(26181);
            LeftArrowAssemble(26397);
            RightArrowAssemble(26496);
            DownArrowAssemble(26595);
            LeftArrowAssemble(26703);
            RightArrowAssemble(26793);
            DownArrowAssemble(26892);
            LeftArrowAssemble(27000);
            DownArrowAssemble(27243);
            UpArrowAssemble(27459);
            RightArrowAssemble(27666);
            DownArrowAssemble(27765);
            LeftArrowAssemble(27900);
            DownArrowAssemble(27990);
            LeftArrowAssemble(28116);
            DownArrowAssemble(28323);
            UpArrowAssemble(28431);
            RightArrowAssemble(28530);
            DownArrowAssemble(28611);
            UpArrowAssemble(28719);
            LeftArrowAssemble(28980);
            LeftArrowAssemble(29160);



        }

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
        private void HeatWaves_Load(object sender, EventArgs e)
        {
            _sP.Play();
            TMR_ShiftPictureBoxes.Start();
        }

        private void TMR_ShiftPictureBoxes_Tick(object sender, EventArgs e)
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

            lblScore.Text = "Score: " + _score.ToString();
        }

        private void HeatWaves_FormClosed(object sender, FormClosedEventArgs e)
        {
            string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            sCurrentDirectory = sCurrentDirectory.Remove(sCurrentDirectory.Length - 10, 10);
            sCurrentDirectory += "Resources\\Pattern.txt";
            File.WriteAllText(sCurrentDirectory, txtFile);
        }
    }
}