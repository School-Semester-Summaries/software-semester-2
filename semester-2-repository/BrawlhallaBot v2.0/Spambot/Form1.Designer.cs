
namespace Spambot
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TMR_Inputs = new System.Windows.Forms.Timer(this.components);
            this.BTN_Start = new System.Windows.Forms.Button();
            this.BTN_Stop = new System.Windows.Forms.Button();
            this.TB_Input = new System.Windows.Forms.TextBox();
            this.TB_Input2 = new System.Windows.Forms.TextBox();
            this.TB_Input3 = new System.Windows.Forms.TextBox();
            this.TB_Input4 = new System.Windows.Forms.TextBox();
            this.PB_FoundColor = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TMR_Color = new System.Windows.Forms.Timer(this.components);
            this.BTN_StartColor = new System.Windows.Forms.Button();
            this.BTN_StopColor = new System.Windows.Forms.Button();
            this.PB_SearchingColor = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TB_CheckLocationX = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TB_CheckLocationY = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.LBL_Successes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PB_FoundColor)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_SearchingColor)).BeginInit();
            this.SuspendLayout();
            // 
            // TMR_Inputs
            // 
            this.TMR_Inputs.Interval = 500;
            this.TMR_Inputs.Tick += new System.EventHandler(this.TMR_Milliseconds_Tick);
            // 
            // BTN_Start
            // 
            this.BTN_Start.Location = new System.Drawing.Point(9, 127);
            this.BTN_Start.Name = "BTN_Start";
            this.BTN_Start.Size = new System.Drawing.Size(57, 27);
            this.BTN_Start.TabIndex = 0;
            this.BTN_Start.Text = "Start";
            this.BTN_Start.UseVisualStyleBackColor = true;
            this.BTN_Start.Click += new System.EventHandler(this.BTN_Start_Click);
            // 
            // BTN_Stop
            // 
            this.BTN_Stop.Location = new System.Drawing.Point(68, 127);
            this.BTN_Stop.Name = "BTN_Stop";
            this.BTN_Stop.Size = new System.Drawing.Size(57, 27);
            this.BTN_Stop.TabIndex = 1;
            this.BTN_Stop.Text = "Stop";
            this.BTN_Stop.UseVisualStyleBackColor = true;
            this.BTN_Stop.Click += new System.EventHandler(this.BTN_Stop_Click);
            // 
            // TB_Input
            // 
            this.TB_Input.Location = new System.Drawing.Point(63, 15);
            this.TB_Input.Name = "TB_Input";
            this.TB_Input.Size = new System.Drawing.Size(62, 22);
            this.TB_Input.TabIndex = 2;
            // 
            // TB_Input2
            // 
            this.TB_Input2.Location = new System.Drawing.Point(63, 43);
            this.TB_Input2.Name = "TB_Input2";
            this.TB_Input2.Size = new System.Drawing.Size(62, 22);
            this.TB_Input2.TabIndex = 3;
            // 
            // TB_Input3
            // 
            this.TB_Input3.Location = new System.Drawing.Point(63, 71);
            this.TB_Input3.Name = "TB_Input3";
            this.TB_Input3.Size = new System.Drawing.Size(62, 22);
            this.TB_Input3.TabIndex = 4;
            // 
            // TB_Input4
            // 
            this.TB_Input4.Location = new System.Drawing.Point(63, 99);
            this.TB_Input4.Name = "TB_Input4";
            this.TB_Input4.Size = new System.Drawing.Size(62, 22);
            this.TB_Input4.TabIndex = 5;
            // 
            // PB_FoundColor
            // 
            this.PB_FoundColor.Location = new System.Drawing.Point(6, 93);
            this.PB_FoundColor.Name = "PB_FoundColor";
            this.PB_FoundColor.Size = new System.Drawing.Size(70, 44);
            this.PB_FoundColor.TabIndex = 6;
            this.PB_FoundColor.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Input 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Input 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Input 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Input 4";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.BTN_Start);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.BTN_Stop);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TB_Input);
            this.groupBox1.Controls.Add(this.TB_Input2);
            this.groupBox1.Controls.Add(this.TB_Input3);
            this.groupBox1.Controls.Add(this.TB_Input4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 162);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Simulator";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LBL_Successes);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.TB_CheckLocationY);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.TB_CheckLocationX);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.PB_SearchingColor);
            this.groupBox2.Controls.Add(this.BTN_StartColor);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.PB_FoundColor);
            this.groupBox2.Controls.Add(this.BTN_StopColor);
            this.groupBox2.Location = new System.Drawing.Point(12, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(181, 201);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Color Finder";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Found";
            // 
            // TMR_Color
            // 
            this.TMR_Color.Interval = 1;
            this.TMR_Color.Tick += new System.EventHandler(this.TMR_Color_Tick);
            // 
            // BTN_StartColor
            // 
            this.BTN_StartColor.Location = new System.Drawing.Point(6, 143);
            this.BTN_StartColor.Name = "BTN_StartColor";
            this.BTN_StartColor.Size = new System.Drawing.Size(70, 27);
            this.BTN_StartColor.TabIndex = 11;
            this.BTN_StartColor.Text = "Start";
            this.BTN_StartColor.UseVisualStyleBackColor = true;
            this.BTN_StartColor.Click += new System.EventHandler(this.BTN_StartColor_Click);
            // 
            // BTN_StopColor
            // 
            this.BTN_StopColor.Location = new System.Drawing.Point(82, 143);
            this.BTN_StopColor.Name = "BTN_StopColor";
            this.BTN_StopColor.Size = new System.Drawing.Size(93, 27);
            this.BTN_StopColor.TabIndex = 12;
            this.BTN_StopColor.Text = "Stop";
            this.BTN_StopColor.UseVisualStyleBackColor = true;
            this.BTN_StopColor.Click += new System.EventHandler(this.BTN_StopColor_Click);
            // 
            // PB_SearchingColor
            // 
            this.PB_SearchingColor.Location = new System.Drawing.Point(82, 93);
            this.PB_SearchingColor.Name = "PB_SearchingColor";
            this.PB_SearchingColor.Size = new System.Drawing.Size(93, 44);
            this.PB_SearchingColor.TabIndex = 13;
            this.PB_SearchingColor.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "searching";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Check Location";
            // 
            // TB_CheckLocationX
            // 
            this.TB_CheckLocationX.Location = new System.Drawing.Point(29, 43);
            this.TB_CheckLocationX.Name = "TB_CheckLocationX";
            this.TB_CheckLocationX.Size = new System.Drawing.Size(47, 22);
            this.TB_CheckLocationX.TabIndex = 11;
            this.TB_CheckLocationX.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "X:";
            // 
            // TB_CheckLocationY
            // 
            this.TB_CheckLocationY.Location = new System.Drawing.Point(128, 43);
            this.TB_CheckLocationY.Name = "TB_CheckLocationY";
            this.TB_CheckLocationY.Size = new System.Drawing.Size(47, 22);
            this.TB_CheckLocationY.TabIndex = 16;
            this.TB_CheckLocationY.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(101, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Y:";
            // 
            // LBL_Successes
            // 
            this.LBL_Successes.AutoSize = true;
            this.LBL_Successes.Location = new System.Drawing.Point(6, 181);
            this.LBL_Successes.Name = "LBL_Successes";
            this.LBL_Successes.Size = new System.Drawing.Size(99, 17);
            this.LBL_Successes.TabIndex = 18;
            this.LBL_Successes.Text = "Succcesses: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 388);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.PB_FoundColor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_SearchingColor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer TMR_Inputs;
        private System.Windows.Forms.Button BTN_Start;
        private System.Windows.Forms.Button BTN_Stop;
        private System.Windows.Forms.TextBox TB_Input;
        private System.Windows.Forms.TextBox TB_Input2;
        private System.Windows.Forms.TextBox TB_Input3;
        private System.Windows.Forms.TextBox TB_Input4;
        private System.Windows.Forms.PictureBox PB_FoundColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer TMR_Color;
        private System.Windows.Forms.Button BTN_StartColor;
        private System.Windows.Forms.Button BTN_StopColor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox PB_SearchingColor;
        private System.Windows.Forms.TextBox TB_CheckLocationX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TB_CheckLocationY;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LBL_Successes;
    }
}

