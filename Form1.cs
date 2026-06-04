namespace PasswordResetBruteForce
{
    public partial class Form1 : Form
    {
        private PasswordGenerator generator = new PasswordGenerator();
        private PasswordHasher hasher = new PasswordHasher();

        private string currentHash = "";
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

        private void btnGenerate_Click(
    object sender,
    EventArgs e)
        {
            string password = generator.GeneratePassword();

            txtPassword.Text = password;

            currentHash = hasher.HashPassword(password);
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            BruteForceGenerator generator =
    new BruteForceGenerator();

            MessageBox.Show(generator.Characters);

        }

        private void btnStop_Click(object sender, EventArgs e)
        {

        }
    }
}
