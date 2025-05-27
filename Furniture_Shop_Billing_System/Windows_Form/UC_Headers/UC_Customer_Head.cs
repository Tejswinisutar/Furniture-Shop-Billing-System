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
    public partial class UC_Customer_Head : UserControl
    {
        public UC_Customer_Head()
        {
            InitializeComponent();
        }

        private void btn_Add_Customer_Click(object sender, EventArgs e)
        {
            Windows_Form.Customer.frm_Add_Customer_Details obj = new Customer.frm_Add_Customer_Details() { TopLevel = false, TopMost = true };
            obj.FormBorderStyle = FormBorderStyle.None;

            frm_Main_Form.pnl_Container.Controls.Clear();
            frm_Main_Form.pnl_Container.Controls.Add(obj);
            obj.Show();
        }

        private void btn_View_List_Click(object sender, EventArgs e)
        {
            Windows_Form.Customer.frm_Customer_View_List obj = new Customer.frm_Customer_View_List() { TopLevel = false, TopMost = true };
            obj.FormBorderStyle = FormBorderStyle.None;

            frm_Main_Form.pnl_Container.Controls.Clear();
            frm_Main_Form.pnl_Container.Controls.Add(obj);
            obj.Show();
        }
    }
}
