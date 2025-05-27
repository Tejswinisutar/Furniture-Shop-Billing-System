using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Furniture_Shop_Billing_System.Windows_Form.User_Management
{
    public partial class frm_Add_User : Form
    {
        public frm_Add_User()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if(tb_UserName.Text !="" && tb_Password.Text !="" && tb_Confirm_Password.Text !="" && cmb_UserRole.Text !="")
            {
                if(tb_Password.Text == tb_Confirm_Password.Text)
                {
                    Shared_Content.con_open();

                    SqlCommand cmd = new SqlCommand("Insert Into User_Management_Details Values (@UserRole,@UserName,@Password , @stus)", Shared_Content.con);

                    cmd.Parameters.Add("@UserRole", SqlDbType.NVarChar).Value = cmb_UserRole.Text;
                    cmd.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = tb_UserName.Text;
                    cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = tb_Confirm_Password.Text;
                    cmd.Parameters.Add("@stus", SqlDbType.Bit).Value = 1;

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("User Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Shared_Content.con_close();

                    cmb_UserRole.SelectedIndex = -1;
                    tb_UserName.Clear();
                    tb_Password.Clear();
                    tb_Confirm_Password.Clear();
                }
                else
                {
                    MessageBox.Show("Password Didn't Matched", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Select All options", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmb_UserRole_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Content.Only_Text(e);
        }

        private void tb_UserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Content.Only_Text(e);
        }
    }
}
