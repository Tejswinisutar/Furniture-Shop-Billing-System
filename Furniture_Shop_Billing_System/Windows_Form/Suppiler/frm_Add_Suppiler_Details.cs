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
    public partial class frm_Add_Suppiler_Details : Form
    {
        public frm_Add_Suppiler_Details()
        {
            InitializeComponent();
        }
        void Clear_Controls()
        {
            tb_Supplier_Id.Text = Convert.ToString(Shared_Content.Auto_Incr("Supplier_Details", "Supplier_Id", 101));

            tb_Supplier_Company.Clear();
            tb_Supplier_Name.Clear();
            tb_Mobile_No.Clear();
            tb_Aadhar_No.Clear();
            tb_Bank_Name.Clear();
            dtp_Date.ResetText();
            tb_Note.Clear();
            tb_Account_No.Clear();
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            Shared_Content.con_open();

            if(tb_Supplier_Id.Text !="" && tb_Supplier_Name.Text !="" && tb_Aadhar_No.Text !="" && dtp_Date.Text !="" && tb_Mobile_No.Text !="" && tb_Supplier_Company.Text !="" && tb_Bank_Name.Text !="" && tb_Account_No.Text !="" && tb_Note.Text !="" )
            {
                SqlCommand Cmd = new SqlCommand("Insert Into Supplier_Details values (@Sid,@Snm,@Sadn,@Sdtp,@Smn,@Ssc,@Sbn,@San,@Snote)", Shared_Content.con);


                Cmd.Parameters.Add("@Sid", SqlDbType.Int).Value = tb_Supplier_Id.Text;
                Cmd.Parameters.Add("@Snm", SqlDbType.VarChar).Value = tb_Supplier_Name.Text;
                Cmd.Parameters.Add("@Sadn", SqlDbType.Decimal).Value = tb_Aadhar_No.Text;
                Cmd.Parameters.Add("@Sdtp", SqlDbType.Date).Value = dtp_Date.Text;
                Cmd.Parameters.Add("@Smn", SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                Cmd.Parameters.Add("@Ssc", SqlDbType.VarChar).Value = tb_Supplier_Company.Text;
                Cmd.Parameters.Add("@Sbn", SqlDbType.NVarChar).Value = tb_Bank_Name.Text;
                Cmd.Parameters.Add("@San", SqlDbType.Decimal).Value = tb_Account_No.Text;
                Cmd.Parameters.Add("@Snote", SqlDbType.NVarChar).Value = tb_Note.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Supplier Details Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Controls();
            }
            else
            {
                MessageBox.Show("Fill All The Fields", "Fill Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                Shared_Content.con_close();
        }

        private void frm_Add_Suppiler_Details_Load(object sender, EventArgs e)
        {
            tb_Supplier_Id.Text = Convert.ToString(Shared_Content.Auto_Incr("Supplier_Details", "Supplier_Id", 101));
        }

        private void tb_Aadhar_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Content.Only_Numeric(e);
        }

        private void tb_Suppiler_Company_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Content.Only_Text(e);
        }

        private void tb_Account_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Content.Only_Numeric(e);
        }

        private void tb_Suppiler_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Content.Only_Text(e);
        }

        private void tb_Mobile_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Content.Only_Numeric(e);
        }

        private void tb_Suppiler_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }
    }
        
}

