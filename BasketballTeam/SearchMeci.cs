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

namespace laborator_8
{
    public partial class SearchMeci : Form
    {
        public SearchMeci()
        {
            InitializeComponent();
        }
        
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "DIVIZIA")
            { 

                SqlConnection conn = new SqlConnection("Data Source=localhost;Initial " + "Catalog=online_tv;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("SELECT divizia, data_timp, adversar, invingator, " + "puncte ,uploader_id FROM Meciuri where divizia like '" + textBox1.Text + "%'" , conn);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }else if(comboBox1.Text == "ADVERSAR")
            {
                SqlConnection conn = new SqlConnection("Data Source=localhost;Initial " + "Catalog=online_tv;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("SELECT divizia, data_timp, adversar, " + "invingator, puncte ,uploader_id FROM Meciuri where adversar like '" + textBox1.Text + "%'", conn);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
    }
}
