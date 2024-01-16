
namespace CircusTrein
{
    partial class FRM_CircusTrein
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
            this.RB_Small = new System.Windows.Forms.RadioButton();
            this.RB_Medium = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RB_Big = new System.Windows.Forms.RadioButton();
            this.RB_Herbivore = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RB_Carnivore = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GB_AnimalInventory = new System.Windows.Forms.GroupBox();
            this.BTN_ClassifyAnimals = new System.Windows.Forms.Button();
            this.TB_SmallHerbivore = new System.Windows.Forms.TextBox();
            this.TB_MediumHerbivore = new System.Windows.Forms.TextBox();
            this.TB_BigHerbivore = new System.Windows.Forms.TextBox();
            this.TB_SmallCarnivore = new System.Windows.Forms.TextBox();
            this.TB_MediumCarnivore = new System.Windows.Forms.TextBox();
            this.TB_BigCarnivore = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NUD_AnimalMultiplier = new System.Windows.Forms.NumericUpDown();
            this.GB_AddAnimals = new System.Windows.Forms.GroupBox();
            this.BTN_AddAnimal = new System.Windows.Forms.Button();
            this.LB_Wagons = new System.Windows.Forms.ListBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.GB_AnimalInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_AnimalMultiplier)).BeginInit();
            this.GB_AddAnimals.SuspendLayout();
            this.SuspendLayout();
            // 
            // RB_Small
            // 
            this.RB_Small.AutoSize = true;
            this.RB_Small.Location = new System.Drawing.Point(6, 60);
            this.RB_Small.Name = "RB_Small";
            this.RB_Small.Size = new System.Drawing.Size(60, 21);
            this.RB_Small.TabIndex = 9;
            this.RB_Small.TabStop = true;
            this.RB_Small.Text = "Klein";
            this.RB_Small.UseVisualStyleBackColor = true;
            // 
            // RB_Medium
            // 
            this.RB_Medium.AutoSize = true;
            this.RB_Medium.Location = new System.Drawing.Point(6, 41);
            this.RB_Medium.Name = "RB_Medium";
            this.RB_Medium.Size = new System.Drawing.Size(78, 21);
            this.RB_Medium.TabIndex = 8;
            this.RB_Medium.TabStop = true;
            this.RB_Medium.Text = "Medium";
            this.RB_Medium.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RB_Small);
            this.groupBox3.Controls.Add(this.RB_Medium);
            this.groupBox3.Controls.Add(this.RB_Big);
            this.groupBox3.Location = new System.Drawing.Point(6, 140);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(188, 86);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Formaat";
            // 
            // RB_Big
            // 
            this.RB_Big.AutoSize = true;
            this.RB_Big.Location = new System.Drawing.Point(6, 22);
            this.RB_Big.Name = "RB_Big";
            this.RB_Big.Size = new System.Drawing.Size(65, 21);
            this.RB_Big.TabIndex = 7;
            this.RB_Big.TabStop = true;
            this.RB_Big.Text = "Groot";
            this.RB_Big.UseVisualStyleBackColor = true;
            // 
            // RB_Herbivore
            // 
            this.RB_Herbivore.AutoSize = true;
            this.RB_Herbivore.Location = new System.Drawing.Point(6, 39);
            this.RB_Herbivore.Name = "RB_Herbivore";
            this.RB_Herbivore.Size = new System.Drawing.Size(77, 21);
            this.RB_Herbivore.TabIndex = 8;
            this.RB_Herbivore.TabStop = true;
            this.RB_Herbivore.Text = "Planten";
            this.RB_Herbivore.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RB_Herbivore);
            this.groupBox2.Controls.Add(this.RB_Carnivore);
            this.groupBox2.Location = new System.Drawing.Point(6, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(188, 71);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Voedsel Voorkeur";
            // 
            // RB_Carnivore
            // 
            this.RB_Carnivore.AutoSize = true;
            this.RB_Carnivore.Location = new System.Drawing.Point(6, 20);
            this.RB_Carnivore.Name = "RB_Carnivore";
            this.RB_Carnivore.Size = new System.Drawing.Size(64, 21);
            this.RB_Carnivore.TabIndex = 7;
            this.RB_Carnivore.TabStop = true;
            this.RB_Carnivore.Text = "Vlees";
            this.RB_Carnivore.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Kleine Planteneters:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Medium Planteneters:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Grote Planteneters:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Medium Vleeseters:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Grote Vleeseters:";
            // 
            // GB_AnimalInventory
            // 
            this.GB_AnimalInventory.Controls.Add(this.BTN_ClassifyAnimals);
            this.GB_AnimalInventory.Controls.Add(this.TB_SmallHerbivore);
            this.GB_AnimalInventory.Controls.Add(this.TB_MediumHerbivore);
            this.GB_AnimalInventory.Controls.Add(this.TB_BigHerbivore);
            this.GB_AnimalInventory.Controls.Add(this.TB_SmallCarnivore);
            this.GB_AnimalInventory.Controls.Add(this.TB_MediumCarnivore);
            this.GB_AnimalInventory.Controls.Add(this.TB_BigCarnivore);
            this.GB_AnimalInventory.Controls.Add(this.label5);
            this.GB_AnimalInventory.Controls.Add(this.label6);
            this.GB_AnimalInventory.Controls.Add(this.label7);
            this.GB_AnimalInventory.Controls.Add(this.label4);
            this.GB_AnimalInventory.Controls.Add(this.label3);
            this.GB_AnimalInventory.Controls.Add(this.label2);
            this.GB_AnimalInventory.Location = new System.Drawing.Point(12, 284);
            this.GB_AnimalInventory.Name = "GB_AnimalInventory";
            this.GB_AnimalInventory.Size = new System.Drawing.Size(200, 266);
            this.GB_AnimalInventory.TabIndex = 11;
            this.GB_AnimalInventory.TabStop = false;
            this.GB_AnimalInventory.Text = "Dieren inventarisatie";
            // 
            // BTN_ClassifyAnimals
            // 
            this.BTN_ClassifyAnimals.Location = new System.Drawing.Point(6, 232);
            this.BTN_ClassifyAnimals.Name = "BTN_ClassifyAnimals";
            this.BTN_ClassifyAnimals.Size = new System.Drawing.Size(188, 28);
            this.BTN_ClassifyAnimals.TabIndex = 11;
            this.BTN_ClassifyAnimals.Text = "Dieren indelen";
            this.BTN_ClassifyAnimals.UseVisualStyleBackColor = true;
            this.BTN_ClassifyAnimals.Click += new System.EventHandler(this.BTN_ClassifyAnimals_Click);
            // 
            // TB_SmallHerbivore
            // 
            this.TB_SmallHerbivore.Location = new System.Drawing.Point(160, 190);
            this.TB_SmallHerbivore.Name = "TB_SmallHerbivore";
            this.TB_SmallHerbivore.ReadOnly = true;
            this.TB_SmallHerbivore.Size = new System.Drawing.Size(34, 22);
            this.TB_SmallHerbivore.TabIndex = 18;
            this.TB_SmallHerbivore.Text = "0";
            // 
            // TB_MediumHerbivore
            // 
            this.TB_MediumHerbivore.Location = new System.Drawing.Point(160, 162);
            this.TB_MediumHerbivore.Name = "TB_MediumHerbivore";
            this.TB_MediumHerbivore.ReadOnly = true;
            this.TB_MediumHerbivore.Size = new System.Drawing.Size(34, 22);
            this.TB_MediumHerbivore.TabIndex = 17;
            this.TB_MediumHerbivore.Text = "0";
            // 
            // TB_BigHerbivore
            // 
            this.TB_BigHerbivore.Location = new System.Drawing.Point(160, 134);
            this.TB_BigHerbivore.Name = "TB_BigHerbivore";
            this.TB_BigHerbivore.ReadOnly = true;
            this.TB_BigHerbivore.Size = new System.Drawing.Size(34, 22);
            this.TB_BigHerbivore.TabIndex = 16;
            this.TB_BigHerbivore.Text = "0";
            // 
            // TB_SmallCarnivore
            // 
            this.TB_SmallCarnivore.Location = new System.Drawing.Point(163, 84);
            this.TB_SmallCarnivore.Name = "TB_SmallCarnivore";
            this.TB_SmallCarnivore.ReadOnly = true;
            this.TB_SmallCarnivore.Size = new System.Drawing.Size(34, 22);
            this.TB_SmallCarnivore.TabIndex = 15;
            this.TB_SmallCarnivore.Text = "0";
            // 
            // TB_MediumCarnivore
            // 
            this.TB_MediumCarnivore.Location = new System.Drawing.Point(163, 56);
            this.TB_MediumCarnivore.Name = "TB_MediumCarnivore";
            this.TB_MediumCarnivore.ReadOnly = true;
            this.TB_MediumCarnivore.Size = new System.Drawing.Size(34, 22);
            this.TB_MediumCarnivore.TabIndex = 14;
            this.TB_MediumCarnivore.Text = "0";
            // 
            // TB_BigCarnivore
            // 
            this.TB_BigCarnivore.Location = new System.Drawing.Point(163, 28);
            this.TB_BigCarnivore.Name = "TB_BigCarnivore";
            this.TB_BigCarnivore.ReadOnly = true;
            this.TB_BigCarnivore.Size = new System.Drawing.Size(34, 22);
            this.TB_BigCarnivore.TabIndex = 13;
            this.TB_BigCarnivore.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kleine Vleeseters:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Aantal:";
            // 
            // NUD_AnimalMultiplier
            // 
            this.NUD_AnimalMultiplier.Location = new System.Drawing.Point(6, 38);
            this.NUD_AnimalMultiplier.Name = "NUD_AnimalMultiplier";
            this.NUD_AnimalMultiplier.Size = new System.Drawing.Size(188, 22);
            this.NUD_AnimalMultiplier.TabIndex = 4;
            // 
            // GB_AddAnimals
            // 
            this.GB_AddAnimals.Controls.Add(this.BTN_AddAnimal);
            this.GB_AddAnimals.Controls.Add(this.groupBox3);
            this.GB_AddAnimals.Controls.Add(this.groupBox2);
            this.GB_AddAnimals.Controls.Add(this.label1);
            this.GB_AddAnimals.Controls.Add(this.NUD_AnimalMultiplier);
            this.GB_AddAnimals.Location = new System.Drawing.Point(12, 12);
            this.GB_AddAnimals.Name = "GB_AddAnimals";
            this.GB_AddAnimals.Size = new System.Drawing.Size(200, 266);
            this.GB_AddAnimals.TabIndex = 12;
            this.GB_AddAnimals.TabStop = false;
            this.GB_AddAnimals.Text = "Dieren toevoegen";
            // 
            // BTN_AddAnimal
            // 
            this.BTN_AddAnimal.Location = new System.Drawing.Point(6, 232);
            this.BTN_AddAnimal.Name = "BTN_AddAnimal";
            this.BTN_AddAnimal.Size = new System.Drawing.Size(188, 28);
            this.BTN_AddAnimal.TabIndex = 10;
            this.BTN_AddAnimal.Text = "Dieren toevoegen";
            this.BTN_AddAnimal.UseVisualStyleBackColor = true;
            this.BTN_AddAnimal.Click += new System.EventHandler(this.BTN_AddAnimal_Click);
            // 
            // LB_Wagons
            // 
            this.LB_Wagons.FormattingEnabled = true;
            this.LB_Wagons.ItemHeight = 16;
            this.LB_Wagons.Location = new System.Drawing.Point(218, 18);
            this.LB_Wagons.Name = "LB_Wagons";
            this.LB_Wagons.Size = new System.Drawing.Size(200, 532);
            this.LB_Wagons.TabIndex = 13;
            // 
            // FRM_CircusTrein
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 559);
            this.Controls.Add(this.LB_Wagons);
            this.Controls.Add(this.GB_AnimalInventory);
            this.Controls.Add(this.GB_AddAnimals);
            this.Name = "FRM_CircusTrein";
            this.Text = "CircusTrein";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.GB_AnimalInventory.ResumeLayout(false);
            this.GB_AnimalInventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_AnimalMultiplier)).EndInit();
            this.GB_AddAnimals.ResumeLayout(false);
            this.GB_AddAnimals.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton RB_Small;
        private System.Windows.Forms.RadioButton RB_Medium;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton RB_Big;
        private System.Windows.Forms.RadioButton RB_Herbivore;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RB_Carnivore;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox GB_AnimalInventory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NUD_AnimalMultiplier;
        private System.Windows.Forms.GroupBox GB_AddAnimals;
        private System.Windows.Forms.Button BTN_AddAnimal;
        private System.Windows.Forms.TextBox TB_SmallHerbivore;
        private System.Windows.Forms.TextBox TB_MediumHerbivore;
        private System.Windows.Forms.TextBox TB_BigHerbivore;
        private System.Windows.Forms.TextBox TB_SmallCarnivore;
        private System.Windows.Forms.TextBox TB_MediumCarnivore;
        private System.Windows.Forms.TextBox TB_BigCarnivore;
        private System.Windows.Forms.Button BTN_ClassifyAnimals;
        private System.Windows.Forms.ListBox LB_Wagons;
    }
}

