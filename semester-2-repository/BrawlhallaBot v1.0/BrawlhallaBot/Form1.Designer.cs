
namespace BrawlhallaBot
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
            this.LBL = new System.Windows.Forms.Label();
            this.TB_Input = new System.Windows.Forms.TextBox();
            this.GB_InputMenu = new System.Windows.Forms.GroupBox();
            this.BTN_Stop = new System.Windows.Forms.Button();
            this.BTN_Start = new System.Windows.Forms.Button();
            this.TMR_Input = new System.Windows.Forms.Timer(this.components);
            this.GB_InputMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBL
            // 
            this.LBL.AutoSize = true;
            this.LBL.Location = new System.Drawing.Point(6, 38);
            this.LBL.Name = "LBL";
            this.LBL.Size = new System.Drawing.Size(51, 17);
            this.LBL.TabIndex = 0;
            this.LBL.Text = "Input 1";
            // 
            // TB_Input
            // 
            this.TB_Input.Location = new System.Drawing.Point(63, 38);
            this.TB_Input.MaxLength = 25;
            this.TB_Input.Name = "TB_Input";
            this.TB_Input.Size = new System.Drawing.Size(100, 22);
            this.TB_Input.TabIndex = 1;
            // 
            // GB_InputMenu
            // 
            this.GB_InputMenu.Controls.Add(this.BTN_Stop);
            this.GB_InputMenu.Controls.Add(this.BTN_Start);
            this.GB_InputMenu.Controls.Add(this.LBL);
            this.GB_InputMenu.Controls.Add(this.TB_Input);
            this.GB_InputMenu.Location = new System.Drawing.Point(12, 12);
            this.GB_InputMenu.Name = "GB_InputMenu";
            this.GB_InputMenu.Size = new System.Drawing.Size(170, 102);
            this.GB_InputMenu.TabIndex = 2;
            this.GB_InputMenu.TabStop = false;
            this.GB_InputMenu.Text = "Input Menu";
            // 
            // BTN_Stop
            // 
            this.BTN_Stop.Location = new System.Drawing.Point(88, 66);
            this.BTN_Stop.Name = "BTN_Stop";
            this.BTN_Stop.Size = new System.Drawing.Size(75, 30);
            this.BTN_Stop.TabIndex = 3;
            this.BTN_Stop.Text = "Stop";
            this.BTN_Stop.UseVisualStyleBackColor = true;
            this.BTN_Stop.Click += new System.EventHandler(this.BTN_Stop_Click);
            // 
            // BTN_Start
            // 
            this.BTN_Start.Location = new System.Drawing.Point(6, 66);
            this.BTN_Start.Name = "BTN_Start";
            this.BTN_Start.Size = new System.Drawing.Size(75, 30);
            this.BTN_Start.TabIndex = 2;
            this.BTN_Start.Text = "Start";
            this.BTN_Start.UseVisualStyleBackColor = true;
            this.BTN_Start.Click += new System.EventHandler(this.BTN_Start_Click);
            // 
            // TMR_Input
            // 
            this.TMR_Input.Interval = 1000;
            this.TMR_Input.Tick += new System.EventHandler(this.TMR_Input_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 122);
            this.Controls.Add(this.GB_InputMenu);
            this.Name = "Form1";
            this.Text = "Menu";
            this.GB_InputMenu.ResumeLayout(false);
            this.GB_InputMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LBL;
        private System.Windows.Forms.TextBox TB_Input;
        private System.Windows.Forms.GroupBox GB_InputMenu;
        private System.Windows.Forms.Button BTN_Stop;
        private System.Windows.Forms.Button BTN_Start;
        private System.Windows.Forms.Timer TMR_Input;
    }
}

