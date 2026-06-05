namespace PasswordResetBruteForce
{
    public class BruteForceEngine
    {
        private BruteForceGenerator generator =
            new BruteForceGenerator();

        private PasswordValidator validator =
            new PasswordValidator();

        private string foundPassword = "";

        public string FoundPassword
        {
            get { return foundPassword; }
        }

        public bool Search(string targetHash)
        {
            foundPassword = "";

            for (int length = 1; length <= 6; length++)
            {
                Generate(
                    "",
                    length,
                    targetHash);

                if (foundPassword != "")
                {
                    return true;
                }
            }

            return false;
        }

        private void Generate(
            string current,
            int targetLength,
            string targetHash)
        {
            if (foundPassword != "")
            {
                return;
            }

            if (current.Length == targetLength)
            {
                if (validator.IsMatch(
                    current,
                    targetHash))
                {
                    foundPassword = current;
                }

                return;
            }

            foreach (char c in generator.Characters)
            {
                Generate(
                    current + c,
                    targetLength,
                    targetHash);
            }
        }
    }
}