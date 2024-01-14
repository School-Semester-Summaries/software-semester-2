
namespace FormsAdventure
{
    partial class FRM_Puzzle1
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
            this.BTN_Player = new System.Windows.Forms.Button();
            this.TB_Player = new System.Windows.Forms.TextBox();
            this.LBL_Button1 = new System.Windows.Forms.Label();
            this.LBL_Textbox = new System.Windows.Forms.Label();
            this.LBL_PictureBox = new System.Windows.Forms.Label();
            this.PB_Player = new System.Windows.Forms.PictureBox();
            this.PB_PictureBox = new System.Windows.Forms.PictureBox();
            this.LBL_Button2 = new System.Windows.Forms.Label();
            this.LBL_Button3 = new System.Windows.Forms.Label();
            this.LBL_BTN_Click = new System.Windows.Forms.Label();
            this.PB_PutImageHere = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_PutImageHere)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Player
            // 
            this.BTN_Player.Location = new System.Drawing.Point(526, 12);
            this.BTN_Player.Name = "BTN_Player";
            this.BTN_Player.Size = new System.Drawing.Size(100, 100);
            this.BTN_Player.TabIndex = 0;
            this.BTN_Player.Text = "button1";
            this.BTN_Player.UseVisualStyleBackColor = true;
            this.BTN_Player.Click += new System.EventHandler(this.BTN_Player_Click);
            // 
            // TB_Player
            // 
            this.TB_Player.Location = new System.Drawing.Point(526, 375);
            this.TB_Player.Multiline = true;
            this.TB_Player.Name = "TB_Player";
            this.TB_Player.Size = new System.Drawing.Size(100, 100);
            this.TB_Player.TabIndex = 1;
            this.TB_Player.TextChanged += new System.EventHandler(this.TB_Player_TextChanged);
            // 
            // LBL_Button1
            // 
            this.LBL_Button1.AutoSize = true;
            this.LBL_Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LBL_Button1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_Button1.Location = new System.Drawing.Point(12, 9);
            this.LBL_Button1.Name = "LBL_Button1";
            this.LBL_Button1.Size = new System.Drawing.Size(51, 19);
            this.LBL_Button1.TabIndex = 2;
            this.LBL_Button1.Text = "Button";
            // 
            // LBL_Textbox
            // 
            this.LBL_Textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LBL_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_Textbox.Location = new System.Drawing.Point(232, 9);
            this.LBL_Textbox.Name = "LBL_Textbox";
            this.LBL_Textbox.Size = new System.Drawing.Size(75, 380);
            this.LBL_Textbox.TabIndex = 3;
            this.LBL_Textbox.Text = "Textbox";
            this.LBL_Textbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_PictureBox
            // 
            this.LBL_PictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LBL_PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_PictureBox.Location = new System.Drawing.Point(643, 12);
            this.LBL_PictureBox.Name = "LBL_PictureBox";
            this.LBL_PictureBox.Size = new System.Drawing.Size(100, 100);
            this.LBL_PictureBox.TabIndex = 4;
            this.LBL_PictureBox.Text = "PictureBox";
            // 
            // PB_Player
            // 
            this.PB_Player.ErrorImage = null;
            this.PB_Player.Image = global::FormsAdventure.Properties.Resources.NoImage;
            this.PB_Player.Location = new System.Drawing.Point(643, 375);
            this.PB_Player.Name = "PB_Player";
            this.PB_Player.Size = new System.Drawing.Size(100, 100);
            this.PB_Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Player.TabIndex = 6;
            this.PB_Player.TabStop = false;
            // 
            // PB_PictureBox
            // 
            this.PB_PictureBox.ErrorImage = null;
            this.PB_PictureBox.Image = global::FormsAdventure.Properties.Resources.PictureBox2;
            this.PB_PictureBox.Location = new System.Drawing.Point(447, 140);
            this.PB_PictureBox.Name = "PB_PictureBox";
            this.PB_PictureBox.Size = new System.Drawing.Size(200, 200);
            this.PB_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_PictureBox.TabIndex = 5;
            this.PB_PictureBox.TabStop = false;
            // 
            // LBL_Button2
            // 
            this.LBL_Button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LBL_Button2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_Button2.Location = new System.Drawing.Point(447, 9);
            this.LBL_Button2.Name = "LBL_Button2";
            this.LBL_Button2.Size = new System.Drawing.Size(54, 128);
            this.LBL_Button2.TabIndex = 8;
            this.LBL_Button2.Text = "Button";
            // 
            // LBL_Button3
            // 
            this.LBL_Button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LBL_Button3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_Button3.Location = new System.Drawing.Point(447, 343);
            this.LBL_Button3.Name = "LBL_Button3";
            this.LBL_Button3.Size = new System.Drawing.Size(54, 156);
            this.LBL_Button3.TabIndex = 9;
            this.LBL_Button3.Text = "Button";
            // 
            // LBL_BTN_Click
            // 
            this.LBL_BTN_Click.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LBL_BTN_Click.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_BTN_Click.Location = new System.Drawing.Point(12, 389);
            this.LBL_BTN_Click.Name = "LBL_BTN_Click";
            this.LBL_BTN_Click.Size = new System.Drawing.Size(295, 110);
            this.LBL_BTN_Click.TabIndex = 10;
            this.LBL_BTN_Click.Text = "BTN_Click";
            this.LBL_BTN_Click.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PB_PutImageHere
            // 
            this.PB_PutImageHere.ErrorImage = null;
            this.PB_PutImageHere.Image = global::FormsAdventure.Properties.Resources.PutImageHer;
            this.PB_PutImageHere.Location = new System.Drawing.Point(126, 9);
            this.PB_PutImageHere.Name = "PB_PutImageHere";
            this.PB_PutImageHere.Size = new System.Drawing.Size(100, 100);
            this.PB_PutImageHere.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_PutImageHere.TabIndex = 11;
            this.PB_PutImageHere.TabStop = false;
            // 
            // FRM_Puzzle1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 508);
            this.Controls.Add(this.PB_PutImageHere);
            this.Controls.Add(this.LBL_BTN_Click);
            this.Controls.Add(this.LBL_Button3);
            this.Controls.Add(this.LBL_Button2);
            this.Controls.Add(this.PB_Player);
            this.Controls.Add(this.PB_PictureBox);
            this.Controls.Add(this.LBL_PictureBox);
            this.Controls.Add(this.LBL_Textbox);
            this.Controls.Add(this.TB_Player);
            this.Controls.Add(this.BTN_Player);
            this.Controls.Add(this.LBL_Button1);
            this.Name = "FRM_Puzzle1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PB_Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_PutImageHere)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Player;
        private System.Windows.Forms.TextBox TB_Player;
        private System.Windows.Forms.Label LBL_Button1;
        private System.Windows.Forms.Label LBL_Textbox;
        private System.Windows.Forms.Label LBL_PictureBox;
        private System.Windows.Forms.PictureBox PB_PictureBox;
        private System.Windows.Forms.PictureBox PB_Player;
        private System.Windows.Forms.Label LBL_Button2;
        private System.Windows.Forms.Label LBL_Button3;
        private System.Windows.Forms.Label LBL_BTN_Click;
        private System.Windows.Forms.PictureBox PB_PutImageHere;
    }
}

