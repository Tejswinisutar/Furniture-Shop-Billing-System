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

namespace Furniture_Shop_Billing_System.Reports.ReportForms
{
    public partial class frm_Customer_Bill : Form
    {
        public frm_Customer_Bill()
        {
            InitializeComponent();
        }

        private void frm_Customer_Purchase_List_Load(object sender, EventArgs e)
        {
            Shared_Content.con_open();

            SqlDataAdapter sqlDa = new SqlDataAdapter("SP_Customer_Bill", Shared_Content.con);

            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@Cid", Shared_Content.Cust_Id);

            DataTable dtbl = new DataTable();

            sqlDa.Fill(dtbl);

            Shared_Content.con_close();

            Reports.CrystalReports.crpt_Customrer_Bill cr_Bill = new CrystalReports.crpt_Customrer_Bill();
            cr_Bill.Database.Tables["SP_Customer_Bill"].SetDataSource(dtbl);

            crv_Customer_Bill.ReportSource = null;

            crv_Customer_Bill.ReportSource = cr_Bill;
        }
    }
}
