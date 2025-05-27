using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Furniture_Shop_Billing_System.Windows_Form.Products
{
    public partial class frm_Product_View_List : Form
    {
        public frm_Product_View_List()
        {
            InitializeComponent();
        }

        private void frm_Product_View_List_Load(object sender, EventArgs e)
        {

            Shared_Content.Bind_ComboBox("Category", cmb_Category, "Select distinct(Category) From Product_Details");
           
            Shared_Content.Bind_Grid( dgv_Product_List, "Select Product_Id, Category, SubCategory, Product_Name, Purchase_Price, Sale_Price, Current_Stock From Product_Details");
           
        }
        private void cmb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shared_Content.Bind_ComboBox("SubCategory", cmb_SubCategory, "Select SubCategory from Product_Details where Category = '" + cmb_Category.Text + "'");

            Shared_Content.Bind_Grid(dgv_Product_List, "Select Product_Id, Category, SubCategory, Product_Name, Purchase_Price, Sale_Price, Current_Stock From Product_Details");
        }

        private void cmb_SubCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shared_Content.Bind_ComboBox("Product_Name",cmb_Product, "Select Product_Name from Product_Details where Category = '" + cmb_Category.Text + "' And SubCategory = '" + cmb_SubCategory.Text + "'");

            Shared_Content.Bind_Grid(dgv_Product_List, "Select Product_Id, Category, SubCategory, Product_Name, Purchase_Price, Sale_Price, Current_Stock From Product_Details");
        }

        private void cmb_Product_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shared_Content.Bind_Grid(dgv_Product_List, "Select Product_Id, Category, SubCategory, Product_Name, Purchase_Price, Sale_Price, Current_Stock From Product_Details where Category = '" + cmb_Category.Text + "' And SubCategory = '" + cmb_SubCategory.Text + "' And Product_Name = '" + cmb_Product.Text + "' ");

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            cmb_Category.SelectedIndex = -1;
            cmb_SubCategory.SelectedIndex = -1;
            cmb_Product.SelectedIndex = -1;

            Shared_Content.Bind_Grid(dgv_Product_List, "Select Product_Id, Category, SubCategory, Product_Name, Purchase_Price, Sale_Price, Current_Stock From Product_Details");

        }

        private void lbl_SubCategory_Click(object sender, EventArgs e)
        {

        }
    }
    
}

