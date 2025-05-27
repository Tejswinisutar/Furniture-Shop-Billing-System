using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Linq;
using System.Data.SqlClient;

namespace Furniture_Shop_Billing_System
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }
        private void frm_Login_Load(object sender, EventArgs e)
        {
            cmb_User_Role.SelectedIndex = -1;
            cmb_User_Name.SelectedIndex = -1;
            tb_Password.Focus();
        }
        private void cmb_User_Role_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shared_Content.Bind_ComboBox("User_Name", cmb_User_Name, "Select User_Name from User_Management_Details where User_Role = '" + cmb_User_Role.Text + "'");
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            Shared_Content.con_open();

            SqlCommand Cmd = new SqlCommand("Select Count(*) from User_Management_Details where User_Role = '" + cmb_User_Role.Text + "' And User_Name = '" + cmb_User_Name.Text + "' And Password = '" + tb_Password.Text + "'  ", Shared_Content.con);

            int Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            if (Cnt > 0)
            {
                MessageBox.Show("WELCOME To Furniture Shop App", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (cmb_User_Role.SelectedIndex == 0)
                {
                    Shared_Content.UserRole = 1;
                }
                else if (cmb_User_Role.SelectedIndex == 1)
                {
                    Shared_Content.UserRole = 2;
                }
                else if (cmb_User_Role.SelectedIndex == 2)
                {
                    Shared_Content.UserRole = 3;
                }
                else if (cmb_User_Role.SelectedIndex == 3)
                {
                    Shared_Content.UserRole = 4;
                }

                Shared_Content.LoggedInUname = cmb_User_Name.Text;
                frm_Main_Form Obj = new frm_Main_Form();
                Obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect User Credentials!!!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            cmb_User_Name.SelectedIndex = -1;
            tb_Password.Text = "";
            cmb_User_Role.SelectedIndex = 0;
            cmb_User_Role.Focus();

            Shared_Content.con_close();
        }

        private void lbl_Furniture_Click(object sender, EventArgs e)
        {

        }
    }
}
