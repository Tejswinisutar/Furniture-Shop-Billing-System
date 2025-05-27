using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Furniture_Shop_Billing_System.Reports.ReportForms
{
    public partial class frm_Order_Payments : Form
    {
        public frm_Order_Payments()
        {
            InitializeComponent();
        }

        private void frm_Order_Payments_Load(object sender, EventArgs e)
        {
           
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            Shared_Content.con_open();

            SqlDataAdapter sqlDa = new SqlDataAdapter("Sp_Order_Payment", Shared_Content.con);

            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@Sdt", dtp_Fdt.Value);
            sqlDa.SelectCommand.Parameters.AddWithValue("@Edt", dtp_Todt.Value);


            DataTable dtbl = new DataTable();

            sqlDa.Fill(dtbl);

            Shared_Content.con_close();

            Reports.CrystalReports.crpt_Order_Details cr_order = new CrystalReports.crpt_Order_Details();
            cr_order.Database.Tables["Sp_Order_Payment"].SetDataSource(dtbl);

            crv_Order_Payments.ReportSource = null;

            crv_Order_Payments.ReportSource = cr_order;
        }
    }
}
