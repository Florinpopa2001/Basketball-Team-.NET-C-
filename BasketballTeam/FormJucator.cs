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

namespace laborator_8
{
    public partial class FormJucator : Form
    {
        DataTable dt = new DataTable();
        public void LoadData()
        {
            // informatii despre conexiune si interogare
            String connectionString = "Data Source=localhost; database = online_tv; Integrated Security = True";
        String query = "SELECT Jucatori.* FROM Jucatori";
            // initializari ale comexiunii, comenzii SQL si adaptorului
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            // preluarea datelor
            con.Open();
            adapter.Fill(dt);
            con.Close();
            // curatarea memoriei alocate obiectelor care nu mai sunt folosite
            adapter.Dispose();
            cmd.Dispose();
            con.Dispose();
        }
        public class MyJucator
        {
            public int id;
            public string nume;
            public override string ToString()
            {
                return nume;
            }
        }
        public void ShowJucatori()
        {
            int i;
            for (i = 0; i < dt.Rows.Count; i++)
            {
                MyJucator jucator = new MyJucator();
                jucator.id = Convert.ToInt32(dt.Rows[i]["id_jucator"]);
                jucator.nume = Convert.ToString(dt.Rows[i]["nume"]);
                listBox1.Items.Add(jucator);
            }

     
        }

        public FormJucator()
        {
            InitializeComponent();
        }
        private void FormJucator_Load(object sender, EventArgs e)
        {
            LoadData();
            ShowJucatori();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            string info = "";
            int i;
            if (dt.Rows.Count > 0 && index >= 0)
            {
                for (i = 0; i < dt.Columns.Count; i++)
                {
                    info += dt.Columns[i].ColumnName + ": " +
                    dt.Rows[index][dt.Columns[i].ColumnName] + "\r\n";
                }
            }
            textBox1.Text = info;
        }
        public void ClearAll()
        {
            dt = new DataTable();
            listBox1.Items.Clear();
            textBox1.Text = "";
        }
        public void RefreshData()
        {
            ClearAll();
            LoadData();
            ShowJucatori();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdAdd_Click_1(object sender, EventArgs e)
        {
            FormAddJucator FormAddMovie = new FormAddJucator();
            FormAddMovie.ShowDialog();
            if (FormAddMovie.isUpdated) RefreshData();
        }

        private void cmdRemove_Click_1(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            if (i < 0) return;
            else
            {
                String id_jucator = dt.Rows[i][dt.Columns[0].ColumnName].ToString();
                // informatii despre conexiune si interogare
                String connectionString = "Data Source=localhost;database = online_tv; " +
                    "Integrated Security = True";
                String query = "DELETE FROM Jucatori WHERE id_jucator=@id_jucator";
                // initializari ale comexiunii, comenzii SQL si adaptorului
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id_jucator", id_jucator);
                // preluarea datelor
                con.Open();
                cmd.ExecuteReader();
                con.Close();
                // curatarea memoriei alocate obiectelor care nu mai sunt folosite
                cmd.Dispose();
                con.Dispose();
                RefreshData();
            }
        }
    }
}

    