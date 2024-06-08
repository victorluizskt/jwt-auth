using static BCrypt.Net.BCrypt;

namespace Auth.Backend.Util.Encrypt
{
    public static class EncryptUtil
    {
        public static string HashGeneration(string password)
        {
            var workFactor = 14;
            string salt = GenerateSalt(workFactor);
            string hash = HashPassword(password, salt);
            return hash;

        }

        public static bool PasswordCompare(string hash, string password)
        {
            return Verify(hash, password);
        }
    }
}
