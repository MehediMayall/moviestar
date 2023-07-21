using System.Security.Cryptography;

namespace MovieStar.Library
{
    public class Security
    {
        public void createPasswordHash(string Password, out byte[] PasswordHash, out byte[] PasswordSalt)
        {
            using(var hmac = new HMACSHA512())
            {
                PasswordSalt = hmac.Key;
                PasswordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(Password));
            }
        }

        public Boolean validatePasswordHash(string Password, byte[] PasswordSalt, byte[] PasswordHash)
        {
            using(var hmac = new HMACSHA512(PasswordSalt))
            {
                var loginPasswordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(Password));
                return loginPasswordHash.SequenceEqual(PasswordHash);
            }
        }

    }
}