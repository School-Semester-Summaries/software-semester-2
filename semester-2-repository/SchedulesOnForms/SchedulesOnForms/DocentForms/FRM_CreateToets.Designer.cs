
namespace SchedulesOnForms.DocentForms
{
    partial class FRM_CreateToets
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
            this.CB_Schoolvak = new System.Windows.Forms.ComboBox();
            this.GB_Schoolvak = new System.Windows.Forms.GroupBox();
            this.GB_Weging = new System.Windows.Forms.GroupBox();
            this.NUD_Weging = new System.Windows.Forms.NumericUpDown();
            this.GB_Naam = new System.Windows.Forms.GroupBox();
            this.TB_ToetsNaam = new System.Windows.Forms.TextBox();
            this.BTN_Create = new System.Windows.Forms.Button();
            this.LB_Toetsen = new System.Windows.Forms.ListBox();
            this.GB_Schoolvak.SuspendLayout();
            this.GB_Weging.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Weging)).BeginInit();
            this.GB_Naam.SuspendLayout();
            this.SuspendLayout();
            // 
            // CB_Schoolvak
            // 
            this.CB_Schoolvak.DisplayMember = "W";
            this.CB_Schoolvak.FormattingEnabled = true;
            this.CB_Schoolvak.Location = new System.Drawing.Point(6, 21);
            this.CB_Schoolvak.Name = "CB_Schoolvak";
            this.CB_Schoolvak.Size = new System.Drawing.Size(121, 24);
            this.CB_Schoolvak.TabIndex = 0;
            this.CB_Schoolvak.Text = "Schoolvak";
            this.CB_Schoolvak.SelectedIndexChanged += new System.EventHandler(this.CB_Schoolvak_SelectedIndexChanged);
            // 
            // GB_Schoolvak
            // 
            this.GB_Schoolvak.Controls.Add(this.CB_Schoolvak);
            this.GB_Schoolvak.Location = new System.Drawing.Point(12, 12);
            this.GB_Schoolvak.Name = "GB_Schoolvak";
            this.GB_Schoolvak.Size = new System.Drawing.Size(134, 54);
            this.GB_Schoolvak.TabIndex = 2;
            this.GB_Schoolvak.TabStop = false;
            this.GB_Schoolvak.Text = "Schoolvak";
            // 
            // GB_Weging
            // 
            this.GB_Weging.Controls.Add(this.NUD_Weging);
            this.GB_Weging.Enabled = false;
            this.GB_Weging.Location = new System.Drawing.Point(12, 72);
            this.GB_Weging.Name = "GB_Weging";
            this.GB_Weging.Size = new System.Drawing.Size(134, 54);
            this.GB_Weging.TabIndex = 3;
            this.GB_Weging.TabStop = false;
            this.GB_Weging.Text = "Weging";
            // 
            // NUD_Weging
            // 
            this.NUD_Weging.Location = new System.Drawing.Point(6, 21);
            this.NUD_Weging.Name = "NUD_Weging";
            this.NUD_Weging.Size = new System.Drawing.Size(120, 22);
            this.NUD_Weging.TabIndex = 4;
            this.NUD_Weging.ValueChanged += new System.EventHandler(this.NUD_Weging_ValueChanged);
            // 
            // GB_Naam
            // 
            this.GB_Naam.Controls.Add(this.TB_ToetsNaam);
            this.GB_Naam.Enabled = false;
            this.GB_Naam.Location = new System.Drawing.Point(12, 132);
            this.GB_Naam.Name = "GB_Naam";
            this.GB_Naam.Size = new System.Drawing.Size(134, 54);
            this.GB_Naam.TabIndex = 5;
            this.GB_Naam.TabStop = false;
            this.GB_Naam.Text = "Naam";
            // 
            // TB_ToetsNaam
            // 
            this.TB_ToetsNaam.Location = new System.Drawing.Point(6, 23);
            this.TB_ToetsNaam.Name = "TB_ToetsNaam";
            this.TB_ToetsNaam.Size = new System.Drawing.Size(122, 22);
            this.TB_ToetsNaam.TabIndex = 0;
            this.TB_ToetsNaam.TextChanged += new System.EventHandler(this.TB_ToetsNaam_TextChanged);
            // 
            // BTN_Create
            // 
            this.BTN_Create.Enabled = false;
            this.BTN_Create.Location = new System.Drawing.Point(12, 192);
            this.BTN_Create.Name = "BTN_Create";
            this.BTN_Create.Size = new System.Drawing.Size(134, 30);
            this.BTN_Create.TabIndex = 6;
            this.BTN_Create.Text = "Create";
            this.BTN_Create.UseVisualStyleBackColor = true;
            this.BTN_Create.Click += new System.EventHandler(this.BTN_Create_Click);
            // 
            // LB_Toetsen
            // 
            this.LB_Toetsen.FormattingEnabled = true;
            this.LB_Toetsen.ItemHeight = 16;
            this.LB_Toetsen.Location = new System.Drawing.Point(152, 12);
            this.LB_Toetsen.Name = "LB_Toetsen";
            this.LB_Toetsen.Size = new System.Drawing.Size(134, 212);
            this.LB_Toetsen.TabIndex = 7;
            // 
            // FRM_CreateToets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 238);
            this.Controls.Add(this.LB_Toetsen);
            this.Controls.Add(this.BTN_Create);
            this.Controls.Add(this.GB_Naam);
            this.Controls.Add(this.GB_Weging);
            this.Controls.Add(this.GB_Schoolvak);
            this.Name = "FRM_CreateToets";
            this.Text = "Toets Aanmaken";
            this.Load += new System.EventHandler(this.FRM_CreateToets_Load);
            this.GB_Schoolvak.ResumeLayout(false);
            this.GB_Weging.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Weging)).EndInit();
            this.GB_Naam.ResumeLayout(false);
            this.GB_Naam.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_Schoolvak;
        private System.Windows.Forms.GroupBox GB_Schoolvak;
        private System.Windows.Forms.GroupBox GB_Weging;
        private System.Windows.Forms.NumericUpDown NUD_Weging;
        private System.Windows.Forms.GroupBox GB_Naam;
        private System.Windows.Forms.TextBox TB_ToetsNaam;
        private System.Windows.Forms.Button BTN_Create;
        private System.Windows.Forms.ListBox LB_Toetsen;
    }
}