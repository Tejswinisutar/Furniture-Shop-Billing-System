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

namespace Furniture_Shop_Billing_System.Windows_Form.Suppiler
{
    public partial class frm_Update_Supplier_Details : Form
    {
        public frm_Update_Supplier_Details()
        {
            InitializeComponent();
        }
        void Clear_Controls()
        {
            tb_Supplier_Id.Clear();
            tb_Supplier_Company.Clear();
            tb_Supplier_Name.Clear();
            tb_Mobile_No.Clear();
            tb_Aadhar_No.Clear();
            tb_Bank_Name.Clear();
            dtp_Date.ResetText();
            tb_Note.Clear();
            tb_Account_No.Clear();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Shared_Content.con_open();

            SqlCommand Cmd = new SqlCommand();
            Cmd.CommandText = "Select * from Supplier_Details where Supplier_Id='" + tb_Supplier_Id.Text + "'";
            Cmd.Connection = Shared_Content.con;

            SqlDataReader DR = Cmd.ExecuteReader();

            if (DR.Read())
            {
                tb_Supplier_Name.Text = DR.GetString(DR.GetOrdinal("Supplier_Name"));
                tb_Aadhar_No.Text = DR["Aadhar_No"].ToString();
                tb_Mobile_No.Text = DR["Mobile_No"].ToString();
                tb_Supplier_Company.Text = DR.GetString(DR.GetOrdinal("Supplier_Company"));
                tb_Bank_Name.Text = DR.GetString(DR.GetOrdinal("Bank_Name"));
                tb_Account_No.Text = DR["Account_No"].ToString();
                tb_Note.Text = DR.GetString(DR.GetOrdinal("Note"));
            }
            DR.Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Shared_Content.con_open();

            if (tb_Mobile_No.Text != "" && tb_Supplier_Company.Text != "" && tb_Bank_Name.Text != "" && tb_Account_No.Text != "" && tb_Note.Text != "")
            {
                Shared_Content.con_open();

                SqlCommand Cmd = new SqlCommand();

                Cmd.CommandText = "Update Supplier_Details set Mobile_No ='" + tb_Mobile_No.Text + "', Supplier_Company ='" + tb_Supplier_Company.Text + "', Bank_Name ='" + tb_Bank_Name.Text + "', Account_No ='" + tb_Account_No.Text + "', Note ='" + tb_Note.Text + "'";
                Cmd.Connection = Shared_Content.con;

                Cmd.ExecuteNonQuery();

                Shared_Content.con_close();

                MessageBox.Show("Supplier Updated Successfully ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Controls();
            }
            else
            {
                MessageBox.Show("Please Fill All Fields ", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Shared_Content.con_close();
        }

        private void tb_Suppiler_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Content.Only_Text(e);
        }

        private void tb_Mobile_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Content.Only_Numeric(e);
        }

        private void tb_Aadhar_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Content.Only_Numeric(e);
        }

        private void tb_Suppiler_Company_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Content.Only_Text(e);
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }
    }
}
