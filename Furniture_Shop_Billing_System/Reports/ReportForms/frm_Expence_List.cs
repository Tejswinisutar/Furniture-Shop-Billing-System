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
    public partial class frm_Expence_List : Form
    {
        public frm_Expence_List()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {

            Shared_Content.con_open();

            SqlDataAdapter sqlDa = new SqlDataAdapter("SP_Expence_List", Shared_Content.con);
            sqlDa.SelectCommand.Parameters.AddWithValue("@Sdt", dtp_Fdt.Value);
            sqlDa.SelectCommand.Parameters.AddWithValue("@edt", dtp_Todt.Value);

            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;



            DataTable dtbl = new DataTable();

            sqlDa.Fill(dtbl);

            Shared_Content.con_close();

            Reports.CrystalReports.crpt_Expence_List crpt_Expence = new Reports.CrystalReports.crpt_Expence_List();
            crpt_Expence.Database.Tables["SP_Expence_List"].SetDataSource(dtbl);

            crv_Expence_List.ReportSource = null;

            crv_Expence_List.ReportSource = crpt_Expence;
        }
    }
}
