using System;

namespace PasswordResetBruteForce
{
    public class PasswordGenerator
    {
        private Random random = new Random();

        private string characters =
            "abcdefghijklmnopqrstuvwxyz0123456789";

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