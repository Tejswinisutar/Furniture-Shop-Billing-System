using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Furniture_Shop_Billing_System
{
    internal class Shared_Content
    {
        public static SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Furniture_Shop_Billing_System.db;Integrated Security=True");
        public static String LoggedInUname = "Admin";
        public static int UserRole = 0;

        public static int OrderID = -1;
        public static string S_Nm = "";
        public static double FBill;
        public static int Order_Id = 0;
        public static int Cust_Id = 0;
        public static void con_open()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
        }
        public static void con_close()
        {
            if (con.State != ConnectionState.Closed )
            {
                con.Close();
            }
        }
        public static void Only_Numeric( KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }
        public static void Only_Text( KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == (char)Keys.ShiftKey) || (e.KeyChar == (char)Keys.CapsLock)))
            {
                e.Handled = true;
            }
        }
        public static int Auto_Incr(string Table_Name, string ID_Field_Name, int Start_Point)
        {
            con_open();

            int Cnt = 0;

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = con;
            Cmd.CommandText = "Select Count(*) From " + Table_Name + "";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            if (Cnt > 0)
            {
                Cmd.Dispose();

                Cmd.Connection = con;
                Cmd.CommandText = "Select Max(" + ID_Field_Name + ") From " + Table_Name + "";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

                Cnt += 1;
            }
            else
            {
                Cnt = Start_Point;
            }

            con_close();
            return Cnt;
        }
        public static void Bind_Grid(DataGridView DGV, string Query)
        {
            con_open();

            SqlDataAdapter SDA = new SqlDataAdapter(Query, con);

            DataTable dt = new DataTable();

            SDA.Fill(dt);

            DGV.DataSource = dt;

            con_close();
        }
        public static void Bind_ComboBox(string ColumnName, ComboBox CMB, string Query)
        {
            con_open();

            CMB.Items.Clear();

            SqlCommand Cmd = new SqlCommand(Query, con);

            SqlDataReader Dr = Cmd.ExecuteReader();

            while (Dr.Read())
            {
                CMB.Items.Add(Dr.GetString(Dr.GetOrdinal(ColumnName)));
            }

            Dr.Dispose();
            con_close();
        }
    }
}


        

    

