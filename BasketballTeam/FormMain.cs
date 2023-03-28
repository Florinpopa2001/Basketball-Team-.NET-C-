namespace laborator_8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            
        }

        

        private void formFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FormMeciuri();
            f.MdiParent = this;
            f.Show();
        }

        private void formUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FormUsers();
            f.MdiParent = this;
            f.Show();
        }

        private void formMoviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FormJucator();
            f.MdiParent = this;
            f.Show();
        }

        private void formAddMoviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FormAddJucator();
            f.MdiParent = this;
            f.Show();
        }
    }
}