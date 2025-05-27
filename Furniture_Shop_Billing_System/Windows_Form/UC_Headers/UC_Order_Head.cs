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
    public partial class UC_Order_Head : UserControl
    {
        public UC_Order_Head()
        {
            InitializeComponent();
        }

        private void btn_Order_Payment_Click(object sender, EventArgs e)
        {
            Windows_Form.Order.frm_Order_Payment obj = new Order.frm_Order_Payment() { TopLevel = false, TopMost = true };
            obj.FormBorderStyle = FormBorderStyle.None;

            frm_Main_Form.pnl_Container.Controls.Clear();
            frm_Main_Form.pnl_Container.Controls.Add(obj);
            obj.Show();
        }

        private void btn_Receive_Order_Click(object sender, EventArgs e)
        {
            Windows_Form.Order.frm_Receive_Order obj = new Order.frm_Receive_Order() { TopLevel = false, TopMost = true };
            obj.FormBorderStyle = FormBorderStyle.None;

            frm_Main_Form.pnl_Container.Controls.Clear();
            frm_Main_Form.pnl_Container.Controls.Add(obj);
            obj.Show();
        }

        private void UC_Order_Head_Load(object sender, EventArgs e)
        {

        }
    }
}
