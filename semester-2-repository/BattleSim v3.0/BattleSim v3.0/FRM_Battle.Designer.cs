
namespace BattleSim_v3._0
{
    partial class FRM_Battle
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
            this.PB_Player1_NeoFighter = new System.Windows.Forms.PictureBox();
            this.PB_Player2_NeoFighter = new System.Windows.Forms.PictureBox();
            this.BTN_Player1_Attack = new System.Windows.Forms.Button();
            this.BTN_Player2_Attack = new System.Windows.Forms.Button();
            this.LBL_Player1_Health = new System.Windows.Forms.Label();
            this.LBL_Player2_Health = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Player1_NeoFighter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Player2_NeoFighter)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_Player1_NeoFighter
            // 
            this.PB_Player1_NeoFighter.Location = new System.Drawing.Point(12, 12);
            this.PB_Player1_NeoFighter.Name = "PB_Player1_NeoFighter";
            this.PB_Player1_NeoFighter.Size = new System.Drawing.Size(300, 300);
            this.PB_Player1_NeoFighter.TabIndex = 0;
            this.PB_Player1_NeoFighter.TabStop = false;
            // 
            // PB_Player2_NeoFighter
            // 
            this.PB_Player2_NeoFighter.Location = new System.Drawing.Point(488, 12);
            this.PB_Player2_NeoFighter.Name = "PB_Player2_NeoFighter";
            this.PB_Player2_NeoFighter.Size = new System.Drawing.Size(300, 300);
            this.PB_Player2_NeoFighter.TabIndex = 1;
            this.PB_Player2_NeoFighter.TabStop = false;
            // 
            // BTN_Player1_Attack
            // 
            this.BTN_Player1_Attack.Location = new System.Drawing.Point(12, 318);
            this.BTN_Player1_Attack.Name = "BTN_Player1_Attack";
            this.BTN_Player1_Attack.Size = new System.Drawing.Size(300, 38);
            this.BTN_Player1_Attack.TabIndex = 2;
            this.BTN_Player1_Attack.Text = "Attack";
            this.BTN_Player1_Attack.UseVisualStyleBackColor = true;
            this.BTN_Player1_Attack.Click += new System.EventHandler(this.BTN_Player1_Attack_Click);
            // 
            // BTN_Player2_Attack
            // 
            this.BTN_Player2_Attack.Enabled = false;
            this.BTN_Player2_Attack.Location = new System.Drawing.Point(488, 318);
            this.BTN_Player2_Attack.Name = "BTN_Player2_Attack";
            this.BTN_Player2_Attack.Size = new System.Drawing.Size(300, 38);
            this.BTN_Player2_Attack.TabIndex = 3;
            this.BTN_Player2_Attack.Text = "Attack";
            this.BTN_Player2_Attack.UseVisualStyleBackColor = true;
            this.BTN_Player2_Attack.Click += new System.EventHandler(this.BTN_Player2_Attack_Click);
            // 
            // LBL_Player1_Health
            // 
            this.LBL_Player1_Health.AutoSize = true;
            this.LBL_Player1_Health.Location = new System.Drawing.Point(12, 359);
            this.LBL_Player1_Health.Name = "LBL_Player1_Health";
            this.LBL_Player1_Health.Size = new System.Drawing.Size(0, 17);
            this.LBL_Player1_Health.TabIndex = 4;
            // 
            // LBL_Player2_Health
            // 
            this.LBL_Player2_Health.AutoSize = true;
            this.LBL_Player2_Health.Location = new System.Drawing.Point(485, 359);
            this.LBL_Player2_Health.Name = "LBL_Player2_Health";
            this.LBL_Player2_Health.Size = new System.Drawing.Size(0, 17);
            this.LBL_Player2_Health.TabIndex = 5;
            // 
            // FRM_Battle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LBL_Player2_Health);
            this.Controls.Add(this.LBL_Player1_Health);
            this.Controls.Add(this.BTN_Player2_Attack);
            this.Controls.Add(this.BTN_Player1_Attack);
            this.Controls.Add(this.PB_Player2_NeoFighter);
            this.Controls.Add(this.PB_Player1_NeoFighter);
            this.Name = "FRM_Battle";
            this.Text = "FRM_Battle";
            this.Load += new System.EventHandler(this.FRM_Battle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Player1_NeoFighter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Player2_NeoFighter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_Player1_NeoFighter;
        private System.Windows.Forms.PictureBox PB_Player2_NeoFighter;
        private System.Windows.Forms.Button BTN_Player1_Attack;
        private System.Windows.Forms.Button BTN_Player2_Attack;
        private System.Windows.Forms.Label LBL_Player1_Health;
        private System.Windows.Forms.Label LBL_Player2_Health;
    }
}