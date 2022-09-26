
namespace Televisie
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
            this.BTN_Aan = new System.Windows.Forms.Button();
            this.BTN_Uit = new System.Windows.Forms.Button();
            this.LBL_TvState = new System.Windows.Forms.Label();
            this.LB_Zenders = new System.Windows.Forms.ListBox();
            this.BTN_AddZenders = new System.Windows.Forms.Button();
            this.TB_AddZender = new System.Windows.Forms.TextBox();
            this.LBL_Channels = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_Aan
            // 
            this.BTN_Aan.Location = new System.Drawing.Point(47, 48);
            this.BTN_Aan.Name = "BTN_Aan";
            this.BTN_Aan.Size = new System.Drawing.Size(75, 73);
            this.BTN_Aan.TabIndex = 0;
            this.BTN_Aan.Text = "Aan";
            this.BTN_Aan.UseVisualStyleBackColor = true;
            this.BTN_Aan.Click += new System.EventHandler(this.BTN_Aan_Click);
            // 
            // BTN_Uit
            // 
            this.BTN_Uit.Location = new System.Drawing.Point(47, 172);
            this.BTN_Uit.Name = "BTN_Uit";
            this.BTN_Uit.Size = new System.Drawing.Size(75, 73);
            this.BTN_Uit.TabIndex = 1;
            this.BTN_Uit.Text = "Uit";
            this.BTN_Uit.UseVisualStyleBackColor = true;
            this.BTN_Uit.Click += new System.EventHandler(this.BTN_Uit_Click);
            // 
            // LBL_TvState
            // 
            this.LBL_TvState.AutoSize = true;
            this.LBL_TvState.Location = new System.Drawing.Point(302, 48);
            this.LBL_TvState.Name = "LBL_TvState";
            this.LBL_TvState.Size = new System.Drawing.Size(25, 17);
            this.LBL_TvState.TabIndex = 2;
            this.LBL_TvState.Text = "Uit";
            // 
            // LB_Zenders
            // 
            this.LB_Zenders.FormattingEnabled = true;
            this.LB_Zenders.ItemHeight = 16;
            this.LB_Zenders.Location = new System.Drawing.Point(460, 12);
            this.LB_Zenders.Name = "LB_Zenders";
            this.LB_Zenders.Size = new System.Drawing.Size(120, 308);
            this.LB_Zenders.TabIndex = 3;
            // 
            // BTN_AddZenders
            // 
            this.BTN_AddZenders.Location = new System.Drawing.Point(169, 339);
            this.BTN_AddZenders.Name = "BTN_AddZenders";
            this.BTN_AddZenders.Size = new System.Drawing.Size(98, 23);
            this.BTN_AddZenders.TabIndex = 4;
            this.BTN_AddZenders.Text = "Add";
            this.BTN_AddZenders.UseVisualStyleBackColor = true;
            this.BTN_AddZenders.Click += new System.EventHandler(this.BTN_AddZenders_Click);
            // 
            // TB_AddZender
            // 
            this.TB_AddZender.Location = new System.Drawing.Point(47, 340);
            this.TB_AddZender.Name = "TB_AddZender";
            this.TB_AddZender.Size = new System.Drawing.Size(100, 22);
            this.TB_AddZender.TabIndex = 5;
            // 
            // LBL_Channels
            // 
            this.LBL_Channels.AutoSize = true;
            this.LBL_Channels.Location = new System.Drawing.Point(302, 104);
            this.LBL_Channels.Name = "LBL_Channels";
            this.LBL_Channels.Size = new System.Drawing.Size(75, 17);
            this.LBL_Channels.TabIndex = 6;
            this.LBL_Channels.Text = "Channels: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 450);
            this.Controls.Add(this.LBL_Channels);
            this.Controls.Add(this.TB_AddZender);
            this.Controls.Add(this.BTN_AddZenders);
            this.Controls.Add(this.LB_Zenders);
            this.Controls.Add(this.LBL_TvState);
            this.Controls.Add(this.BTN_Uit);
            this.Controls.Add(this.BTN_Aan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Aan;
        private System.Windows.Forms.Button BTN_Uit;
        private System.Windows.Forms.Label LBL_TvState;
        private System.Windows.Forms.ListBox LB_Zenders;
        private System.Windows.Forms.Button BTN_AddZenders;
        private System.Windows.Forms.TextBox TB_AddZender;
        private System.Windows.Forms.Label LBL_Channels;
    }
}

