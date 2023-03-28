using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace laborator_8
{
    public partial class FormStart : Form
    {

        private static Button cmdCurrent;
        private static Random random;
        private static Form formActive;



        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        public FormStart()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal) WindowState =FormWindowState.Maximized;
            
            else
                WindowState = FormWindowState.Normal;
        }

        private void cmdMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void DeactivateButtonn()
        {
            foreach (Control control in panelMenu.Controls)
            {
                if (control.GetType() == typeof(Button))
                {
                    control.BackColor = Color.Transparent;
                    control.ForeColor = Color.White;
                }
            }
        }
        private void ActivateButton(object cmdSender)
        {
            if (cmdSender == null)
                return;
            if (cmdCurrent != (Button)cmdSender)
            {
                DeactivateButtonn();
                Color color = ThemeColor.SelectThemeColor();
                Color secondaryColor = ThemeColor.ChangeColorBrightness(color, -
                0.3);
                cmdCurrent = (Button)cmdSender;
                cmdCurrent.BackColor = color;
                panelTitle.BackColor = color;
                panelLogo.BackColor = secondaryColor;
                panelMenu.BackColor = ThemeColor.ChangeColorBrightness(color, -0.5);
                ThemeColor.PrimaryColor = color;
                ThemeColor.SecondaryColor = secondaryColor;
            }
        }

        private void OpenForms(Form childForm, object cmdCurrent)
        {
            if (formActive != null)
            {
                formActive.Close();
            }
            ActivateButton(cmdCurrent);
            formActive = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
            button2.BackColor = Color.Red;
        }

        private void cmdMovies_Click(object sender, EventArgs e)
        {
            OpenForms(new FormJucator(), sender);
        }

        private void cmdFiles_Click(object sender, EventArgs e)
        {
            OpenForms(new FormMeciuri(), sender);
        }



        private void lblLogo_Click(object sender, EventArgs e)
        {

        }

        private void cmdUsers_Click_1(object sender, EventArgs e)
        {
            OpenForms(new FormUsers(), sender);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenForms(new Profil(), sender);

        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void FormStart_Load(object sender, EventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelDesktop_Click(object sender, EventArgs e)
        {
            
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormStart start = new FormStart();
            start.Show();
            this.Hide();

        }
    }
}
