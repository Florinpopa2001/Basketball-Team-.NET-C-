using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class FormMeciuri : Form
    {

        string DiviziaX, AdversarX, InvingatorX;
        int userId, MeciId, PuncteX;

        public FormMeciuri()

        {
            InitializeComponent();
            LoadFiles(dgvFiles);
        }

        private void FormFiles_Load(object sender, EventArgs e)
        {
            dgvFiles.ClearSelection();
        }

        


        

        private void txtInvingator_TextChanged(object sender, EventArgs e)
        {
            InvingatorX = txtInvingator.Text;
        }

        private void TxtUserId_TextChanged(object sender, EventArgs e)
        {
            userId = Utilities.ParseNumericValue(txtUserId);
        }

       

        private void txtAdversar_TextChanged(object sender, EventArgs e)
        {
            AdversarX = txtAdversar.Text;
        }

        

        private void txtDivizia_TextChanged(object sender, EventArgs e)
        {
            DiviziaX = txtDivizia.Text;
        }

        private void cmdRemove_Click(object sender, EventArgs e)
        {
            if (dgvFiles.SelectedRows.Count > 0)
            {
                DialogResult result = Utilities.ShowConfirmationDialog();
                if (result == DialogResult.No)
                    return;
                else
                {
                    SqlConnection conn = Utilities.OpenDbConnection();

                    string query = "DELETE FROM Meciuri WHERE meci_id=@MeciId; ";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MeciId", MeciId);

                    Utilities.WriteDataToDb(conn, cmd);
                    LoadFiles(dgvFiles);
                    Utilities.ClearTextBoxes(this);
                    dgvFiles.ClearSelection();
                }
            }
        }

        private void txtUserId_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.AllowOnlyNumbers(e);
        }

        private void txtSize_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        

        private void txtFileId_TextChanged(object sender, EventArgs e)
        {
            MeciId = Utilities.ParseNumericValue(txtFileId);
        }


        public void LoadFiles(DataGridView table)
        {
            SqlConnection conn = Utilities.OpenDbConnection();
            string query = "SELECT Meciuri.*, users.user_name FROM Meciuri INNER JOIN users " + "ON Meciuri.uploader_id = users.user_id; ";
            SqlCommand cmd = new SqlCommand(query, conn);
            DataTable dt = Utilities.GetDataFromDb(conn, cmd);
            table.DataSource = dt;
        }

        private void txtPuncte_TextChanged(object sender, EventArgs e)
        {
            PuncteX = Utilities.ParseNumericValue(txtPuncte);

        }



        private void button1_MouseEnter(object sender, MouseEventArgs e)
        {
            SearchMeci search = new SearchMeci();
            search.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dgvFiles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void dgvFiles_SelectionChanged(object sender, EventArgs e)
        {
            Utilities.ClearTextBoxes(this);

            if (dgvFiles.SelectedRows.Count > 0)
                try
                {
                    MeciId = int.Parse(dgvFiles.SelectedRows[0].Cells["meci_id"].Value.ToString());
                    txtDivizia.Text =dgvFiles.SelectedRows[0].Cells["divizia"].Value.ToString();
                    dateTimeM.Text = dgvFiles.SelectedRows[0].Cells["data_timp"].Value.ToString();
                    txtAdversar.Text =dgvFiles.SelectedRows[0].Cells["adversar"].Value.ToString();
                    txtInvingator.Text =dgvFiles.SelectedRows[0].Cells["invingator"].Value.ToString();
                    txtPuncte.Text = dgvFiles.SelectedRows[0].Cells["puncte"].Value.ToString();
                    txtUserId.Text =dgvFiles.SelectedRows[0].Cells["uploader_id"].Value.ToString();
                    txtFileId.Text = MeciId.ToString();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            // atribuie o valoare txtFileId pentru a trece de validare
            txtFileId.Text = "-1";
            if (!Utilities.ValidateTextBoxes(this))
            {
                Utilities.ShowErrorMessage();
            }
            else
            {
                SqlConnection conn = Utilities.OpenDbConnection();
                string query = "INSERT into Meciuri (divizia,data_timp, adversar, invingator,puncte, uploader_id)" + " VALUES(@DiviziaX,@dataTimp, @AdversarX, @InvingatorX, @PuncteX, @userId); ";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@DiviziaX", DiviziaX);
                cmd.Parameters.AddWithValue("@dataTimp", dateTimeM.Value.ToString("yyy-MM-dd"));
                cmd.Parameters.AddWithValue("@AdversarX", AdversarX);
                cmd.Parameters.AddWithValue("@InvingatorX", InvingatorX);
                cmd.Parameters.AddWithValue("@PuncteX", PuncteX);
                cmd.Parameters.AddWithValue("@userId", userId);
                Utilities.WriteDataToDb(conn, cmd);
                LoadFiles(dgvFiles);
                Utilities.ClearTextBoxes(this);
            }
        }

        private void cmdModify_Click(object sender, EventArgs e)
        {
            if (!Utilities.ValidateTextBoxes(this))
            {
                Utilities.ShowErrorMessage();
            }
            else
            {
                SqlConnection conn = Utilities.OpenDbConnection();
                string query = "UPDATE Meciuri " + "SET divizia = @DiviziaX, data_timp=@dataTimp, adversar=@AdversarX,invingator = @InvingatorX, puncte = @PuncteX,  uploader_id = @userId " + "WHERE meci_id=@MeciId ";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@DiviziaX", DiviziaX);
                cmd.Parameters.AddWithValue("@dataTimp", dateTimeM.Value.ToString("yyy-MM-dd"));
                cmd.Parameters.AddWithValue("@AdversarX", AdversarX);
                cmd.Parameters.AddWithValue("@InvingatorX", InvingatorX);
                cmd.Parameters.AddWithValue("@PuncteX", PuncteX);
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@MeciId", MeciId);
                Utilities.WriteDataToDb(conn, cmd);
                LoadFiles(dgvFiles);
                Utilities.ClearTextBoxes(this);
                dgvFiles.ClearSelection();
            }
        }
    }
}
