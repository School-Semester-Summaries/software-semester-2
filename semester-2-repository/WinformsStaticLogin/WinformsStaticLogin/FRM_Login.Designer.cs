
namespace WinformsStaticLogin
{
    partial class FRM_Login
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
            this.TB_UsernameLogin = new System.Windows.Forms.TextBox();
            this.BTN_Save = new System.Windows.Forms.Button();
            this.TB_UsernameCreate = new System.Windows.Forms.TextBox();
            this.TB_InformationCreate = new System.Windows.Forms.TextBox();
            this.TB_AgeCreate = new System.Windows.Forms.TextBox();
            this.BTN_GetInfo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LBL_Username = new System.Windows.Forms.Label();
            this.LBL_Welcome = new System.Windows.Forms.Label();
            this.LBL_Information = new System.Windows.Forms.Label();
            this.LBL_Age = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LB_Users = new System.Windows.Forms.ListBox();
            this.LBL_Users = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_UsernameDelete = new System.Windows.Forms.TextBox();
            this.BTN_Delete = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_UserEdit = new System.Windows.Forms.TextBox();
            this.BTN_Edit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TB_EditUsername = new System.Windows.Forms.TextBox();
            this.TB_EditAge = new System.Windows.Forms.TextBox();
            this.TB_EditInformation = new System.Windows.Forms.TextBox();
            this.BTN_SaveEdit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // TB_UsernameLogin
            // 
            this.TB_UsernameLogin.Location = new System.Drawing.Point(9, 51);
            this.TB_UsernameLogin.Name = "TB_UsernameLogin";
            this.TB_UsernameLogin.Size = new System.Drawing.Size(94, 22);
            this.TB_UsernameLogin.TabIndex = 0;
            // 
            // BTN_Save
            // 
            this.BTN_Save.Location = new System.Drawing.Point(8, 169);
            this.BTN_Save.Name = "BTN_Save";
            this.BTN_Save.Size = new System.Drawing.Size(100, 35);
            this.BTN_Save.TabIndex = 1;
            this.BTN_Save.Text = "Save";
            this.BTN_Save.UseVisualStyleBackColor = true;
            this.BTN_Save.Click += new System.EventHandler(this.BTN_Save_Click);
            // 
            // TB_UsernameCreate
            // 
            this.TB_UsernameCreate.Location = new System.Drawing.Point(8, 51);
            this.TB_UsernameCreate.Name = "TB_UsernameCreate";
            this.TB_UsernameCreate.Size = new System.Drawing.Size(100, 22);
            this.TB_UsernameCreate.TabIndex = 2;
            // 
            // TB_InformationCreate
            // 
            this.TB_InformationCreate.Location = new System.Drawing.Point(8, 96);
            this.TB_InformationCreate.Name = "TB_InformationCreate";
            this.TB_InformationCreate.Size = new System.Drawing.Size(100, 22);
            this.TB_InformationCreate.TabIndex = 3;
            // 
            // TB_AgeCreate
            // 
            this.TB_AgeCreate.Location = new System.Drawing.Point(8, 141);
            this.TB_AgeCreate.Name = "TB_AgeCreate";
            this.TB_AgeCreate.Size = new System.Drawing.Size(100, 22);
            this.TB_AgeCreate.TabIndex = 4;
            // 
            // BTN_GetInfo
            // 
            this.BTN_GetInfo.Location = new System.Drawing.Point(9, 79);
            this.BTN_GetInfo.Name = "BTN_GetInfo";
            this.BTN_GetInfo.Size = new System.Drawing.Size(94, 35);
            this.BTN_GetInfo.TabIndex = 5;
            this.BTN_GetInfo.Text = "Get info";
            this.BTN_GetInfo.UseVisualStyleBackColor = true;
            this.BTN_GetInfo.Click += new System.EventHandler(this.BTN_GetInfo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TB_UsernameCreate);
            this.groupBox1.Controls.Add(this.BTN_Save);
            this.groupBox1.Controls.Add(this.TB_AgeCreate);
            this.groupBox1.Controls.Add(this.TB_InformationCreate);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(114, 214);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Username";
            // 
            // LBL_Username
            // 
            this.LBL_Username.AutoSize = true;
            this.LBL_Username.Location = new System.Drawing.Point(6, 31);
            this.LBL_Username.Name = "LBL_Username";
            this.LBL_Username.Size = new System.Drawing.Size(73, 17);
            this.LBL_Username.TabIndex = 10;
            this.LBL_Username.Text = "Username";
            // 
            // LBL_Welcome
            // 
            this.LBL_Welcome.AutoSize = true;
            this.LBL_Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.LBL_Welcome.Location = new System.Drawing.Point(125, 18);
            this.LBL_Welcome.Name = "LBL_Welcome";
            this.LBL_Welcome.Size = new System.Drawing.Size(0, 54);
            this.LBL_Welcome.TabIndex = 11;
            // 
            // LBL_Information
            // 
            this.LBL_Information.AutoSize = true;
            this.LBL_Information.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.LBL_Information.Location = new System.Drawing.Point(132, 72);
            this.LBL_Information.Name = "LBL_Information";
            this.LBL_Information.Size = new System.Drawing.Size(0, 36);
            this.LBL_Information.TabIndex = 12;
            // 
            // LBL_Age
            // 
            this.LBL_Age.AutoSize = true;
            this.LBL_Age.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.LBL_Age.Location = new System.Drawing.Point(132, 108);
            this.LBL_Age.Name = "LBL_Age";
            this.LBL_Age.Size = new System.Drawing.Size(0, 36);
            this.LBL_Age.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BTN_GetInfo);
            this.groupBox2.Controls.Add(this.LBL_Age);
            this.groupBox2.Controls.Add(this.LBL_Username);
            this.groupBox2.Controls.Add(this.LBL_Information);
            this.groupBox2.Controls.Add(this.TB_UsernameLogin);
            this.groupBox2.Controls.Add(this.LBL_Welcome);
            this.groupBox2.Location = new System.Drawing.Point(555, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(741, 214);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User Information";
            // 
            // LB_Users
            // 
            this.LB_Users.FormattingEnabled = true;
            this.LB_Users.ItemHeight = 16;
            this.LB_Users.Location = new System.Drawing.Point(12, 254);
            this.LB_Users.Name = "LB_Users";
            this.LB_Users.Size = new System.Drawing.Size(1284, 404);
            this.LB_Users.TabIndex = 11;
            this.LB_Users.SelectedIndexChanged += new System.EventHandler(this.LB_Users_SelectedIndexChanged);
            // 
            // LBL_Users
            // 
            this.LBL_Users.AutoSize = true;
            this.LBL_Users.Location = new System.Drawing.Point(9, 234);
            this.LBL_Users.Name = "LBL_Users";
            this.LBL_Users.Size = new System.Drawing.Size(64, 17);
            this.LBL_Users.TabIndex = 10;
            this.LBL_Users.Text = "All Users";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.TB_UsernameDelete);
            this.groupBox3.Controls.Add(this.BTN_Delete);
            this.groupBox3.Location = new System.Drawing.Point(142, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(114, 214);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Delete User";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Username";
            // 
            // TB_UsernameDelete
            // 
            this.TB_UsernameDelete.Location = new System.Drawing.Point(6, 51);
            this.TB_UsernameDelete.Name = "TB_UsernameDelete";
            this.TB_UsernameDelete.Size = new System.Drawing.Size(100, 22);
            this.TB_UsernameDelete.TabIndex = 2;
            // 
            // BTN_Delete
            // 
            this.BTN_Delete.Location = new System.Drawing.Point(6, 79);
            this.BTN_Delete.Name = "BTN_Delete";
            this.BTN_Delete.Size = new System.Drawing.Size(100, 35);
            this.BTN_Delete.TabIndex = 1;
            this.BTN_Delete.Text = "Delete";
            this.BTN_Delete.UseVisualStyleBackColor = true;
            this.BTN_Delete.Click += new System.EventHandler(this.BTN_Delete_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BTN_SaveEdit);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.TB_UserEdit);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.TB_EditUsername);
            this.groupBox4.Controls.Add(this.BTN_Edit);
            this.groupBox4.Controls.Add(this.TB_EditAge);
            this.groupBox4.Controls.Add(this.TB_EditInformation);
            this.groupBox4.Location = new System.Drawing.Point(274, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(263, 214);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Edit User";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Username";
            // 
            // TB_UserEdit
            // 
            this.TB_UserEdit.Location = new System.Drawing.Point(6, 51);
            this.TB_UserEdit.Name = "TB_UserEdit";
            this.TB_UserEdit.Size = new System.Drawing.Size(100, 22);
            this.TB_UserEdit.TabIndex = 2;
            // 
            // BTN_Edit
            // 
            this.BTN_Edit.Location = new System.Drawing.Point(6, 79);
            this.BTN_Edit.Name = "BTN_Edit";
            this.BTN_Edit.Size = new System.Drawing.Size(100, 35);
            this.BTN_Edit.TabIndex = 1;
            this.BTN_Edit.Text = "Edit";
            this.BTN_Edit.UseVisualStyleBackColor = true;
            this.BTN_Edit.Click += new System.EventHandler(this.BTN_Edit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Age";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(148, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Information";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(148, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Username";
            // 
            // TB_EditUsername
            // 
            this.TB_EditUsername.Location = new System.Drawing.Point(148, 51);
            this.TB_EditUsername.Name = "TB_EditUsername";
            this.TB_EditUsername.Size = new System.Drawing.Size(100, 22);
            this.TB_EditUsername.TabIndex = 10;
            // 
            // TB_EditAge
            // 
            this.TB_EditAge.Location = new System.Drawing.Point(148, 141);
            this.TB_EditAge.Name = "TB_EditAge";
            this.TB_EditAge.Size = new System.Drawing.Size(100, 22);
            this.TB_EditAge.TabIndex = 12;
            // 
            // TB_EditInformation
            // 
            this.TB_EditInformation.Location = new System.Drawing.Point(148, 96);
            this.TB_EditInformation.Name = "TB_EditInformation";
            this.TB_EditInformation.Size = new System.Drawing.Size(100, 22);
            this.TB_EditInformation.TabIndex = 11;
            // 
            // BTN_SaveEdit
            // 
            this.BTN_SaveEdit.Location = new System.Drawing.Point(148, 169);
            this.BTN_SaveEdit.Name = "BTN_SaveEdit";
            this.BTN_SaveEdit.Size = new System.Drawing.Size(100, 35);
            this.BTN_SaveEdit.TabIndex = 16;
            this.BTN_SaveEdit.Text = "Save";
            this.BTN_SaveEdit.UseVisualStyleBackColor = true;
            this.BTN_SaveEdit.Click += new System.EventHandler(this.BTN_SaveEdit_Click);
            // 
            // FRM_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 663);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.LBL_Users);
            this.Controls.Add(this.LB_Users);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FRM_Login";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_UsernameLogin;
        private System.Windows.Forms.Button BTN_Save;
        private System.Windows.Forms.TextBox TB_UsernameCreate;
        private System.Windows.Forms.TextBox TB_InformationCreate;
        private System.Windows.Forms.TextBox TB_AgeCreate;
        private System.Windows.Forms.Button BTN_GetInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LBL_Username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBL_Welcome;
        private System.Windows.Forms.Label LBL_Information;
        private System.Windows.Forms.Label LBL_Age;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox LB_Users;
        private System.Windows.Forms.Label LBL_Users;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_UsernameDelete;
        private System.Windows.Forms.Button BTN_Delete;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BTN_SaveEdit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TB_UserEdit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TB_EditUsername;
        private System.Windows.Forms.Button BTN_Edit;
        private System.Windows.Forms.TextBox TB_EditAge;
        private System.Windows.Forms.TextBox TB_EditInformation;
    }
}

