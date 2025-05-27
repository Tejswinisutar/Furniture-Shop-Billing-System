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

namespace Furniture_Shop_Billing_System.Windows_Form.Employee
{
    public partial class frm_Update_Employee_Details : Form
    {
        public frm_Update_Employee_Details()
        {
            InitializeComponent();
        }

        void Clear_Controls()
        {
            tb_Employee_Id.Text = "";
            tb_Employee_Name.Clear();
            tb_Designation.Clear();
            tb_Mobile_No.Clear();
            tb_Aadhar_No.Clear();
            tb_Bank_Name.Clear();
            tb_Account_No.Clear();
            tb_Note.Clear();
        }
        void Enable_Controls()
        {
            tb_Employee_Id.Enabled = true;
            tb_Employee_Name.Enabled = false;
            tb_Designation.Enabled = true;
            dtp_Date.Enabled = true;
            tb_Mobile_No.Enabled = true;
            tb_Aadhar_No.Enabled = false;
            tb_Bank_Name.Enabled = true;
            tb_Account_No.Enabled = true;
            tb_Note.Enabled = true;
        }
         
        void Disable_Controls()
        {
            tb_Employee_Id.Enabled = true;
            tb_Employee_Name.Enabled = false;
            tb_Designation.Enabled = false;
            dtp_Date.Enabled = false;
            tb_Mobile_No.Enabled = false;
            tb_Aadhar_No.Enabled = false;
            tb_Bank_Name.Enabled = false;
            tb_Account_No.Enabled = false;
            tb_Note.Enabled = false;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Shared_Content.con_open();

            SqlCommand Cmd = new SqlCommand();
            Cmd.CommandText = "Select * from Employee_Details where Employee_Id= '" + tb_Employee_Id.Text + "'";
            Cmd.Connection = Shared_Content.con;

            SqlDataReader DR = Cmd.ExecuteReader();

            if (DR.Read())
            {
                tb_Employee_Name.Text = DR.GetString(DR.GetOrdinal("Employee_Name"));
                tb_Mobile_No.Text = DR["Mobile_No"].ToString();
                tb_Designation.Text = DR.GetString(DR.GetOrdinal("Designation"));
                tb_Aadhar_No.Text = DR["Aadhar_No"].ToString();
                tb_Bank_Name.Text = DR.GetString(DR.GetOrdinal("Bank_Name"));
                tb_Account_No.Text = DR["Account_No"].ToString();
                tb_Note.Text = DR.GetString(DR.GetOrdinal("Note"));

            }
            DR.Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Shared_Content.con_open();

            if(tb_Mobile_No.Text !="" && tb_Designation.Text !="" && tb_Bank_Name.Text !="" && tb_Account_No.Text !="" )
            {
                Shared_Content.con_open();

                SqlCommand Cmd = new SqlCommand();

                Cmd.CommandText = "Update Employee_Details set Mobile_No ='" + tb_Mobile_No.Text + "', Designation ='" + tb_Designation.Text +"', Bank_Name ='" + tb_Bank_Name.Text + "', Account_No ='" + tb_Account_No.Text + "', Note ='" + tb_Note.Text +"'";
                Cmd.Connection = Shared_Content.con;

                Cmd.ExecuteNonQuery();

                Shared_Content.con_close();

                MessageBox.Show("Employee Updated Successfully ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Controls();
            }
            else 
            {
                MessageBox.Show("Please Fill All Fields ", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Shared_Content.con_close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
            Enable_Controls();
            Disable_Controls();

        }
        private void tb_Employee_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Content.Only_Text(e);
        }

        private void tb_Mobile_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Content.Only_Numeric(e);
        }

        private void tb_Designation_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Content.Only_Text(e);
        }

        private void tb_Aadhar_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Content.Only_Numeric(e);
        }

        private void tb_Account_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Content.Only_Numeric(e);
        }

        private void frm_Update_Employee_Details_Load(object sender, EventArgs e)
        {

        }
    }
}
