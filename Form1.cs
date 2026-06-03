namespace PasswordResetBruteForce
{
    public partial class Form1 : Form
    {
        private PasswordGenerator generator = new PasswordGenerator();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            txtPassword.Text = generator.GeneratePassword();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

        }

        private void btnStop_Click(object sender, EventArgs e)
        {

        }
    }
}
