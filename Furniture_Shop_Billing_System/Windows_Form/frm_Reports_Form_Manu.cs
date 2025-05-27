using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Furniture_Shop_Billing_System.Windows_Form
{
    public partial class frm_Reports_Form_Manu : Form
    {
        public frm_Reports_Form_Manu()
        {
            InitializeComponent();
        }

        private void pb_Customer_Click(object sender, EventArgs e)
        {
            Reports.ReportForms.frm_Customer_Montnhly_List obj = new Reports.ReportForms.frm_Customer_Montnhly_List();
            obj.Show();
        }

        private void pb_Product_Click(object sender, EventArgs e)
        {
            Reports.ReportForms.frm_Product_List obj = new Reports.ReportForms.frm_Product_List();
            obj.Show();
        }

        private void pb_Order_Click(object sender, EventArgs e)
        {
            Reports.ReportForms.frm_Order_Payments obj = new Reports.ReportForms.frm_Order_Payments();
            obj.Show();
        }

        private void pb_Receive_Order_Click(object sender, EventArgs e)
        {
            Reports.ReportForms.frm_Receive_Order obj = new Reports.ReportForms.frm_Receive_Order();
            obj.Show();
        }

        private void Pb_Expence_Click(object sender, EventArgs e)
        {
            Reports.ReportForms.frm_Receive_Order obj = new Reports.ReportForms.frm_Receive_Order();
            obj.Show();
        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            Reports.ReportForms.frm_Customer_Montnhly_List obj = new Reports.ReportForms.frm_Customer_Montnhly_List();
            obj.Show();
        }

        private void btn_Product_Click(object sender, EventArgs e)
        {
            Reports.ReportForms.frm_Product_List obj = new Reports.ReportForms.frm_Product_List();
            obj.Show();
        }

        private void btn_Order_Click(object sender, EventArgs e)
        {
            Reports.ReportForms.frm_Order_Payments obj = new Reports.ReportForms.frm_Order_Payments();
            obj.Show();
        }

        private void btn_Receive_Order_Click(object sender, EventArgs e)
        {
            Reports.ReportForms.frm_Receive_Order obj = new Reports.ReportForms.frm_Receive_Order();
            obj.Show();
        }

        private void btn_Expence_Click(object sender, EventArgs e)
        {
            Reports.ReportForms.frm_Receive_Order obj = new Reports.ReportForms.frm_Receive_Order();
            obj.Show();
        }
    }
}
