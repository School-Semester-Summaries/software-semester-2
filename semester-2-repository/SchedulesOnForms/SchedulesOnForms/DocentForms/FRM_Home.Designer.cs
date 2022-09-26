
namespace SchedulesOnForms.DocentForms
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
            this.BTN_CreateToets = new System.Windows.Forms.Button();
            this.BTN_CheckCijfers = new System.Windows.Forms.Button();
            this.BTN_CijfersInvoeren = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_CreateToets
            // 
            this.BTN_CreateToets.Location = new System.Drawing.Point(12, 52);
            this.BTN_CreateToets.Name = "BTN_CreateToets";
            this.BTN_CreateToets.Size = new System.Drawing.Size(134, 34);
            this.BTN_CreateToets.TabIndex = 0;
            this.BTN_CreateToets.Text = "Toets Aanmaken";
            this.BTN_CreateToets.UseVisualStyleBackColor = true;
            this.BTN_CreateToets.Click += new System.EventHandler(this.BTN_CreateToets_Click);
            // 
            // BTN_CheckCijfers
            // 
            this.BTN_CheckCijfers.Location = new System.Drawing.Point(12, 12);
            this.BTN_CheckCijfers.Name = "BTN_CheckCijfers";
            this.BTN_CheckCijfers.Size = new System.Drawing.Size(134, 34);
            this.BTN_CheckCijfers.TabIndex = 1;
            this.BTN_CheckCijfers.Text = "Check Cijfers";
            this.BTN_CheckCijfers.UseVisualStyleBackColor = true;
            this.BTN_CheckCijfers.Click += new System.EventHandler(this.BTN_CheckCijfers_Click);
            // 
            // BTN_CijfersInvoeren
            // 
            this.BTN_CijfersInvoeren.Location = new System.Drawing.Point(12, 92);
            this.BTN_CijfersInvoeren.Name = "BTN_CijfersInvoeren";
            this.BTN_CijfersInvoeren.Size = new System.Drawing.Size(134, 34);
            this.BTN_CijfersInvoeren.TabIndex = 2;
            this.BTN_CijfersInvoeren.Text = "Cijfers Invoeren";
            this.BTN_CijfersInvoeren.UseVisualStyleBackColor = true;
            this.BTN_CijfersInvoeren.Click += new System.EventHandler(this.BTN_CijfersInvoeren_Click);
            // 
            // FRM_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 459);
            this.Controls.Add(this.BTN_CijfersInvoeren);
            this.Controls.Add(this.BTN_CheckCijfers);
            this.Controls.Add(this.BTN_CreateToets);
            this.Name = "FRM_Home";
            this.Text = "Docent";
            this.Load += new System.EventHandler(this.FRM_Home_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_CreateToets;
        private System.Windows.Forms.Button BTN_CheckCijfers;
        private System.Windows.Forms.Button BTN_CijfersInvoeren;
    }
}