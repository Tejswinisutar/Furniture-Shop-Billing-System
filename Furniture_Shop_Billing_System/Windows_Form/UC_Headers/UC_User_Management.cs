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
    public partial class UC_User_Management : UserControl
    {
        public UC_User_Management()
        {
            InitializeComponent();
        }

        public FormBorderStyle FormBorderStyle { get; internal set; }

        private void btn_Add_User_Click(object sender, EventArgs e)
        {
            Windows_Form.User_Management.frm_Add_User obj = new User_Management.frm_Add_User() { TopLevel = false, TopMost = true };
            obj.FormBorderStyle = FormBorderStyle.None;

            frm_Main_Form.pnl_Container.Controls.Clear();
            frm_Main_Form.pnl_Container.Controls.Add(obj);
            obj.Show();
        }

        private void btn_Update_User_Click(object sender, EventArgs e)
        {
            Windows_Form.User_Management.frm_Update_User obj = new User_Management.frm_Update_User() { TopLevel = false, TopMost = true };
            obj.FormBorderStyle = FormBorderStyle.None;

            frm_Main_Form.pnl_Container.Controls.Clear();
            frm_Main_Form.pnl_Container.Controls.Add(obj);
            obj.Show();
        }
       
    }
}
