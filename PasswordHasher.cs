using System.Security.Cryptography;
using System.Text;

namespace PasswordResetBruteForce
{
    public class PasswordHasher
    {
        private const string SALT = "IIT2026";

        public string HashPassword(string password)
        {
            string input = password + SALT;

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes =
                    sha256.ComputeHash(
                        Encoding.UTF8.GetBytes(input));

                StringBuilder builder =
                    new StringBuilder();

                foreach (byte b in hashBytes)
                {
                    builder.Append(
                        b.ToString("x2"));
                }

                return builder.ToString();
            }
        }
    }
}