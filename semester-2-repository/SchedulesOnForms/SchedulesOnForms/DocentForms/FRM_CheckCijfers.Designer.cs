
namespace SchedulesOnForms.DocentForms
{
    partial class FRM_CheckCijfers
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
            this.LB_Nederlands = new System.Windows.Forms.ListBox();
            this.LB_Scheikunde = new System.Windows.Forms.ListBox();
            this.LB_Natuurkunde = new System.Windows.Forms.ListBox();
            this.LB_Engels = new System.Windows.Forms.ListBox();
            this.LB_Wiskunde = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_Leerlingen = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LB_Nederlands
            // 
            this.LB_Nederlands.FormattingEnabled = true;
            this.LB_Nederlands.ItemHeight = 16;
            this.LB_Nederlands.Location = new System.Drawing.Point(517, 25);
            this.LB_Nederlands.Name = "LB_Nederlands";
            this.LB_Nederlands.Size = new System.Drawing.Size(120, 420);
            this.LB_Nederlands.TabIndex = 16;
            // 
            // LB_Scheikunde
            // 
            this.LB_Scheikunde.FormattingEnabled = true;
            this.LB_Scheikunde.ItemHeight = 16;
            this.LB_Scheikunde.Location = new System.Drawing.Point(391, 25);
            this.LB_Scheikunde.Name = "LB_Scheikunde";
            this.LB_Scheikunde.Size = new System.Drawing.Size(120, 420);
            this.LB_Scheikunde.TabIndex = 15;
            // 
            // LB_Natuurkunde
            // 
            this.LB_Natuurkunde.FormattingEnabled = true;
            this.LB_Natuurkunde.ItemHeight = 16;
            this.LB_Natuurkunde.Location = new System.Drawing.Point(265, 25);
            this.LB_Natuurkunde.Name = "LB_Natuurkunde";
            this.LB_Natuurkunde.Size = new System.Drawing.Size(120, 420);
            this.LB_Natuurkunde.TabIndex = 14;
            // 
            // LB_Engels
            // 
            this.LB_Engels.FormattingEnabled = true;
            this.LB_Engels.ItemHeight = 16;
            this.LB_Engels.Location = new System.Drawing.Point(643, 25);
            this.LB_Engels.Name = "LB_Engels";
            this.LB_Engels.Size = new System.Drawing.Size(120, 420);
            this.LB_Engels.TabIndex = 13;
            // 
            // LB_Wiskunde
            // 
            this.LB_Wiskunde.FormattingEnabled = true;
            this.LB_Wiskunde.ItemHeight = 16;
            this.LB_Wiskunde.Location = new System.Drawing.Point(139, 25);
            this.LB_Wiskunde.Name = "LB_Wiskunde";
            this.LB_Wiskunde.Size = new System.Drawing.Size(120, 420);
            this.LB_Wiskunde.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Leerling";
            // 
            // CB_Leerlingen
            // 
            this.CB_Leerlingen.FormattingEnabled = true;
            this.CB_Leerlingen.Location = new System.Drawing.Point(12, 25);
            this.CB_Leerlingen.Name = "CB_Leerlingen";
            this.CB_Leerlingen.Size = new System.Drawing.Size(121, 24);
            this.CB_Leerlingen.TabIndex = 10;
            this.CB_Leerlingen.Text = "Leerling";
            this.CB_Leerlingen.SelectedIndexChanged += new System.EventHandler(this.CB_Leerlingen_SelectedIndexChanged);
            // 
            // FRM_CheckCijfers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LB_Nederlands);
            this.Controls.Add(this.LB_Scheikunde);
            this.Controls.Add(this.LB_Natuurkunde);
            this.Controls.Add(this.LB_Engels);
            this.Controls.Add(this.LB_Wiskunde);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_Leerlingen);
            this.Name = "FRM_CheckCijfers";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FRM_CheckCijfers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LB_Nederlands;
        private System.Windows.Forms.ListBox LB_Scheikunde;
        private System.Windows.Forms.ListBox LB_Natuurkunde;
        private System.Windows.Forms.ListBox LB_Engels;
        private System.Windows.Forms.ListBox LB_Wiskunde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_Leerlingen;
    }
}