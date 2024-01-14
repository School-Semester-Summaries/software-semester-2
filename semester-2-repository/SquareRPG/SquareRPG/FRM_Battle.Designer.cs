
namespace SquareRPG
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LBL_PlayerHealth = new System.Windows.Forms.Label();
            this.LBL_EnemyHealth = new System.Windows.Forms.Label();
            this.GB_Moveset = new System.Windows.Forms.GroupBox();
            this.BTN_Attack = new System.Windows.Forms.Button();
            this.LBL_EventTracker = new System.Windows.Forms.Label();
            this.TMR_EnemyDelay = new System.Windows.Forms.Timer(this.components);
            this.LBL_PlayerAction = new System.Windows.Forms.Label();
            this.LBL_EnemyAction = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.GB_Moveset.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(593, 171);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(160, 171);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // LBL_PlayerHealth
            // 
            this.LBL_PlayerHealth.AutoSize = true;
            this.LBL_PlayerHealth.Font = new System.Drawing.Font("Felix Titling", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_PlayerHealth.Location = new System.Drawing.Point(16, 11);
            this.LBL_PlayerHealth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_PlayerHealth.Name = "LBL_PlayerHealth";
            this.LBL_PlayerHealth.Size = new System.Drawing.Size(114, 16);
            this.LBL_PlayerHealth.TabIndex = 2;
            this.LBL_PlayerHealth.Text = "PlayerHealth";
            // 
            // LBL_EnemyHealth
            // 
            this.LBL_EnemyHealth.AutoSize = true;
            this.LBL_EnemyHealth.Font = new System.Drawing.Font("Felix Titling", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_EnemyHealth.Location = new System.Drawing.Point(691, 11);
            this.LBL_EnemyHealth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_EnemyHealth.Name = "LBL_EnemyHealth";
            this.LBL_EnemyHealth.Size = new System.Drawing.Size(109, 16);
            this.LBL_EnemyHealth.TabIndex = 3;
            this.LBL_EnemyHealth.Text = "EnemyHealth";
            // 
            // GB_Moveset
            // 
            this.GB_Moveset.Controls.Add(this.BTN_Attack);
            this.GB_Moveset.Font = new System.Drawing.Font("Felix Titling", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_Moveset.Location = new System.Drawing.Point(20, 266);
            this.GB_Moveset.Margin = new System.Windows.Forms.Padding(4);
            this.GB_Moveset.Name = "GB_Moveset";
            this.GB_Moveset.Padding = new System.Windows.Forms.Padding(4);
            this.GB_Moveset.Size = new System.Drawing.Size(191, 61);
            this.GB_Moveset.TabIndex = 4;
            this.GB_Moveset.TabStop = false;
            this.GB_Moveset.Text = "Moveset";
            // 
            // BTN_Attack
            // 
            this.BTN_Attack.Location = new System.Drawing.Point(10, 22);
            this.BTN_Attack.Name = "BTN_Attack";
            this.BTN_Attack.Size = new System.Drawing.Size(174, 28);
            this.BTN_Attack.TabIndex = 0;
            this.BTN_Attack.Text = "Attack";
            this.BTN_Attack.UseVisualStyleBackColor = true;
            this.BTN_Attack.Click += new System.EventHandler(this.BTN_Attack_Click);
            // 
            // LBL_EventTracker
            // 
            this.LBL_EventTracker.Font = new System.Drawing.Font("Felix Titling", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_EventTracker.Location = new System.Drawing.Point(12, 49);
            this.LBL_EventTracker.Name = "LBL_EventTracker";
            this.LBL_EventTracker.Size = new System.Drawing.Size(776, 23);
            this.LBL_EventTracker.TabIndex = 5;
            this.LBL_EventTracker.Text = "Player has swag";
            this.LBL_EventTracker.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TMR_EnemyDelay
            // 
            this.TMR_EnemyDelay.Interval = 1;
            this.TMR_EnemyDelay.Tick += new System.EventHandler(this.TMR_EnemyDelay_Tick);
            // 
            // LBL_PlayerAction
            // 
            this.LBL_PlayerAction.Location = new System.Drawing.Point(160, 146);
            this.LBL_PlayerAction.Name = "LBL_PlayerAction";
            this.LBL_PlayerAction.Size = new System.Drawing.Size(50, 23);
            this.LBL_PlayerAction.TabIndex = 6;
            this.LBL_PlayerAction.Text = "-0";
            this.LBL_PlayerAction.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LBL_PlayerAction.Visible = false;
            // 
            // LBL_EnemyAction
            // 
            this.LBL_EnemyAction.Location = new System.Drawing.Point(593, 146);
            this.LBL_EnemyAction.Name = "LBL_EnemyAction";
            this.LBL_EnemyAction.Size = new System.Drawing.Size(50, 23);
            this.LBL_EnemyAction.TabIndex = 7;
            this.LBL_EnemyAction.Text = "-0";
            this.LBL_EnemyAction.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LBL_EnemyAction.Visible = false;
            // 
            // FRM_Battle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 404);
            this.Controls.Add(this.LBL_EnemyAction);
            this.Controls.Add(this.LBL_PlayerAction);
            this.Controls.Add(this.LBL_EventTracker);
            this.Controls.Add(this.GB_Moveset);
            this.Controls.Add(this.LBL_EnemyHealth);
            this.Controls.Add(this.LBL_PlayerHealth);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FRM_Battle";
            this.Text = "Battle";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_Battle_FormClosed);
            this.Load += new System.EventHandler(this.FRM_Battle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.GB_Moveset.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label LBL_PlayerHealth;
        private System.Windows.Forms.Label LBL_EnemyHealth;
        private System.Windows.Forms.GroupBox GB_Moveset;
        private System.Windows.Forms.Button BTN_Attack;
        private System.Windows.Forms.Label LBL_EventTracker;
        private System.Windows.Forms.Timer TMR_EnemyDelay;
        private System.Windows.Forms.Label LBL_PlayerAction;
        private System.Windows.Forms.Label LBL_EnemyAction;
    }
}