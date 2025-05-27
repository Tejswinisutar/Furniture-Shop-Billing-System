using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Furniture_Shop_Billing_System
{
    public partial class frm_Main_Form : Form
    {
        public frm_Main_Form()
        {
            InitializeComponent();
        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            Windows_Form.Customer.frm_Add_Customer_Details obj = new Windows_Form.Customer.frm_Add_Customer_Details() { TopLevel = false, TopMost = true };
            obj.FormBorderStyle = FormBorderStyle.None;

            pnl_Container.Controls.Clear();
            pnl_Container.Controls.Add(obj);
            obj.Show();

           Windows_Form.UC_Headers.UC_Customer_Head UC = new Windows_Form.UC_Headers.UC_Customer_Head();
            pnl_Header.Controls.Clear();
            pnl_Header.Controls.Add(UC);
            UC.Show();  
        }

        private void btn_Product_Click(object sender, EventArgs e)
        {
            Windows_Form.Products.frm_Add_Category_Details obj = new Windows_Form.Products.frm_Add_Category_Details() { TopLevel = false, TopMost = true };
            obj.FormBorderStyle = FormBorderStyle.None;

            pnl_Container.Controls.Clear();
            pnl_Container.Controls.Add(obj);
            obj.Show();

            Windows_Form.UC_Headers.UC_Product_Head UC = new Windows_Form.UC_Headers.UC_Product_Head();
            pnl_Header.Controls.Clear();
            pnl_Header.Controls.Add(UC);
            UC.Show();
        }

        private void btn_Employee_Click(object sender, EventArgs e)
        {
            Windows_Form.Employee.frm_Add_Employee_Details obj = new Windows_Form.Employee.frm_Add_Employee_Details() { TopLevel = false, TopMost = true };
            obj.FormBorderStyle = FormBorderStyle.None;

            pnl_Container.Controls.Clear();
            pnl_Container.Controls.Add(obj);
            obj.Show();

            Windows_Form.UC_Headers.UC_Employee_Head UC = new Windows_Form.UC_Headers.UC_Employee_Head();
            pnl_Header.Controls.Clear();
            pnl_Header.Controls.Add(UC);
            UC.Show();
        }

        private void btn_Suppiler_Click(object sender, EventArgs e)
        {
            Windows_Form.Suppiler.frm_Add_Suppiler_Details obj = new Windows_Form.Suppiler.frm_Add_Suppiler_Details() { TopLevel = false, TopMost = true };
            obj.FormBorderStyle = FormBorderStyle.None;

            pnl_Container.Controls.Clear();
            pnl_Container.Controls.Add(obj);
            obj.Show();

            Windows_Form.UC_Headers.UC_Suppiler_Head UC = new Windows_Form.UC_Headers.UC_Suppiler_Head();
            pnl_Header.Controls.Clear();
            pnl_Header.Controls.Add(UC);
            UC.Show();
        }

        private void btn_Expences_Click(object sender, EventArgs e)
        {
            Windows_Form.Expences.frm_Add_Expence_Details obj = new Windows_Form.Expences.frm_Add_Expence_Details() { TopLevel = false, TopMost = true };
            obj.FormBorderStyle = FormBorderStyle.None;

            pnl_Container.Controls.Clear();
            pnl_Container.Controls.Add(obj);
            obj.Show();

            Windows_Form.UC_Headers.UC_Expence_Head UC = new Windows_Form.UC_Headers.UC_Expence_Head();
            pnl_Header.Controls.Clear();
            pnl_Header.Controls.Add(UC);
            UC.Show();
        }
        private void btn_User_Management_Click_1(object sender, EventArgs e)
        {
            Windows_Form.User_Management.frm_Add_User obj = new Windows_Form.User_Management.frm_Add_User() { TopLevel = false, TopMost = true };

            obj.FormBorderStyle = FormBorderStyle.None;

            pnl_Container.Controls.Clear();
            pnl_Container.Controls.Add(obj);
            obj.Show();

            Windows_Form.UC_Headers.UC_User_Management UC = new Windows_Form.UC_Headers.UC_User_Management();
            pnl_Header.Controls.Clear();
            pnl_Header.Controls.Add(UC);
            UC.Show();
        }

        private void btn_Order_Click(object sender, EventArgs e)
        {
            Windows_Form.Order.frm_Receive_Order obj = new Windows_Form.Order.frm_Receive_Order() { TopLevel = false, TopMost = true };
            obj.FormBorderStyle = FormBorderStyle.None;

            pnl_Container.Controls.Clear();
            pnl_Container.Controls.Add(obj);
            obj.Show();

            Windows_Form.UC_Headers.UC_Order_Head UC = new Windows_Form.UC_Headers.UC_Order_Head();
            pnl_Header.Controls.Clear();
            pnl_Header.Controls.Add(UC);
            UC.Show();
        }

        private void frm_Main_Form_Load(object sender, EventArgs e)
        {
            btn_Admin.Text = Shared_Content.LoggedInUname;
        }

        private void btn_Admin_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Are You Sure Do You Want to Logout???", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if(Res == DialogResult.OK)
            {
                frm_Login obj = new frm_Login();
                obj.Show();
                this.Hide();
            }
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            Windows_Form.frm_Reports_Form_Manu obj = new Windows_Form.frm_Reports_Form_Manu() { TopLevel = false, TopMost = true };
            obj.FormBorderStyle = FormBorderStyle.None;

            pnl_Container.Controls.Clear();
            pnl_Container.Controls.Add(obj);
            obj.Show();

            Windows_Form.UC_Headers.UC_Reports_Header UC = new Windows_Form.UC_Headers.UC_Reports_Header();
            pnl_Header.Controls.Clear();
            pnl_Header.Controls.Add(UC);
            UC.Show();
        }
    }
}
