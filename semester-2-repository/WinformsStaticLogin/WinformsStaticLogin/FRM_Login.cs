using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformsStaticLogin.DAL;
using WinformsStaticLogin.Models;

namespace WinformsStaticLogin
{
    public partial class FRM_Login : Form
    {
        public FRM_Login()
        {
            InitializeComponent();
            UpdateUserList();
            formLoaded = true;
        }

        bool formLoaded = false;

        // Objects
        Database dB = new Database();
        User user = new User();
        FRM_Reservation frm_Reservation;

        // Events
        private void BTN_Save_Click(object sender, EventArgs e)
        {
            formLoaded = false;
            dB.SendData(TB_UsernameCreate.Text, TB_InformationCreate.Text, TB_AgeCreate.Text);
            UpdateUserList();
            MessageBox.Show("Data has been saved!");
            formLoaded = true;
        }
        private void BTN_Delete_Click(object sender, EventArgs e)
        {
            formLoaded = false;
            dB.DeleteUser(TB_UsernameDelete.Text);
            UpdateUserList();
            formLoaded = true;
        }
        private void LB_Users_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!formLoaded) return;

            user.Username = dB.GetUsername(LB_Users.SelectedItem.ToString());
            frm_Reservation = new FRM_Reservation(user);
            frm_Reservation.Show();
        }
        private void BTN_Edit_Click(object sender, EventArgs e)
        {
            TB_EditUsername.Text = dB.GetUsername(TB_UserEdit.Text);
            TB_EditInformation.Text = dB.GetInformation(TB_UserEdit.Text);
            TB_EditAge.Text = dB.GetAge(TB_UserEdit.Text);
        }
        private void BTN_SaveEdit_Click(object sender, EventArgs e)
        {
            dB.UpdateUser(TB_EditUsername.Text, TB_EditInformation.Text, TB_EditAge.Text);
            MessageBox.Show("Sucessfully edited");
        }
        private void BTN_GetInfo_Click(object sender, EventArgs e)
        {
            LBL_Welcome.Text = "Welcome " + dB.GetUsername(TB_UsernameLogin.Text) + "!";
            LBL_Information.Text = "Information: " + dB.GetInformation(TB_UsernameLogin.Text);
            LBL_Age.Text = "Age: " + dB.GetAge(TB_UsernameLogin.Text);
        }

        // Methods
        void UpdateUserList()
        {
            LB_Users.DataSource = dB.GetAllUsernames();
        }
    }
}
