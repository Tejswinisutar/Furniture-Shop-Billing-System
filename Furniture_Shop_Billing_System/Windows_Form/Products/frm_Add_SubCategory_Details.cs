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

namespace Furniture_Shop_Billing_System.Windows_Form.Products
{
    public partial class frm_Add_SubCategory_Details : Form
    {
        public frm_Add_SubCategory_Details()
        {
            InitializeComponent();
        }

        private void frm_Add_SubCategory_Details_Load(object sender, EventArgs e)
        {
            tb_SubCategory_Id.Text = Convert.ToString(Shared_Content.Auto_Incr("SubCategory_Details", "SubCategory_Id", 301));
            Shared_Content.Bind_ComboBox("Category_Name", cmb_Category_Name, "Select Distinct(Category_Name)From Category_Details");
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Shared_Content.con_open();

            if(tb_SubCategory_Id.Text!="" && cmb_Category_Name.Text!="")
            {
                SqlCommand cmd = new SqlCommand("Insert Into SubCategory_Details values (@Sid,@Cnm,@Snm) ", Shared_Content.con);

                cmd.Parameters.Add("@Sid", SqlDbType.Int).Value = tb_SubCategory_Id.Text;
                cmd.Parameters.Add("@Snm", SqlDbType.NVarChar).Value = tb_SubCategory_Name.Text;
                cmd.Parameters.Add("@Cnm", SqlDbType.NVarChar).Value = cmb_Category_Name.Text;

                cmd.ExecuteNonQuery();

                MessageBox.Show("SubCategory Details Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tb_SubCategory_Name.Clear();
                cmb_Category_Name.SelectedIndex = -1;

            }
            else
            {
                MessageBox.Show("Fill All The Fields", "Fill Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Shared_Content.con_close();
        }
    }
}

