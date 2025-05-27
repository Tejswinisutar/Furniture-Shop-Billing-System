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
    public partial class frm_Customer_Montnhly_List : Form
    {
        public frm_Customer_Montnhly_List()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Shared_Content.con_open();

            SqlDataAdapter sqlDa = new SqlDataAdapter("SP_Customer_Monthly_List", Shared_Content.con);
            sqlDa.SelectCommand.Parameters.AddWithValue("@Sdt", dtp_Fdt.Value);
            sqlDa.SelectCommand.Parameters.AddWithValue("@Edt", dtp_Todt.Value);

            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dtbl = new DataTable();

            sqlDa.Fill(dtbl);

            Shared_Content.con_close();

            Reports.CrystalReports.crpt_Customer_Monthly_List cr_Customer_Monthly = new Reports.CrystalReports.crpt_Customer_Monthly_List();
            cr_Customer_Monthly.Database.Tables["SP_Customer_Monthly_List"].SetDataSource(dtbl);

            crv_Customer_View_List.ReportSource = null;

            crv_Customer_View_List.ReportSource = cr_Customer_Monthly;
        }
    }
}
