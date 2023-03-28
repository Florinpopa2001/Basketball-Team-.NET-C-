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
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace laborator_8
{
    public partial class Profil : Form
    {
        public Profil()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=online_tv;Integrated Security=True");

            string sql = "select * from Members where id_membru='" + textBox1.Text + "'  ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();

            using(SqlDataReader dr = cmd.ExecuteReader())
            {

                if (dr.Read())
                {
                    label6.Text = dr["u_name"].ToString();
                    label7.Text = dr["cont"].ToString();
                    label8.Text = dr["gmail"].ToString();
                }
            }
            
        }

        private void Profil_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
