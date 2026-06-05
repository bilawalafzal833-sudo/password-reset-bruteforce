using System;

namespace PasswordResetBruteForce
{
    public class PasswordGenerator
    {
        private Random random = new Random();

        private string characters =
            "abc123";

        public string GeneratePassword()
        {
            int length = random.Next(4, 7);

            string password = "";

            for (int i = 0; i < length; i++)
            {
                int index = random.Next(characters.Length);

                password += characters[index];
            }

            return password;
        }
    }
}