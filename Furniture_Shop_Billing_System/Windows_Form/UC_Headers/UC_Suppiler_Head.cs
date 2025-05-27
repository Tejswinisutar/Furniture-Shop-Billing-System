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
    public partial class UC_Suppiler_Head : UserControl
    {
        public UC_Suppiler_Head()
        {
            InitializeComponent();
        }

        private void btn_Add_Suppiler_Click(object sender, EventArgs e)
        {
            Windows_Form.Suppiler.frm_Add_Suppiler_Details obj = new Suppiler.frm_Add_Suppiler_Details() { TopLevel = false, TopMost = true };
            obj.FormBorderStyle = FormBorderStyle.None;

            frm_Main_Form.pnl_Container.Controls.Clear();
            frm_Main_Form.pnl_Container.Controls.Add(obj);
            obj.Show();
        }

        private void btn_Update_Suppiler_Click(object sender, EventArgs e)
        {
            Windows_Form.Suppiler.frm_Update_Supplier_Details obj = new Suppiler.frm_Update_Supplier_Details() { TopLevel = false, TopMost = true };
            obj.FormBorderStyle = FormBorderStyle.None;

            frm_Main_Form.pnl_Container.Controls.Clear();
            frm_Main_Form.pnl_Container.Controls.Add(obj);
            obj.Show();
        }

        private void UC_Suppiler_Head_Load(object sender, EventArgs e)
        {

        }

        private void btn_View_List_Click(object sender, EventArgs e)
        {
            Windows_Form.Suppiler.frm_Supplier_View_List obj = new Suppiler.frm_Supplier_View_List { TopLevel = false, TopMost = true };

            obj.FormBorderStyle = FormBorderStyle.None;

            frm_Main_Form.pnl_Container.Controls.Clear();
            frm_Main_Form.pnl_Container.Controls.Add(obj);

            obj.Show();
        }
    }
}
