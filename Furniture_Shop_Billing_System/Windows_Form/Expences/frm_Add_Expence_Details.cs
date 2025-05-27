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

namespace Furniture_Shop_Billing_System.Windows_Form.Expences
{
    public partial class frm_Add_Expence_Details : Form
    {
        public frm_Add_Expence_Details()
        {
            InitializeComponent();
        }
        void Clear_Controls()
        {
            tb_Expence_Id.Text = Convert.ToString(Shared_Content.Auto_Incr("Expence_Details", "Expence_Id", 1001));
            tb_Expence_Id.Clear();
            dtp_Date.ResetText();
            tb_Expence_Details.Clear();
            tb_Total_Amount.Clear();
            cmb_Payment_Mode.SelectedIndex = -1;
            pb_Bill_Image.Image = null;

        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            Shared_Content.con_open();

            if (tb_Expence_Id.Text != "" && tb_Expence_Details.Text != "" && tb_Total_Amount.Text != "")
            {
                SqlCommand Cmd = new SqlCommand("Insert Into Expence_Details values (@Eid,@Edtp,@Ed,@Eta,@Epm,@Ebi)", Shared_Content.con);

                Cmd.Parameters.Add("@Eid", SqlDbType.Int).Value = tb_Expence_Id.Text;
                Cmd.Parameters.Add("@Edtp", SqlDbType.Date).Value = dtp_Date.Text;
                Cmd.Parameters.Add("@Ed", SqlDbType.NVarChar).Value = tb_Expence_Details.Text;
                Cmd.Parameters.Add("@Eta", SqlDbType.Money).Value = tb_Total_Amount.Text;
                Cmd.Parameters.Add("@Epm", SqlDbType.NVarChar).Value = cmb_Payment_Mode.Text;
                
                
                ImageConverter IC = new ImageConverter();

                byte[] imgArray = (byte[])IC.ConvertTo(pb_Bill_Image.Image, typeof(byte[]));

                Cmd.Parameters.Add("@Ebi", SqlDbType.Image).Value = imgArray;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Expence Details Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Controls();
            }
            else
            {
                MessageBox.Show("Fill All The Fields", "Fill Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Shared_Content.con_close();
        }
        private void btn_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();

            OFD.Filter = "Bill_Image(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";

            if (OFD.ShowDialog() == DialogResult.OK)
            {
                pb_Bill_Image.Image = new Bitmap(OFD.FileName);
            }
        }

        private void frm_Add_Expence_Details_Load(object sender, EventArgs e)
        {
            tb_Expence_Id.Text = Convert.ToString(Shared_Content.Auto_Incr("Expence_Details", "Expence_Id", 1001));
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            DialogResult Res = System.Windows.Forms.DialogResult.Yes;

            if (tb_Expence_Details.Text != "" ||tb_Total_Amount.Text != "" || cmb_Payment_Mode.Text != "")
            {
                Res = MessageBox.Show("Are You Sure Date Enterd Will Be Lost", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }

            if (Res == System.Windows.Forms.DialogResult.Yes)
            {
                Clear_Controls();
            }

        }
        private void tb_Total_Amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Content.Only_Numeric(e);
        }

        private void tb_Remaining_Amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Content.Only_Numeric(e);
        }

        private void tb_Paid_Amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Content.Only_Numeric(e);
        }
    }
}


    

