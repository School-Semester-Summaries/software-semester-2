
namespace SchedulesOnForms.DocentForms
{
    partial class FRM_CijfersInvoeren
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
            this.GB_Schoolvak = new System.Windows.Forms.GroupBox();
            this.BTN_Confirm = new System.Windows.Forms.Button();
            this.CB_Toets = new System.Windows.Forms.ComboBox();
            this.BTN_CijfersOpslaan = new System.Windows.Forms.Button();
            this.GB_Schoolvak.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_Schoolvak
            // 
            this.GB_Schoolvak.Controls.Add(this.BTN_Confirm);
            this.GB_Schoolvak.Controls.Add(this.CB_Toets);
            this.GB_Schoolvak.Location = new System.Drawing.Point(12, 12);
            this.GB_Schoolvak.Name = "GB_Schoolvak";
            this.GB_Schoolvak.Size = new System.Drawing.Size(134, 77);
            this.GB_Schoolvak.TabIndex = 3;
            this.GB_Schoolvak.TabStop = false;
            this.GB_Schoolvak.Text = "Toets";
            // 
            // BTN_Confirm
            // 
            this.BTN_Confirm.Location = new System.Drawing.Point(6, 48);
            this.BTN_Confirm.Name = "BTN_Confirm";
            this.BTN_Confirm.Size = new System.Drawing.Size(121, 23);
            this.BTN_Confirm.TabIndex = 4;
            this.BTN_Confirm.Text = "Confirm";
            this.BTN_Confirm.UseVisualStyleBackColor = true;
            this.BTN_Confirm.Click += new System.EventHandler(this.BTN_Confirm_Click);
            // 
            // CB_Toets
            // 
            this.CB_Toets.DisplayMember = "W";
            this.CB_Toets.FormattingEnabled = true;
            this.CB_Toets.Location = new System.Drawing.Point(6, 21);
            this.CB_Toets.Name = "CB_Toets";
            this.CB_Toets.Size = new System.Drawing.Size(121, 24);
            this.CB_Toets.TabIndex = 0;
            this.CB_Toets.Text = "Toets";
            // 
            // BTN_CijfersOpslaan
            // 
            this.BTN_CijfersOpslaan.Enabled = false;
            this.BTN_CijfersOpslaan.Location = new System.Drawing.Point(152, 19);
            this.BTN_CijfersOpslaan.Name = "BTN_CijfersOpslaan";
            this.BTN_CijfersOpslaan.Size = new System.Drawing.Size(611, 70);
            this.BTN_CijfersOpslaan.TabIndex = 5;
            this.BTN_CijfersOpslaan.Text = "Alle cijfers opslaan";
            this.BTN_CijfersOpslaan.UseVisualStyleBackColor = true;
            this.BTN_CijfersOpslaan.Click += new System.EventHandler(this.BTN_CijfersOpslaan_Click);
            // 
            // FRM_CijfersInvoeren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTN_CijfersOpslaan);
            this.Controls.Add(this.GB_Schoolvak);
            this.Name = "FRM_CijfersInvoeren";
            this.Text = "Cijfers Invoeren";
            this.Load += new System.EventHandler(this.FRM_CijfersInvoeren_Load);
            this.GB_Schoolvak.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_Schoolvak;
        private System.Windows.Forms.ComboBox CB_Toets;
        private System.Windows.Forms.Button BTN_Confirm;
        private System.Windows.Forms.Button BTN_CijfersOpslaan;
    }
}