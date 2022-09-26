
namespace SchedulesOnForms.LeerlingForms
{
    partial class FRM_Home
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
            this.LB_Wiskunde = new System.Windows.Forms.ListBox();
            this.LB_Engels = new System.Windows.Forms.ListBox();
            this.LB_Natuurkunde = new System.Windows.Forms.ListBox();
            this.LB_Scheikunde = new System.Windows.Forms.ListBox();
            this.LB_Nederlands = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LB_Wiskunde
            // 
            this.LB_Wiskunde.FormattingEnabled = true;
            this.LB_Wiskunde.ItemHeight = 16;
            this.LB_Wiskunde.Location = new System.Drawing.Point(12, 12);
            this.LB_Wiskunde.Name = "LB_Wiskunde";
            this.LB_Wiskunde.Size = new System.Drawing.Size(120, 420);
            this.LB_Wiskunde.TabIndex = 0;
            // 
            // LB_Engels
            // 
            this.LB_Engels.FormattingEnabled = true;
            this.LB_Engels.ItemHeight = 16;
            this.LB_Engels.Location = new System.Drawing.Point(515, 12);
            this.LB_Engels.Name = "LB_Engels";
            this.LB_Engels.Size = new System.Drawing.Size(120, 420);
            this.LB_Engels.TabIndex = 1;
            // 
            // LB_Natuurkunde
            // 
            this.LB_Natuurkunde.FormattingEnabled = true;
            this.LB_Natuurkunde.ItemHeight = 16;
            this.LB_Natuurkunde.Location = new System.Drawing.Point(138, 12);
            this.LB_Natuurkunde.Name = "LB_Natuurkunde";
            this.LB_Natuurkunde.Size = new System.Drawing.Size(120, 420);
            this.LB_Natuurkunde.TabIndex = 2;
            // 
            // LB_Scheikunde
            // 
            this.LB_Scheikunde.FormattingEnabled = true;
            this.LB_Scheikunde.ItemHeight = 16;
            this.LB_Scheikunde.Location = new System.Drawing.Point(264, 12);
            this.LB_Scheikunde.Name = "LB_Scheikunde";
            this.LB_Scheikunde.Size = new System.Drawing.Size(120, 420);
            this.LB_Scheikunde.TabIndex = 3;
            // 
            // LB_Nederlands
            // 
            this.LB_Nederlands.FormattingEnabled = true;
            this.LB_Nederlands.ItemHeight = 16;
            this.LB_Nederlands.Location = new System.Drawing.Point(390, 12);
            this.LB_Nederlands.Name = "LB_Nederlands";
            this.LB_Nederlands.Size = new System.Drawing.Size(120, 420);
            this.LB_Nederlands.TabIndex = 4;
            // 
            // FRM_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 441);
            this.Controls.Add(this.LB_Nederlands);
            this.Controls.Add(this.LB_Scheikunde);
            this.Controls.Add(this.LB_Natuurkunde);
            this.Controls.Add(this.LB_Engels);
            this.Controls.Add(this.LB_Wiskunde);
            this.Name = "FRM_Home";
            this.Text = "Leerling";
            this.Load += new System.EventHandler(this.FRM_Home_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LB_Wiskunde;
        private System.Windows.Forms.ListBox LB_Engels;
        private System.Windows.Forms.ListBox LB_Natuurkunde;
        private System.Windows.Forms.ListBox LB_Scheikunde;
        private System.Windows.Forms.ListBox LB_Nederlands;
    }
}