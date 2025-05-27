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
    public partial class UC_Employee_Head : UserControl
    {
        public object FromBorderStyle { get; private set; }

        public UC_Employee_Head()
        {
            InitializeComponent();
        }

        private void btn_Add_Employee_Click_1(object sender, EventArgs e)
        {
            Windows_Form.Employee.frm_Add_Employee_Details obj = new Employee.frm_Add_Employee_Details() { TopLevel = false, TopMost = true };

            obj.FormBorderStyle = FormBorderStyle.None;

            frm_Main_Form.pnl_Container.Controls.Clear();
            frm_Main_Form.pnl_Container.Controls.Add(obj);

            obj.Show();
        }

        private void btn_Update_Employee_Click_1(object sender, EventArgs e)
        {
            Windows_Form.Employee.frm_Update_Employee_Details obj = new Employee.frm_Update_Employee_Details() { TopLevel = false, TopMost = true };

            obj.FormBorderStyle = FormBorderStyle.None;

            frm_Main_Form.pnl_Container.Controls.Clear();
            frm_Main_Form.pnl_Container.Controls.Add(obj);

            obj.Show();
        }

        private void UC_Employee_Head_Load(object sender, EventArgs e)
        {

        }

        private void btn_View_List_Click(object sender, EventArgs e)
        {
            Windows_Form.Employee.frm_Employee_View_List obj = new Employee.frm_Employee_View_List() { TopLevel = false, TopMost = true };

            obj.FormBorderStyle = FormBorderStyle.None;

            frm_Main_Form.pnl_Container.Controls.Clear();
            frm_Main_Form.pnl_Container.Controls.Add(obj);

            obj.Show();
        }
    }
}
