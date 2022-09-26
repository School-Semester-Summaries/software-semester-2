using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput;
using WindowsInput.Native;

namespace Spambot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int count;
        InputSimulator sim = new InputSimulator();
        void helpmeomgxddswaglordkilnoschope42069epicgames()
        {
            sim.Keyboard.KeyDown(VirtualKeyCode.RIGHT);
        }


        private void TMR_Milliseconds_Tick(object sender, EventArgs e)
        {
            if (count == 0)
            {
                SendKeys.Send(TB_Input.Text);
            }
            else if (count == 1)
            {
                SendKeys.Send(TB_Input2.Text);
            }
            else if (count == 2)
            {
                SendKeys.Send(TB_Input3.Text);
            }
            else
            {
                SendKeys.Send(TB_Input4.Text);
                count = -1;
            }
            count++;
        }

        private void BTN_Stop_Click(object sender, EventArgs e)
        {
            TMR_Inputs.Enabled = false;
        }

        private void BTN_Start_Click(object sender, EventArgs e)
        {
            TMR_Inputs.Enabled = true;
        }

        void SpamLeft()
        {
            SendKeys.Send("{LEFT}");
            SendKeys.Send("{LEFT}");
            SendKeys.Send("{LEFT}");
            SendKeys.Send("{LEFT}");
            SendKeys.Send("{LEFT}");
            SendKeys.Send("{LEFT}");
            SendKeys.Send("{LEFT}");
            SendKeys.Send("{LEFT}");
            SendKeys.Send("{LEFT}");
        }

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr GetDesktopWindow();
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr GetWindowDC(IntPtr window);
        [DllImport("gdi32.dll", SetLastError = true)]
        public static extern uint GetPixel(IntPtr dc, int x, int y);
        [DllImport("user32.dll", SetLastError = true)]
        public static extern int ReleaseDC(IntPtr window, IntPtr dc);

        public static Color GetColorAt(int x, int y)
        {
            IntPtr desk = GetDesktopWindow();
            IntPtr dc = GetWindowDC(desk);
            int a = (int)GetPixel(dc, x, y);
            ReleaseDC(desk, dc);
            return Color.FromArgb(255, (a >> 0) & 0xff, (a >> 8) & 0xff, (a >> 16) & 0xff);
        }

        int successes = 0;
        private void TMR_Color_Tick(object sender, EventArgs e)
        {
            int x;
            int y;

            x = Convert.ToInt32(TB_CheckLocationX.Text);
            y = Convert.ToInt32(TB_CheckLocationY.Text);
            var foundColor = GetColorAt(x, y);
            Color searchingColor = Color.FromArgb(255, 187, 34);
            GetCursorPosition();




            //if (foundColor == searchingColor)
            //{
            //    LBL_Successes.Text = "Successes: " + ++successes;
            //}
            for (int yModifier = 16; yModifier < 25; yModifier++)
            {
                if (searchingColor == GetColorAt(650, 25 * yModifier))
                {
                    while (true)
                    {
                        JumpRight();
                    }
                }
            }

            PB_FoundColor.BackColor = foundColor;
            PB_SearchingColor.BackColor = searchingColor;
        }

        private void BTN_StartColor_Click(object sender, EventArgs e)
        {
            TMR_Color.Enabled = true;
        }

        private void BTN_StopColor_Click(object sender, EventArgs e)
        {
            TMR_Color.Enabled = false;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(GetCursorPosition().ToString());
        }

        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(out POINT lpPoint);

        public static Point GetCursorPosition()
        {
            POINT lpPoint;
            GetCursorPos(out lpPoint);
            return lpPoint;
        }

        void JumpRight()
        {
            sim.Keyboard.KeyDown(VirtualKeyCode.RIGHT);
            SendKeys.Send("{UP}");
            //650, 575
        }

        void CenterCheckPoint()
        {
            //850, 575
        }

        void JumpLeft()
        {
            while (true)
            {
                SendKeys.Send("{LEFT}");
                SendKeys.Send("{UP}");
            }// 1050, 575
        }
    }
}



[StructLayout(LayoutKind.Sequential)]
public struct POINT
{
    public int X;
    public int Y;

    public static implicit operator Point(POINT point)
    {
        return new Point(point.X, point.Y);
    }
}