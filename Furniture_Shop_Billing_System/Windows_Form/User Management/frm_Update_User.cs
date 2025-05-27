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


namespace Furniture_Shop_Billing_System.Windows_Form.User_Management
{
    public partial class frm_Update_User : Form
    {
        public frm_Update_User()
        {
            InitializeComponent();
        }
        private void tb_User_Role_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Content.Only_Text(e);
        }

        private void tb_User_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Content.Only_Text(e);
        }

        private void btn_Update_User_Click(object sender, EventArgs e)
        {
            Shared_Content.con_open();

            if (tb_Password.Text !="")
            {
                Shared_Content.con_open();

                SqlCommand Cmd = new SqlCommand();

                Cmd.CommandText = "Update User_Management_Details set Password ='" + tb_Password.Text + "' Where User_Role = '" + cmb_User_Role.Text + "' And User_Name = '" + cmb_UserName.Text +  "' ";
                Cmd.Connection = Shared_Content.con;

                Cmd.ExecuteNonQuery();

                Shared_Content.con_close();

                MessageBox.Show(" Updated Successfully ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please Fill All Fields ", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Shared_Content.con_close();
        }

        private void cmb_User_Role_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shared_Content.Bind_ComboBox("User_Name", cmb_UserName, "Select User_Name From User_Management_Details where User_Role = '" + cmb_User_Role.Text+"' ");
        }

        private void frm_Update_User_Load(object sender, EventArgs e)
        {
        }
    }
}
