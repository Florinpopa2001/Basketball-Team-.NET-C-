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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace laborator_8
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=online_tv;Integrated Security=True");

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string queryy = "INSERT INTO Members (u_name, cont, gmail, pass_w ) VALUES " +
                    "('" + txt_mem_us.Text + "', '" + txt_mem_cont.Text + "', '" + 
                    txt_gmail.Text + "', '" + txt_mem_pw.Text + "')   ";

                SqlDataAdapter sda = new SqlDataAdapter(queryy, conn);
                sda.SelectCommand.ExecuteReader();
                MessageBox.Show("New User is successfully registered");

                //loading the next form if both user name and password are correct

                LogIn logPage = new LogIn();
                logPage.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in registering" + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txt_gmail.Clear();
            txt_mem_cont.Clear();
            txt_mem_pw.Clear();
            txt_mem_us.Clear();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                txt_mem_pw.UseSystemPasswordChar = false;
            }
            else
            {
                txt_mem_pw.UseSystemPasswordChar = true;

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LogIn logIn2 = new LogIn();
            logIn2.Show();
            this.Hide();
        }
    }
}
