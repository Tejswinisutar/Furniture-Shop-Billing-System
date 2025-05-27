using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Furniture_Shop_Billing_System.Windows_Form.Suppiler
{
    public partial class frm_Supplier_View_List : Form
    {
        public frm_Supplier_View_List()
        {
            InitializeComponent();
        }

        private void frm_Supplier_View_List_Load(object sender, EventArgs e)
        {
            Shared_Content.Bind_Grid(dgv_Supplier_List, "Select Supplier_Id, Supplier_Name, Mobile_No, Aadhar_No, Bank_Name From Supplier_Details");
        }
    }
}
