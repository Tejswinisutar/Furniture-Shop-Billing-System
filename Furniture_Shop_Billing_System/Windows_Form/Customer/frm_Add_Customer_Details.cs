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

namespace Furniture_Shop_Billing_System.Windows_Form.Customer
{
    public partial class frm_Add_Customer_Details : Form
    {
        public frm_Add_Customer_Details()
        {
            InitializeComponent();
        }

        int cStock = 0, PID = 0, pcnt = 1;
        double PPrice;

        private void frm_Add_Customer_Details_Load(object sender, EventArgs e)
        {
            Shared_Content.Bind_ComboBox("Category", cmb_Category, "Select Distinct(Category) From Product_Details");
            tb_Customer_Id.Text= Convert.ToString(Shared_Content.Auto_Incr("Customer_Details", "Customer_Id", 101));
        }

        private void cmb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shared_Content.Bind_ComboBox("SubCategory", cmb_SubCategory, "Select Distinct(SubCategory) From Product_Details where Category = '" + cmb_Category.Text + "'");
        }

        private void cmb_SubCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shared_Content.Bind_ComboBox("Product_Name", cmb_Product_Name, "Select Distinct(Product_Name) From Product_Details where Category = '" + cmb_Category.Text + "' And SubCategory = '" + cmb_SubCategory.Text + "'");
        }

        
        private void tb_Quantity_TextChanged(object sender, EventArgs e)
        {
            if (tb_Quantity.Text != "" && Convert.ToInt32(tb_Quantity.Text) > 0)
            {
                tb_Total.Text = Convert.ToString(Convert.ToDouble(tb_Sale_Price.Text) * Convert.ToDouble(tb_Quantity.Text));
            }
            else
            {
                tb_Total.Clear();
            }
        }

        private void Calc_Total(object sender, EventArgs e)
        {
            if (tb_Quantity.Text != "" && tb_Sale_Price.Text != "" && Convert.ToInt32(tb_Quantity.Text) > 0)
            {
                double Amount = Convert.ToDouble(tb_Quantity.Text) * Convert.ToDouble(tb_Sale_Price.Text);

                tb_Total.Text = Convert.ToString(Amount);
            }

            btn_Add.Enabled = true;
        }
        private void tb_Customer_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Content.Only_Text(e);
        }

        private void tb_Mobile_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Content.Only_Numeric(e);
        }

        void Clear_Controls()
        {
            tb_Customer_Id.Text = Convert.ToString(Shared_Content.Auto_Incr("Customer_Details", "Customer_Id", 1));
            tb_Customer_Name.Clear();
            tb_Mobile_No.Clear();
            tb_Total_Bill.Text = "0";
            tb_GST.Text = "0";
            Clear_Purchase_Controls();
            tb_Discount.Text = "0";
            tb_Final_Bill.Text = "0";
            dtp_Date.ResetText();
            dgv_Customer.Rows.Clear();         
        }
        void Clear_Purchase_Controls()
        {
            cmb_Category.SelectedIndex = -1;
            cmb_SubCategory.SelectedIndex = -1;
            cmb_Product_Name.SelectedIndex = -1;
            tb_Quantity.Clear();
            tb_Sale_Price.Clear();
            tb_Total.Clear();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (tb_Total.Text != "")
            {
                btn_Add.Enabled = true;

                int flag = -1, Cqty = Convert.ToInt32(tb_Quantity.Text);

                for (int i = 0; i < dgv_Customer.Rows.Count; i++)
                {
                    if (cmb_Category.Text == Convert.ToString(dgv_Customer.Rows[i].Cells[1].Value) && cmb_SubCategory.Text == Convert.ToString(dgv_Customer.Rows[i].Cells[2].Value) && cmb_Product_Name.Text == Convert.ToString(dgv_Customer.Rows[i].Cells[3].Value))
                    {
                        flag = 0;

                        Cqty += Convert.ToInt32(dgv_Customer.Rows[i].Cells[4].Value);
                        if (cStock >= Cqty)
                        {
                            double TPrice = Convert.ToDouble(Cqty) * Convert.ToDouble(tb_Sale_Price.Text);

                            dgv_Customer.Rows[i].Cells[4].Value = Cqty;
                            dgv_Customer.Rows[i].Cells[6].Value = TPrice;
                        }
                        else
                        {
                            MessageBox.Show("Can't Add More Quantity", "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            flag = 1;
                        }
                    }
                }
                if (flag == -1)
                {
                    if (cStock >= Cqty)
                    {
                        dgv_Customer.Rows.Add(pcnt, cmb_Category.Text, cmb_SubCategory.Text, cmb_Product_Name.Text, tb_Quantity.Text, tb_Sale_Price.Text, tb_Total.Text);
                        pcnt++;
                    }
                    else
                    {
                        MessageBox.Show("No Enough Stock Available", "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        flag = 1;
                    }
                }

                if (flag < 1)
                {
                    double bill = Convert.ToDouble(tb_Total_Bill.Text) + Convert.ToDouble(tb_Total.Text);

                    tb_Total_Bill.Text = Convert.ToString(bill);
                    tb_Final_Bill.Text = Convert.ToString(bill);
                }
            }
            else
            {
                MessageBox.Show("Please Fill Required Field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            Clear_Purchase_Controls();
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (tb_Customer_Name.Text != "" && tb_Mobile_No.Text != "" && tb_GST.Text != "" && tb_Discount.Text != "" && Convert.ToDouble(tb_Total_Bill.Text) > 0)
            {
                Shared_Content.con_open();

                /// Insert Main Entry into Primary Key Table

                SqlCommand Cmd1 = new SqlCommand();

                Cmd1.Connection = Shared_Content.con;
                Cmd1.CommandText = "Insert Into Customer_Details Values (@cId, @cName, @date, @mno , @TBill, @gst, @Disc, @FBill)";

                Cmd1.Parameters.Add("cId", SqlDbType.Int).Value = tb_Customer_Id.Text;
                Cmd1.Parameters.Add("cName", SqlDbType.VarChar).Value = tb_Customer_Name.Text;
                Cmd1.Parameters.Add("date", SqlDbType.Date).Value = dtp_Date.Text;
                Cmd1.Parameters.Add("mno", SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                Cmd1.Parameters.Add("TBill", SqlDbType.Money).Value = tb_Total_Bill.Text;
                Cmd1.Parameters.Add("gst", SqlDbType.Float).Value = tb_GST.Text;
                Cmd1.Parameters.Add("Disc", SqlDbType.Int).Value = tb_Discount.Text;
                Cmd1.Parameters.Add("FBill", SqlDbType.Money).Value = tb_Final_Bill.Text;

                Cmd1.ExecuteNonQuery();
                Cmd1.Dispose();
                /// Insert Grid Rows into Foreign Key Table 

                for (int i = 0; i < dgv_Customer.RowCount; i++)
                {
                    SqlCommand Cmd2 = new SqlCommand();
                    SqlCommand Cmd3 = new SqlCommand();
                    SqlCommand Cmd4 = new SqlCommand();

                    Cmd2.Connection = Shared_Content.con;
                    Cmd2.CommandText = "Insert Into Customer_Purchase_Details Values (@OCId, @Cat, @Ost, @PN, @Qty, @Sp, @Tot)";

                    Cmd2.Parameters.Add("OCId", SqlDbType.Int).Value = tb_Customer_Id.Text;
                    Cmd2.Parameters.Add("Cat", SqlDbType.VarChar).Value = dgv_Customer.Rows[i].Cells[1].Value;
                    Cmd2.Parameters.Add("Ost", SqlDbType.VarChar).Value = dgv_Customer.Rows[i].Cells[2].Value;
                    Cmd2.Parameters.Add("PN", SqlDbType.VarChar).Value = dgv_Customer.Rows[i].Cells[3].Value;
                    Cmd2.Parameters.Add("Qty", SqlDbType.Int).Value = dgv_Customer.Rows[i].Cells[4].Value;
                    Cmd2.Parameters.Add("Sp", SqlDbType.Money).Value = dgv_Customer.Rows[i].Cells[5].Value;
                    Cmd2.Parameters.Add("Tot", SqlDbType.Money).Value = dgv_Customer.Rows[i].Cells[6].Value;

                    Cmd2.ExecuteNonQuery();
                    Cmd2.Dispose();

                    int Saled_Qty = Convert.ToInt32(dgv_Customer.Rows[i].Cells[4].Value);
                    int P_C_Stock = 0;
                    int C_ID = 0;
                    int New_Stock = 0;

                    Cmd1.CommandText = "Select Product_Id , Current_Stock From Product_Details where Category = '" + dgv_Customer.Rows[i].Cells[1].Value + "' And SubCategory = '" + dgv_Customer.Rows[i].Cells[2].Value + "' And Product_Name = '" + dgv_Customer.Rows[i].Cells[3].Value + "'";
                    Cmd1.Connection = Shared_Content.con;

                    SqlDataReader obj = Cmd1.ExecuteReader();

                    if (obj.Read())
                    {
                        C_ID = Convert.ToInt32((obj["Product_Id"].ToString()));
                        P_C_Stock = Convert.ToInt32(obj["Current_Stock"].ToString());
                    }
                    New_Stock = P_C_Stock - Saled_Qty;
                    obj.Close();
                    Cmd2.Dispose();
                    SqlDataAdapter sda = new SqlDataAdapter("Update Product_Details set Current_Stock = '" + New_Stock + "' where Product_Id = '" + C_ID + "'", Shared_Content.con);

                    DataTable DT = new DataTable();
                    sda.Fill(DT);

                }
                MessageBox.Show("Customer Details Saved Successfully!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Shared_Content.Cust_Id = Convert.ToInt32(tb_Customer_Id.Text);
                Reports.ReportForms.frm_Customer_Bill Bill = new Reports.ReportForms.frm_Customer_Bill();
                Bill.Show();

                Clear_Controls();
                Shared_Content.con_close();
            }
            else
            {
                MessageBox.Show("Fill Required Fileds", "Failuare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmb_Product_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shared_Content.con_open();

            SqlCommand Cmd = new SqlCommand("Select Sale_Price,Current_Stock , Product_Id From Product_Details where Category = '" + cmb_Category.Text + "' And SubCategory = '" + cmb_SubCategory.Text + "' And Product_Name = '" + cmb_Product_Name.Text + "'", Shared_Content.con);

            SqlDataReader DR = Cmd.ExecuteReader();
            if (DR.Read())
            {
                PPrice = Convert.ToDouble(DR["Sale_Price"].ToString());
                cStock = Convert.ToInt32(DR["Current_Stock"].ToString());
                PID = Convert.ToInt32(DR["Product_Id"].ToString());
            }
            Cmd.Dispose();
            tb_Sale_Price.Text = Convert.ToString(PPrice);
            Shared_Content.con_close();
            tb_Quantity.Enabled = true;
            tb_Sale_Price.Enabled = true;
        }

        

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void tb_Total_Bill_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_GST_TextChanged(object sender, EventArgs e)
        {
            if(tb_GST.Text != "" && tb_Discount.Text!= "")
            {
                double Bill = Convert.ToDouble(tb_Total_Bill.Text);

                double GST = Convert.ToDouble(tb_GST.Text);

                double Disc = Convert.ToDouble(tb_Discount.Text);

                double FinalBill = Convert.ToDouble(tb_Total_Bill.Text) + ((Bill) * (GST / 100)) - ((Bill) * (Disc / 100));

                tb_Final_Bill.Text = Convert.ToString(FinalBill);
            }
        }

        private void tb_Discount_TextChanged(object sender, EventArgs e)
        {
            if(tb_GST.Text !="" && tb_Discount.Text !="")
            {
                double Bill = Convert.ToDouble(tb_Total_Bill.Text);

                double GST = Convert.ToDouble(tb_GST.Text);

                double Disc = Convert.ToDouble(tb_Discount.Text);

                double FinalBill = Convert.ToDouble(tb_Final_Bill.Text) + ((Bill) * (GST / 100)) - ((Bill) * (Disc / 100));

                tb_Final_Bill.Text = Convert.ToString(FinalBill);
            }
        }
    }
}
