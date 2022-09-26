
namespace WinformsStaticLogin
{
    partial class FRM_Reservation
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
            this.LBL_User = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBL_User
            // 
            this.LBL_User.AutoSize = true;
            this.LBL_User.Location = new System.Drawing.Point(12, 9);
            this.LBL_User.Name = "LBL_User";
            this.LBL_User.Size = new System.Drawing.Size(45, 17);
            this.LBL_User.TabIndex = 0;
            this.LBL_User.Text = "Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(414, 367);
            this.button1.TabIndex = 1;
            this.button1.Text = "My Reservations";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(644, 244);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(414, 367);
            this.button2.TabIndex = 2;
            this.button2.Text = "Create Reservation";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FRM_Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 722);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LBL_User);
            this.Name = "FRM_Reservation";
            this.Text = "FRM_Reservation";
            this.Load += new System.EventHandler(this.FRM_Reservation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_User;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}