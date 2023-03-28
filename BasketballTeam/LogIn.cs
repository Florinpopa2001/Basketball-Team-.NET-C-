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
    public partial class LogIn : Form
    {

        public string uName, uPass;

        public LogIn()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=online_tv;Integrated Security=True");



        private void LogIn_Load(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
                txt_pw.Clear();
                txt_usn.Clear();
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txt_pw.UseSystemPasswordChar = false;
            }
            else
            {
                txt_pw.UseSystemPasswordChar = true;

            }
        }


        private void label2_Click(object sender, EventArgs e)
        {
            Register registerpage = new Register();
            registerpage.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string user_name, pw;
            user_name = txt_usn.Text;
            pw = txt_pw.Text;
            try
            {
                conn.Open();
                string login = "SELECT * FROM Members WHERE u_name = '"+txt_usn.Text+"' " +
                                                    "AND pass_w = '" + txt_pw.Text + "'   ";
                SqlDataAdapter sqlog = new SqlDataAdapter(login, conn);
                DataTable dt = new DataTable();
                sqlog.Fill(dt);

                if(dt.Rows.Count > 0)
                {
                    user_name = txt_usn.Text;
                    pw = txt_pw.Text;

                    //loading the next form if both user name and password are correct
                    FormStart frm1 = new FormStart();
                    frm1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("The Username or Password is incorrect.Try again!");
                    txt_usn.Clear();
                    txt_pw.Clear();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error in login process" + ex);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
