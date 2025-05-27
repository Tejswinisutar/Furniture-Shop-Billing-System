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
    public partial class frm_Receive_Order : Form
    {
        public frm_Receive_Order()
        {
            InitializeComponent();
        }

        int Pcnt = 1;

        void Clear_controls()
        {
            cmb_Supplier_Name.SelectedIndex = -1;
            tb_Mobile_No.Clear();
            cmb_Category.SelectedIndex = -1;
            cmb_SubCategory.SelectedIndex = -1;
            cmb_Product_Name.SelectedIndex = -1;
            tb_Quantity.Clear();
            tb_Purchase_Price.Clear();
            tb_Total.Clear();

            dgv_Purchase_Receive.Rows.Clear();

            tb_Total_Bill.Text = "0";
            tb_GST.Text = "0";
            tb_Final_Bill.Text = "0";

            tb_Quantity.Enabled = false;
            btn_Add.Enabled = false;

            Pcnt = 1;
        }

        void Clear_Product_Controls()
        {
            cmb_Category.SelectedIndex = -1;
            cmb_SubCategory.SelectedIndex = -1;
            cmb_Product_Name.SelectedIndex = -1;
            tb_Quantity.Clear();
            tb_Purchase_Price.Clear();
            tb_Total.Clear();
            cmb_Category.Focus();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if(tb_Total.Text != "")
            {
                bool Flag = false;

                for(int i = 0;i < dgv_Purchase_Receive.Rows.Count; i++)
                {
                    if (cmb_Category.Text == Convert.ToString(dgv_Purchase_Receive.Rows[i].Cells[1].Value) && cmb_SubCategory.Text == Convert.ToString(dgv_Purchase_Receive.Rows[i].Cells[2].Value) && cmb_Product_Name.Text == Convert.ToString(dgv_Purchase_Receive.Rows[i].Cells[3].Value))
                    { 
                        int Qty = Convert.ToInt32(tb_Quantity.Text) + Convert.ToInt32(dgv_Purchase_Receive.Rows[i].Cells[4].Value);

                        dgv_Purchase_Receive.Rows[i].Cells[4].Value = Qty;

                        double Amount = Convert.ToDouble(tb_Total.Text) + Convert.ToDouble(dgv_Purchase_Receive.Rows[i].Cells[6].Value);

                        dgv_Purchase_Receive.Rows[i].Cells[6].Value = Amount;

                        Flag = true;
                        break;
                    }
                }

                if (Flag == false)
                {
                    dgv_Purchase_Receive.Rows.Add(Pcnt, cmb_Category.Text, cmb_SubCategory.Text, cmb_Product_Name.Text, tb_Quantity.Text, tb_Purchase_Price.Text, tb_Total.Text);
                    Pcnt++;
                }
                
                    double Bill = Convert.ToDouble(tb_Total_Bill.Text) + Convert.ToDouble(tb_Total.Text);

                    tb_Total_Bill.Text = Convert.ToString(Bill);
                    tb_Final_Bill.Text = Convert.ToString(Bill);

                Clear_Product_Controls();
            }
        }

        private void frm_Receive_Order_Load(object sender, EventArgs e)
        {
            tb_Order_Id.Text = Convert.ToString(Shared_Content.Auto_Incr("Receive_Order_Details", "Order_Id", 5001));

            btn_Refresh.PerformClick();

            Shared_Content.Bind_ComboBox("Category_Name", cmb_Category, "Select Distinct(Category_Name) From Category_Details");

            Shared_Content.Bind_ComboBox("Supplier_Name", cmb_Supplier_Name, "Select Distinct(Supplier_Name) From Supplier_Details");
        }

        private void cmb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shared_Content.Bind_ComboBox("SubCategory_Name", cmb_SubCategory, "Select Distinct(SubCategory_Name) From SubCategory_Details where Category_Name = '" + cmb_Category.Text + "'");
        }

        private void cmb_SubCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shared_Content.Bind_ComboBox("Product_Name", cmb_Product_Name, "Select Distinct(Product_Name) From Product_Details where Category ='" + cmb_Category.Text + "' And SubCategory = '" + cmb_SubCategory.Text + "'");
        }

        private void cmb_Product_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shared_Content.con_open();

            SqlCommand cmd = new SqlCommand("Select Purchase_Price From Product_Details where Category ='" + cmb_Category.Text + "' And SubCategory ='" + cmb_SubCategory.Text + "'And Product_Name ='" + cmb_Product_Name.Text + "'", Shared_Content.con);

            SqlDataReader Dr = cmd.ExecuteReader();

            if (Dr.Read())
            {
                tb_Purchase_Price.Text = (Dr["Purchase_Price"].ToString());
            }

            cmd.Dispose();
            Dr.Close();
            Shared_Content.con_close();
            tb_Quantity.Enabled = true;
            tb_Purchase_Price.Enabled = true;

        }

        private void tb_Quantity_TextChanged(object sender, EventArgs e)
        {
            if(tb_Quantity.Text !="" && tb_Purchase_Price.Text !="" && Convert.ToInt32(tb_Quantity.Text) > 0)
            {
                double Amount = Convert.ToDouble(tb_Quantity.Text) * Convert.ToDouble(tb_Purchase_Price.Text);

                tb_Total.Text = Convert.ToString(Amount);
            }

            btn_Add.Enabled = true;        
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_controls();
        }

        private void tb_Purchase_Price_TextChanged(object sender, EventArgs e)
        {
            if(tb_Quantity.Text !="" && tb_Purchase_Price.Text !="" && Convert.ToInt32(tb_Quantity.Text) > 0)
            {
                double Amount = Convert.ToDouble(tb_Quantity.Text) * Convert.ToDouble(tb_Purchase_Price.Text);

                tb_Total.Text = Convert.ToString(Amount);
            }

            btn_Add.Enabled = true;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Shared_Content.con_open();

            if (cmb_Supplier_Name.Text != "" && tb_GST.Text != "" && Convert.ToDouble(tb_Total_Bill.Text) > 0)
            {
                Shared_Content.con_open();

                ///Insert Main Entry into Primary Key Table

                SqlCommand Cmd1 = new SqlCommand();

                Cmd1.Connection = Shared_Content.con;

                Cmd1.CommandText = "Insert Into Receive_Order_Details Values(@Roi,@Rsn,@Rdate,@Rtb,@Rg,@Rfb,@Rpa,@Rsts)";

                Cmd1.Parameters.Add("@Roi", SqlDbType.Int).Value = tb_Order_Id.Text;
                Cmd1.Parameters.Add("@Rsn", SqlDbType.VarChar).Value = cmb_Supplier_Name.Text;
                Cmd1.Parameters.Add("@Rdate", SqlDbType.Date).Value = dtp_Order_Date.Text;
                Cmd1.Parameters.Add("@Rtb", SqlDbType.Money).Value = tb_Total_Bill.Text;
                Cmd1.Parameters.Add("@Rg", SqlDbType.Float).Value = tb_GST.Text;
                Cmd1.Parameters.Add("@Rfb", SqlDbType.Money).Value = tb_Final_Bill.Text;

                Cmd1.Parameters.Add("Rpa", SqlDbType.Int).Value = 0;
                Cmd1.Parameters.Add("Rsts", SqlDbType.Bit).Value = 0;
               
                Cmd1.ExecuteNonQuery();
                Cmd1.Dispose();

                ///Insert Grid Rows into Foreign Key Table

                for (int i = 0; i < dgv_Purchase_Receive.RowCount; i++)
                {
                    SqlCommand Cmd2 = new SqlCommand();
                    SqlCommand Cmd3 = new SqlCommand();
                    SqlCommand Cmd4 = new SqlCommand();

                    Cmd2.Connection = Shared_Content.con;

                    Cmd2.CommandText = "Insert Into Order_Purchase_Details Values(@OId,@Ocat,@Oscat,@Opn,@OQty,@Opp,@Ot)";

                    Cmd2.Parameters.Add("OId", SqlDbType.VarChar).Value = tb_Order_Id.Text;
                    Cmd2.Parameters.Add("Ocat", SqlDbType.VarChar).Value = dgv_Purchase_Receive.Rows[i].Cells[1].Value;
                    Cmd2.Parameters.Add("Oscat", SqlDbType.VarChar).Value = dgv_Purchase_Receive.Rows[i].Cells[2].Value;
                    Cmd2.Parameters.Add("Opn", SqlDbType.VarChar).Value = dgv_Purchase_Receive.Rows[i].Cells[3].Value;
                    Cmd2.Parameters.Add("OQty", SqlDbType.Int).Value = dgv_Purchase_Receive.Rows[i].Cells[4].Value;
                    Cmd2.Parameters.Add("Opp", SqlDbType.Float).Value = dgv_Purchase_Receive.Rows[i].Cells[5].Value;
                    Cmd2.Parameters.Add("Ot", SqlDbType.Money).Value = dgv_Purchase_Receive.Rows[i].Cells[6].Value;

                    Cmd2.ExecuteNonQuery();
                    Cmd2.Dispose();

                    ///Update Stock of current Row Product ->Cat,Scat,pname

                    Cmd3.Connection = Shared_Content.con;

                    Cmd3.CommandText = "Select Product_Id,Current_Stock From Product_Details Where Category = @Ct And SubCategory = @Sc And Product_Name = @pname";

                    Cmd3.Parameters.Add("Ct", SqlDbType.VarChar).Value = dgv_Purchase_Receive.Rows[i].Cells[1].Value;
                    Cmd3.Parameters.Add("Sc", SqlDbType.VarChar).Value = dgv_Purchase_Receive.Rows[i].Cells[2].Value;
                    Cmd3.Parameters.Add("pname", SqlDbType.VarChar).Value = dgv_Purchase_Receive.Rows[i].Cells[3].Value;

                    SqlDataReader Dr = Cmd3.ExecuteReader();

                    int CId = 0, CStock = 0, NewStock = 0;

                    if (Dr.Read())
                    {
                        CId = Convert.ToInt32((Dr["Product_Id"].ToString()));
                        CStock = Convert.ToInt32((Dr["Current_Stock"].ToString()));
                    }
                    NewStock = Convert.ToInt32(dgv_Purchase_Receive.Rows[i].Cells[4].Value) + CStock;
                    Cmd3.Dispose();
                    Dr.Close();

                    Cmd4.Connection = Shared_Content.con;
                    Cmd4.CommandText = "Update Product_Details Set Current_Stock = @CS Where Product_Id = @PId";

                    Cmd4.Parameters.Add("CS", SqlDbType.Int).Value = NewStock;
                    Cmd4.Parameters.Add("PId", SqlDbType.Int).Value = CId;

                    Cmd4.ExecuteNonQuery();
                    Cmd4.Dispose();
                }
                MessageBox.Show("Receive_Order_Details Saved Successfully", "ORDER   RECEIVESD", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Order.frm_Order_Payment Obj = new Order.frm_Order_Payment() { TopLevel = false, TopMost = true };
                Obj.FormBorderStyle = FormBorderStyle.None;

                frm_Main_Form.pnl_Container.Controls.Clear();
                frm_Main_Form.pnl_Container.Controls.Add(Obj);

                Shared_Content.OrderID = Convert.ToInt32(tb_Order_Id.Text);
                Shared_Content.S_Nm = Convert.ToString(cmb_Supplier_Name.Text);
                Shared_Content.FBill = Convert.ToDouble(tb_Final_Bill.Text);

                Obj.Show();
                Shared_Content.con_close();

                Clear_controls();
            }
            else
            {
                MessageBox.Show("Fill All The Fields", "Fill Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_Supplier_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Content.Only_Text(e);
        }

        private void tb_Mobile_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Content.Only_Numeric(e);
        }

        private void tb_GST_TextChanged(object sender, EventArgs e)
        {
            if (tb_GST.Text != "")
            {
                double Bill = Convert.ToDouble(tb_Total_Bill.Text);

                double GST = Convert.ToDouble(tb_GST.Text);

                double FinalBill = ((Bill) * (GST / 100)) + Convert.ToDouble(tb_Total_Bill.Text);

                tb_Final_Bill.Text = Convert.ToString(FinalBill);
            }
        }

        private void cmb_Suppiler_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shared_Content.con_open();

            SqlCommand Cmd = new SqlCommand("Select Mobile_No From Supplier_Details where Supplier_Name = '" + cmb_Supplier_Name.Text + "'", Shared_Content.con);

            tb_Mobile_No.Text = Convert.ToString(Cmd.ExecuteScalar());

            Cmd.Dispose();

            Shared_Content.con_close();
        }
    }
} 