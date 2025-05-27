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

namespace Furniture_Shop_Billing_System.Windows_Form.Products
{
    public partial class frm_Update_Product_Details : Form
    {
        public frm_Update_Product_Details()
        {
            InitializeComponent();
        }

        void Clear_Controls()
        {
            tb_Product_Id.Clear();
            tb_Category.Clear();
            tb_Product_Name.Clear();
            tb_Supplier.Clear();
            tb_SubCategory.Clear();
            tb_Details.Clear();
            tb_Category.Clear();
            tb_Product_Company.Clear();
            tb_Details.Clear();

        }

        void Enable_Controls()
        {
            tb_Product_Id.Enabled = true;
            tb_Category.Enabled = true;
            tb_SubCategory.Enabled = true;
            tb_Product_Name.Enabled = true;
            tb_Product_Company.Enabled = true;
            dtp_Date.Enabled = true;
            tb_Sale_Price.Enabled = true;
            tb_Purchase_Price.Enabled = true;
            tb_Details.Enabled = true;
            tb_Supplier.Enabled = true;
        }
        void Disable_Controls()
        {
            tb_Product_Id.Enabled = true;
            tb_Category.Enabled = false;
            tb_SubCategory.Enabled = false;
            tb_Product_Name.Enabled = false;
            tb_Product_Company.Enabled = false;
            dtp_Date.Enabled = false;
            tb_Sale_Price.Enabled = false;
            tb_Purchase_Price.Enabled = false;
            tb_Details.Enabled = false;
            tb_Supplier.Enabled = false;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Shared_Content.con_open();

            SqlCommand Cmd = new SqlCommand();
            Cmd.CommandText = "Select * from Product_Details where Product_Id= '" + tb_Product_Id.Text + "'";
            Cmd.Connection = Shared_Content.con;

            SqlDataReader DR = Cmd.ExecuteReader();

            if(DR.Read())
            {
                tb_Category.Text = DR.GetString(DR.GetOrdinal("Category"));
                tb_SubCategory.Text = DR.GetString(DR.GetOrdinal("SubCategory"));
                tb_Product_Name.Text = DR.GetString(DR.GetOrdinal("Product_Name"));
                tb_Product_Company.Text = DR.GetString(DR.GetOrdinal("Product_Company"));
                dtp_Date.Text = DR["Date"].ToString();
                tb_Sale_Price.Text = DR["Sale_Price"].ToString();
                tb_Purchase_Price.Text = DR["Purchase_Price"].ToString();
                tb_Details.Text = DR.GetString(DR.GetOrdinal("Details"));
                tb_Supplier.Text = DR.GetString(DR.GetOrdinal("Supplier"));
            }
            DR.Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Shared_Content.con_open();

            if(tb_Category.Text !="" && tb_SubCategory.Text !="" && tb_Product_Name.Text !="" && tb_Product_Company.Text !="" && dtp_Date.Text !="" && tb_Sale_Price.Text !="" && tb_Purchase_Price.Text !="" && tb_Details.Text!="" && tb_Supplier.Text !="")
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "Update Product_Details set Category ='" + tb_Category.Text + "', SubCategory ='" + tb_SubCategory.Text + "', Product_Name ='" + tb_Product_Name.Text + "', Date ='" + dtp_Date.Text + "', Sale_Price ='" + tb_Sale_Price.Text + "', Purchase_Price ='" + tb_Purchase_Price.Text + "', Details ='" + tb_Details.Text + "', Supplier ='" + tb_Supplier.Text + "'";
                cmd.Connection = Shared_Content.con;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Product Updated Successfully", "Success", MessageBoxButtons.OK,MessageBoxIcon.Information);
                Clear_Controls();
            }
            else
            {
                MessageBox.Show("Please Fill All Firlds", "Failure",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Shared_Content.con_close();
        }

        private void tb_Product_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Content.Only_Text(e);
        }

        private void tb_Product_Company_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Content.Only_Text(e);
        }

        private void tb_Sale_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Content.Only_Numeric(e);
        }

        private void tb_Purchase_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Content.Only_Numeric(e);
        }
    }
}
