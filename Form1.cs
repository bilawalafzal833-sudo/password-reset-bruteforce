namespace PasswordResetBruteForce
{
    public partial class Form1 : Form
    {
        private BruteForceEngine engine = new BruteForceEngine();
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

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string password = generator.GeneratePassword();

            txtPassword.Text = password;

            currentHash = hasher.HashPassword(password);
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            bool found =
                engine.Search(currentHash);

            if (found)
            {
                lblResult.Text =
                    engine.FoundPassword;
            }
            else
            {
                lblResult.Text =
                    "Not Found";
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {

        }
    }
}
