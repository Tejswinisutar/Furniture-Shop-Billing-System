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
    public partial class frm_Receive_Order : Form
    {
        public frm_Receive_Order()
        {
            InitializeComponent();
        }

        private void frm_Receive_Order_Load(object sender, EventArgs e)
        {
            Shared_Content.con_open();

            SqlDataAdapter sqlDa = new SqlDataAdapter("SP_Receive_Order", Shared_Content.con);

            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dtbl = new DataTable();

            sqlDa.Fill(dtbl);

            Shared_Content.con_close();

            Reports.CrystalReports.crpt_Receive_Order cr_Receive_Order = new CrystalReports.crpt_Receive_Order();
            cr_Receive_Order.Database.Tables["SP_Receive_Order"].SetDataSource(dtbl);

            crv_Receive_Order.ReportSource = null;

            crv_Receive_Order.ReportSource = cr_Receive_Order;
        }
    }
}
