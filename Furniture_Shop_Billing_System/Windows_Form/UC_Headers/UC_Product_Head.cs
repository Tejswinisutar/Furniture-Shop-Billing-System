using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Furniture_Shop_Billing_System.Windows_Form.UC_Headers
{
    public partial class UC_Product_Head : UserControl
    {
        public UC_Product_Head()
        {
            InitializeComponent();
        }

        private void btn_Update_Product_Click(object sender, EventArgs e)
        {
            Windows_Form.Products.frm_Update_Product_Details obj = new Products.frm_Update_Product_Details() { TopLevel = false, TopMost = true };
            obj.FormBorderStyle = FormBorderStyle.None;

            frm_Main_Form.pnl_Container.Controls.Clear();
            frm_Main_Form.pnl_Container.Controls.Add(obj);
            obj.Show();
        }

        private void btn_Category_Click(object sender, EventArgs e)
        {
            Windows_Form.Products.frm_Add_Category_Details obj = new Products.frm_Add_Category_Details() { TopLevel = false, TopMost = true };
            obj.FormBorderStyle = FormBorderStyle.None;

            frm_Main_Form.pnl_Container.Controls.Clear();
            frm_Main_Form.pnl_Container.Controls.Add(obj);
            obj.Show();
        }

        private void btn_View_List_Click(object sender, EventArgs e)
        {
            Windows_Form.Products.frm_Product_View_List obj = new Products.frm_Product_View_List { TopLevel = false, TopMost = true };

            obj.FormBorderStyle = FormBorderStyle.None;

            frm_Main_Form.pnl_Container.Controls.Clear();
            frm_Main_Form.pnl_Container.Controls.Add(obj);

            obj.Show();
        }

        private void btn_Add_Product_Click(object sender, EventArgs e)
        {
            Windows_Form.Products.frm_Add_Product_Details obj = new Products.frm_Add_Product_Details() { TopLevel = false, TopMost = true };
            obj.FormBorderStyle = FormBorderStyle.None;

            frm_Main_Form.pnl_Container.Controls.Clear();
            frm_Main_Form.pnl_Container.Controls.Add(obj);
            obj.Show();
        }

        private void btn_SubCategory_Click(object sender, EventArgs e)
        {
            Windows_Form.Products.frm_Add_SubCategory_Details  obj = new Products.frm_Add_SubCategory_Details() { TopLevel = false, TopMost = true };
            obj.FormBorderStyle = FormBorderStyle.None;

            frm_Main_Form.pnl_Container.Controls.Clear();
            frm_Main_Form.pnl_Container.Controls.Add(obj);
            obj.Show();
        }

        private void UC_Product_Head_Load(object sender, EventArgs e)
        {

        }
    }
}
