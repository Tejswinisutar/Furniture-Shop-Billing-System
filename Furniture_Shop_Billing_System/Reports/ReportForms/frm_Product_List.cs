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
    public partial class frm_Product_List : Form
    {
        public frm_Product_List()
        {
            InitializeComponent();
        }

        private void frm_Product_List_Load(object sender, EventArgs e)
        {
            Shared_Content.con_open();

            SqlDataAdapter sqlDa = new SqlDataAdapter("SP_Product_Details", Shared_Content.con);

            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dtbl = new DataTable();

            sqlDa.Fill(dtbl);

            Shared_Content.con_close();

            CrystalReports.crpt_Product_Details cr_Product = new CrystalReports.crpt_Product_Details();

            cr_Product.Database.Tables["SP_Product_Details"].SetDataSource(dtbl);

            crv_Product_List.ReportSource = null;

            crv_Product_List.ReportSource = cr_Product;
        }
    }
}
