using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using Microsoft.IdentityModel.Tokens;

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

        public string createToken(User user, string AppKey)
        {
            if(string.IsNullOrEmpty(AppKey)) throw new Exception("Appkey not found to generate login token");
            
            var claims = new List<Claim>(){
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.Email)
            };


            SymmetricSecurityKey skey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(AppKey));
            SigningCredentials credentials = new SigningCredentials(skey, SecurityAlgorithms.HmacSha512Signature);

            var tokenDescriptor = new SecurityTokenDescriptor{
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddHours(1),
                SigningCredentials = credentials 
            };

            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            SecurityToken token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);

        }

    }
}