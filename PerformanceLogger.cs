namespace PasswordResetBruteForce
{
    public class PerformanceLogger
    {
        public double SingleThreadTime
        {
            get;
            set;
        }

        public double MultiThreadTime
        {
            get;
            set;
        }

        public string GetComparison()
        {
            return
                "Single Thread: " +
                SingleThreadTime.ToString("F2") +
                " s | Multi Thread: " +
                MultiThreadTime.ToString("F2") +
                " s";
        }
    }
}