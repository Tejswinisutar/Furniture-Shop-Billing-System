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

namespace Furniture_Shop_Billing_System.Windows_Form.Order
{
    public partial class frm_Order_Payment : Form
    {
        public frm_Order_Payment()
        {
            InitializeComponent();
        }

    
        void Search_Order()
        {
            if (tb_Order_Id.Text != "")
            {
                Shared_Content.con_open();

                SqlCommand Cmd = new SqlCommand("Select Supplier_Name,Order_Date,Final_Bill,Paid_Amount from Receive_Order_Details where Order_Id = '" + tb_Order_Id.Text + "'", Shared_Content.con);

                SqlDataReader DR = Cmd.ExecuteReader();

                if (DR.Read())
                {
                    tb_Supplier_Name.Text = DR["Supplier_Name"].ToString();
                    dtp_Order_Date.Text = DR["Order_Date"].ToString();
                    tb_Final_Bill.Text = DR["Final_Bill"].ToString();
                    tb_Paid_Amount.Text = DR["Paid_Amount"].ToString();      
                }
                double Remaining_Amount = Convert.ToDouble(tb_Final_Bill.Text) - Convert.ToDouble(tb_Paid_Amount.Text);

                tb_Remaining_Amount.Text = Convert.ToString(Remaining_Amount);

                Cmd.Dispose();
                DR.Close();
                btn_Search.Enabled = false;
                Shared_Content.con_close();

                if (tb_Final_Bill.Text == tb_Paid_Amount.Text)
                {
                    MessageBox.Show("Payment of This Order is Completed", "Payament Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Clear_Controls();
                }
            }
        }
        void Clear_Controls()
        {
            tb_Payment_Id.Text = Convert.ToString(Shared_Content.Auto_Incr("Order_Payment_Details", "Payment_Id", 100001));

            tb_Order_Id.Clear();
            tb_Supplier_Name.Clear();
            tb_Note.Clear();
            tb_Final_Bill.Text = "0";
            tb_Remaining_Amount.Text = "0";
            tb_Paid_Amount.Text = "0";
            tb_Paying_Amount.Text = "0";

            cmb_Payment_Mode.SelectedIndex = -1;
            dtp_Order_Date.ResetText();

            tb_Order_Id.Enabled = true;
            tb_Order_Id.Focus();
            tb_Payment_Id.Enabled = false;
            dtp_Order_Date.Enabled = false;
            btn_Search.Visible = true;
            btn_Search.Enabled = true;
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            Search_Order();
        }
        private void tb_Suppiler_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Content.Only_Text(e);
        }
        private void tb_Mobile_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Content.Only_Numeric(e);
        }
        private void tb_Final_Bill_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Content.Only_Numeric(e);
        }
        private void tb_Paid_Amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Content.Only_Numeric(e);
        }
        private void tb_Remaining_Amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Content.Only_Numeric(e);
        }
        private void tb_Todays_Fill_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Content.Only_Numeric(e);
        }
        private void tb_Payment_Mode_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Content.Only_Text(e);
        }
      
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
         
                Clear_Controls();
           
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (tb_Order_Id.Text != "" && cmb_Payment_Mode.Text != "")
            {
                Shared_Content.con_open();

                SqlCommand Cmd1 = new SqlCommand();
                SqlCommand cmd2 = new SqlCommand();

                Cmd1.Connection = Shared_Content.con;
                Cmd1.CommandText = "Insert Into Order_Payment_Details Values(@Pid,@OrId,@pdate,@Pamt,@Pmode,@Enm,@note)";

                Cmd1.Parameters.Add("Pid", SqlDbType.Int).Value = tb_Payment_Id.Text;
                Cmd1.Parameters.Add("OrId", SqlDbType.Int).Value = tb_Order_Id.Text;
                Cmd1.Parameters.Add("pdate", SqlDbType.Date).Value = dtp_Order_Date.Text;
                Cmd1.Parameters.Add("Pamt", SqlDbType.Money).Value = tb_Paid_Amount.Text;
                Cmd1.Parameters.Add("Pmode", SqlDbType.VarChar).Value = cmb_Payment_Mode.Text;
                Cmd1.Parameters.Add("Enm", SqlDbType.NVarChar).Value = Shared_Content.LoggedInUname;
                Cmd1.Parameters.Add("note", SqlDbType.NVarChar).Value = tb_Note.Text;

                Cmd1.ExecuteNonQuery();
                Cmd1.Dispose();

                double Tot_Paid = Convert.ToDouble(tb_Paying_Amount.Text) + Convert.ToDouble(tb_Paying_Amount.Text);
                bool Status = false;

                if (Convert.ToDouble(tb_Remaining_Amount.Text) == 0)
                {
                    Status = true;
                }

                cmd2.Connection = Shared_Content.con;
                cmd2.CommandText = "Update Receive_Order_Details Set Paid_Amount = @pa, Status = @sts where Order_Id = @id";

                cmd2.Parameters.Add("pa", SqlDbType.Int).Value = Tot_Paid;
                cmd2.Parameters.Add("sts", SqlDbType.Bit).Value = Status;
                cmd2.Parameters.Add("id", SqlDbType.Int).Value = tb_Order_Id.Text;

                cmd2.ExecuteNonQuery();
                cmd2.Dispose();
                MessageBox.Show("Order_Payment_Details Saved Sucessfully", "ORDER PAYMENT PAID", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please Fill Required Field..!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Clear_Controls();
            Shared_Content.con_close();
        }

        private void tb_Paying_Amount_TextChanged(object sender, EventArgs e)
        {
            if(tb_Final_Bill.Text !="" && tb_Paid_Amount.Text !="" && tb_Paying_Amount.Text !="" && Convert.ToDouble(tb_Paying_Amount.Text)>0)
            {
                double FBill = Convert.ToDouble(tb_Final_Bill.Text);
                double Paid = Convert.ToDouble(tb_Paid_Amount.Text);
                double Paying = Convert.ToDouble(tb_Paying_Amount.Text);

                double Rem = FBill - (Paid + Paying);
                tb_Remaining_Amount.Text = Convert.ToString(Rem);
            }
        }

        private void frm_Order_Payment_Load(object sender, EventArgs e)
        {
            if (Shared_Content.Order_Id > 0)
            {
                tb_Order_Id.Text = Convert.ToString(Shared_Content.Order_Id);
                tb_Final_Bill.Text = Convert.ToString(Shared_Content.FBill);
                tb_Order_Id.Enabled = false;
                btn_Search.Visible = false;
            }
            tb_Payment_Id.Text = Convert.ToString(Shared_Content.Auto_Incr("Order_Payment_Details", "Payment_Id", 100001));
        }
    }
}


