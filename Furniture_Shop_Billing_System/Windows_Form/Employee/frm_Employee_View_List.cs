using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Furniture_Shop_Billing_System.Windows_Form.Employee
{
    public partial class frm_Employee_View_List : Form
    {
        public frm_Employee_View_List()
        {
            InitializeComponent();
        }

        private void frm_Employee_View_List_Load(object sender, EventArgs e)
        {
            Shared_Content.Bind_Grid(dgv_Employee_List, "Select Employee_Id , Employee_Name, Mobile_No, Aadhar_No, Designation, Bank_Name From Employee_Details");

        }

        private void dgv_Employee_List_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
