using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordResetBruteForce
{
    public partial class Form1 : Form
    {
        private BruteForceEngine engine =
            new BruteForceEngine();

        private MultiThreadBruteForceEngine multiEngine =
            new MultiThreadBruteForceEngine();

        private PasswordGenerator generator =
            new PasswordGenerator();

        private PasswordHasher hasher =
            new PasswordHasher();

        private Stopwatch totalStopwatch =
            new Stopwatch();

        private Stopwatch singleStopwatch =
            new Stopwatch();

        private Stopwatch multiStopwatch =
            new Stopwatch();

        private PerformanceLogger logger =
            new PerformanceLogger();

        private System.Windows.Forms.Timer timer =
            new System.Windows.Forms.Timer();

        private string currentHash = "";

        public Form1()
        {
            InitializeComponent();

            timer.Interval = 100;

            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(
            object sender,
            EventArgs e)
        {
            lblTimeValue.Text =
                totalStopwatch.Elapsed
                .ToString(@"mm\:ss");
        }

        private void btnGenerate_Click(
            object sender,
            EventArgs e)
        {
            string password =
                generator.GeneratePassword();

            txtPassword.Text = password;

            currentHash =
                hasher.HashPassword(password);

            txtHash.Text =
                currentHash;

            lblResult.Text =
                "Not Found";

            lblTimeValue.Text =
                "0 seconds";

            progressBar1.Value = 0;
        }

        private async void btnStart_Click(
            object sender,
            EventArgs e)
        {
            lblResult.Text =
                "Searching...";

            progressBar1.Value = 0;

            totalStopwatch.Restart();

            timer.Start();

            singleStopwatch.Restart();

            bool found =
                await Task.Run(() =>
                    engine.Search(currentHash));

            singleStopwatch.Stop();

            logger.SingleThreadTime =
                singleStopwatch.Elapsed.TotalSeconds;

            progressBar1.Value = 50;

            multiStopwatch.Restart();

            bool multiFound =
                await Task.Run(() =>
                    multiEngine.Search(currentHash));

            multiStopwatch.Stop();

            logger.MultiThreadTime =
                multiStopwatch.Elapsed.TotalSeconds;

            totalStopwatch.Stop();

            timer.Stop();

            progressBar1.Value = 100;

            if (multiFound)
            {
                lblResult.Text =
                    multiEngine.FoundPassword;
            }
            else
            {
                lblResult.Text =
                    "Not Found";
            }

            lblTimeValue.Text =
                "S: "
                + logger.SingleThreadTime.ToString("F2")
                + "s | M: "
                + logger.MultiThreadTime.ToString("F2")
                + "s";
        }

        private void btnStop_Click(
            object sender,
            EventArgs e)
        {
            multiEngine.Stop();

            timer.Stop();

            totalStopwatch.Stop();

            lblResult.Text =
                "Search Stopped";
        }

        private void label1_Click(
            object sender,
            EventArgs e)
        {

        }

        private void label2_Click(
            object sender,
            EventArgs e)
        {

        }

        private void lblResult_Click(
            object sender,
            EventArgs e)
        {

        }

        private void progressBar1_Click(
            object sender,
            EventArgs e)
        {

        }

        private void label1_Click_1(
            object sender,
            EventArgs e)
        {

        }

        private void textBox1_TextChanged(
            object sender,
            EventArgs e)
        {

        }
    }
}