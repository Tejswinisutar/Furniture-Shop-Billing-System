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
    public partial class frm_Add_Category_Details : Form
    {
        public frm_Add_Category_Details()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Shared_Content.con_open();

            if (tb_Category_Id.Text != "" && tb_Category_Name.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Insert Into Category_Details values (@Cid,@Cnm)", Shared_Content.con);

                cmd.Parameters.Add("@Cid", SqlDbType.Int).Value = tb_Category_Id.Text;
                cmd.Parameters.Add("@Cnm", SqlDbType.VarChar).Value = tb_Category_Name.Text;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Category Details Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Fill All The Fields", "Fill Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Shared_Content.con_close();
        }

        private void frm_Add_Category_Details_Load(object sender, EventArgs e)
        {
            tb_Category_Id.Text = Convert.ToString(Shared_Content.Auto_Incr("Category_Details", "Category_Id", 201));
        }
    }
}

