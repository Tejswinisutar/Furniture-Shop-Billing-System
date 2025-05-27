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
    public partial class frm_Add_Product_Details : Form
    {
        public frm_Add_Product_Details()
        {
            InitializeComponent();
        }

        void Clear_Controls()
        {
            tb_Product_Id.Text = Convert.ToString(Shared_Content.Auto_Incr("Product_Details", "Product_Id", 501));

            tb_Product_Name.Clear();
            tb_Purchase_Price.Clear();
            tb_Sale_Price.Clear();
            tb_Details.Clear();
            cmb_Category.SelectedIndex = -1;
            cmb_SubCategory.SelectedIndex = -1;
            cmb_Supplier.SelectedIndex = -1;
            tb_Product_Company.Clear();
        }

        private void frm_Add_Product_Details_Load(object sender, EventArgs e)
        {
            Clear_Controls();
            cmb_Category.Focus();

            tb_Product_Id.Text = Convert.ToString(Shared_Content.Auto_Incr("Product_Details", "Product_Id", 501));
            Shared_Content.Bind_ComboBox("Category_Name", cmb_Category, "Select Distinct(Category_Name)From Category_Details");
           
            Shared_Content.Bind_ComboBox("Supplier_Name", cmb_Supplier, "Select Supplier_Name From Supplier_Details");
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
            cmb_Category.Focus();
        }

        private void cmb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shared_Content.Bind_ComboBox("SubCategory_Name", cmb_SubCategory, "Select Distinct(SubCategory_Name) From SubCategory_Details");
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Shared_Content.con_open();

            if (tb_Product_Id.Text != "" && cmb_Category.Text != "" && cmb_SubCategory.Text != "" && tb_Product_Name.Text != "" && tb_Product_Company.Text != "" && dtp_Date.Text != "" && tb_Sale_Price.Text != "" && tb_Purchase_Price.Text != "" && tb_Details.Text != "" && cmb_Supplier.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Insert Into Product_Details values (@Pid,@Pc,@Psc,@Pnm,@Pcp,@PDate,@Psp,@Ppp,@Pd,@Ps,@CS)", Shared_Content.con);

                cmd.Parameters.Add("@Pid", SqlDbType.Int).Value = tb_Product_Id.Text;
                cmd.Parameters.Add("@Pc", SqlDbType.VarChar).Value = cmb_Category.Text;
                cmd.Parameters.Add("@Psc", SqlDbType.VarChar).Value = cmb_SubCategory.Text;
                cmd.Parameters.Add("@Pnm", SqlDbType.VarChar).Value = tb_Product_Name.Text;
                cmd.Parameters.Add("@Pcp", SqlDbType.VarChar).Value = tb_Product_Company.Text;
                cmd.Parameters.Add("@PDate", SqlDbType.Date).Value = dtp_Date.Text;
                cmd.Parameters.Add("@Psp", SqlDbType.Money).Value = tb_Sale_Price.Text;
                cmd.Parameters.Add("@Ppp", SqlDbType.Money).Value = tb_Purchase_Price.Text;
                cmd.Parameters.Add("@Pd", SqlDbType.NVarChar).Value = tb_Details.Text;
                cmd.Parameters.Add("@Ps", SqlDbType.VarChar).Value = cmb_Supplier.Text;
                cmd.Parameters.Add("@CS", SqlDbType.Int).Value = 0;

                cmd.ExecuteNonQuery();
                Clear_Controls();

                MessageBox.Show("Product Details Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Fill All The Fields", "Fill Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Shared_Content.con_close();
        }
    }
}



