using System.Data.SqlClient;

namespace laborator_8
{
    public partial class FormAddJucator : Form
    {
        public FormAddJucator()
        {
            InitializeComponent();
        }
        private Boolean StringIsEmpty(String text)
        {
            return String.IsNullOrWhiteSpace(text);
        }
        private void AllowOnlyNumbers(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled =
            true;
        }
        public Boolean isUpdated = false;

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            // datele introduse de utilizator
            String numele = txtNume.Text;
            String prenumele = txtPrenume.Text;
            String postul = txtPost.Text;
            String greutatea = txtGreutate.Text;
            String inaltimea = txtInaltime.Text;
            // validare completare campuri
            if (StringIsEmpty(numele) || StringIsEmpty(prenumele) ||
            StringIsEmpty(greutatea) || StringIsEmpty(inaltimea) || StringIsEmpty(postul))
            {
                MessageBox.Show("Introduceți date în toate câmpurile!", "Eroare",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                // informatii despre conexiune si interogare
                String connectionString = "Data Source=localhost;database = online_tv; Integrated Security = True";
            String query = "INSERT into Jucatori" +
            " (nume, data_nastere , prenume,post, inaltime, greutate) " + "VALUES (@numele, @dNastere, @prenumele, @postul, @inaltimea,@greutatea)";
            // initializari ale comexiunii, comenzii SQL si adaptorului
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@numele", numele);
                cmd.Parameters.AddWithValue("@dNastere",
                dtpDate.Value.ToString("yyy-MM-dd HH:mm"));
                cmd.Parameters.AddWithValue("@prenumele", prenumele);
                cmd.Parameters.AddWithValue("@postul", postul);
                cmd.Parameters.AddWithValue("@greutatea", greutatea);
                cmd.Parameters.AddWithValue("@inaltimea", inaltimea);
                // preluarea datelor
                con.Open();
                cmd.ExecuteReader();
                con.Close();
                // curatarea memoriei alocate obiectelor care nu mai sunt folosite
                cmd.Dispose();
                con.Dispose();
                this.Close();
                this.isUpdated = true;

            }
        }
        private void txtDuration_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyNumbers(e);
        }

        private void cmdRemove_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    
    

        private void txtUploaderId_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtDuration_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            AllowOnlyNumbers(e);
        }

        private void txtUploaderId_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            AllowOnlyNumbers(e);
        }

        private void txtFrameHeight_KeyPress_1(object sender, KeyPressEventArgs e)
        {
        }

        private void txtFrameWidth_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            AllowOnlyNumbers(e);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtFileName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDuration_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormAddJucator_Load(object sender, EventArgs e)
        {

        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtInaltime_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
