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
    public partial class frm_Add_Employee_Details : Form
    {
        public frm_Add_Employee_Details()
        {
            InitializeComponent();
        }

        void Clear_Controls()
        {
            tb_Employee_Id.Text = Convert.ToString(Shared_Content.Auto_Incr("Employee_Details", "Employee_Id", 1));
            tb_Employee_Name.Clear();
            dtp_Date.ResetText();
            tb_Mobile_No.Clear();
            tb_Designation.Clear();
            tb_Aadhar_No.Clear ();
            tb_Bank_Name.Clear();
            tb_Account_No.Clear();
            tb_Note.Clear();

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Shared_Content.con_open();

            if (tb_Employee_Id.Text != "" && dtp_Date.Text != "" && tb_Employee_Name.Text != "" && tb_Mobile_No.Text != "" && tb_Designation.Text != "" && tb_Aadhar_No.Text != "" && tb_Bank_Name.Text != "" && tb_Account_No.Text != "")
            {
                SqlCommand Cmd = new SqlCommand("Insert Into Employee_Details values (@Eid,@Edtp,@Enm,@Emn,@Edes,@Ean,@Ebn,@Eacn,@Enote)",Shared_Content.con);
           
  
                Cmd.Parameters.Add("@Eid", SqlDbType.Int).Value = tb_Employee_Id.Text;
                Cmd.Parameters.Add("@Edtp", SqlDbType.Date).Value = dtp_Date.Text;
                Cmd.Parameters.Add("@Enm", SqlDbType.VarChar).Value = tb_Employee_Name.Text;
                Cmd.Parameters.Add("@Emn", SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                Cmd.Parameters.Add("@Edes", SqlDbType.VarChar).Value = tb_Designation.Text;
                Cmd.Parameters.Add("@Ean", SqlDbType.Decimal).Value = tb_Aadhar_No.Text;
                Cmd.Parameters.Add("@Ebn", SqlDbType.VarChar).Value = tb_Bank_Name.Text;
                Cmd.Parameters.Add("@Eacn", SqlDbType.Decimal).Value = tb_Account_No.Text;
                Cmd.Parameters.Add("@Enote", SqlDbType.NVarChar).Value = tb_Note.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Employee Details Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Controls();
            }
            else
            {
                MessageBox.Show("Fill All The Fields", "Fill Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                Shared_Content.con_close();
        }

        private void frm_Add_Employee_Details_Load(object sender, EventArgs e)
        {
            tb_Employee_Id.Text = Convert.ToString(Shared_Content.Auto_Incr("Employee_Details", "Employee_Id", 1));
        }

        private void tb_Employee_Name_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tb_Designation_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Content.Only_Text(e);
        }

        private void tb_Account_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Content.Only_Numeric(e);
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {

        }

        private void tb_Employee_Name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
