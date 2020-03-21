using System.Security.Cryptography;
using System.Text;

namespace EasyAbp.Abp.TencentCloud.Common
{
    public static class StringExtensions
    {
        public static string ToSha256(this string src)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                var hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(src));
                var sb = new StringBuilder();
                foreach (var @byte in hashBytes)
                {
                    sb.Append(@byte.ToString("x2"));
                }

                return sb.ToString();
            }
        }

        public static byte[] HmacSha256(byte[] key, string data)
        {
            using (var hmac256 = new HMACSHA256(key))
            {
                return hmac256.ComputeHash(Encoding.UTF8.GetBytes(data));
            }
        }
    }
}