using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Furniture_Shop_Billing_System.Windows_Form.Customer
{
    public partial class frm_Customer_View_List : Form
    {
        public frm_Customer_View_List()
        {
            InitializeComponent();
        }

        private void frm_Customer_View_List_Load(object sender, EventArgs e)
        {
            btn_Refresh.PerformClick();
        }

        private void cmb_Month_SelectedIndexChanged(object sender, EventArgs e)
        {
            int C_Month = cmb_Month.SelectedIndex + 1;
            int C_Year = Convert.ToInt32(cmb_Year.Text);

            Shared_Content.Bind_Grid(dgv_Customer_List, "Select * From Customer_Details Where Month(Date) = " + C_Month + "And Year(Date) = " + C_Year + " ");
        }

        private void cmb_Year_SelectedIndexChanged(object sender, EventArgs e)
        {
            int C_Month = cmb_Month.SelectedIndex + 1;
            int C_Year = Convert.ToInt32(cmb_Year.Text);

            Shared_Content.Bind_Grid(dgv_Customer_List, "Select * From Customer_Details Where Month(Date) = " + C_Month + " And Year(Date) = " + C_Year + " ");
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            int C_Month = System.DateTime.Today.Month;
            int C_Year = System.DateTime.Today.Year;
            //int CDay = System.DateTime.Today.Day;
            //string CDayText = System.DateTime.Today.DayOfWeek.ToString();

            cmb_Year.Text = Convert.ToString(C_Year);
            cmb_Month.SelectedIndex = C_Month - 1;

            Shared_Content.Bind_Grid(dgv_Customer_List, "Select * From Customer_Details Where Month(Date) = " + C_Month + " And Year(Date) = " + C_Year + " ");
        }

        private void dgv_Customer_List_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
