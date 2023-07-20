using System.Security.Cryptography;

namespace MovieStar.Library
{
    public class Security
    {
        public void createPasswordHash(string Password, out byte[] PasswordHash, out byte[] PasswordSalt)
        {
            using(var hmac = new HMACSHA256())
            {
                PasswordSalt = hmac.Key;
                PasswordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(Password));
            }
        }

    }
}