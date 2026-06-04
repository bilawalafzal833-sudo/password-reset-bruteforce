namespace PasswordResetBruteForce
{
    public class PasswordValidator
    {
        private PasswordHasher hasher =
            new PasswordHasher();

        public bool IsMatch(
            string password,
            string targetHash)
        {
            string hash =
                hasher.HashPassword(password);

            return hash == targetHash;
        }
    }
}