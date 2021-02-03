using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;

namespace EasyAbp.Abp.TencentCloud.Cls.LogManagement
{
    class QcloudClsSignature
    {
        public const string Q_SIGN_ALGORITHM = "q-sign-algorithm";

        public const string Q_AK = "q-ak";

        public const string Q_SIGN_TIME = "q-sign-time";

        public const string Q_KEY_TIME = "q-key-time";

        public const string Q_HEADER_LIST = "q-header-list";

        public const string Q_URL_PARAM_LIST = "q-url-param-list";

        public const string Q_SIGNATURE = "q-signature";

        public const string SHA1 = "sha1";

        public const string URLAllowChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-_.~";

        public static string UrlEncode(string value)
        {
            if (String.IsNullOrEmpty(value)) return String.Empty;
            StringBuilder result = new StringBuilder(value.Length * 2); // %xy%xy
            byte[] strToBytes = Encoding.UTF8.GetBytes(value);
            foreach (byte b in strToBytes)
            {
                char ch = (char)b;
                if (URLAllowChars.IndexOf(ch) != -1)
                {
                    result.Append(ch);
                }
                else
                {
                    result.Append('%').Append(String.Format(CultureInfo.InvariantCulture, "{0:X2}", (int)b));
                }
            }
            return result.ToString();
        }

        public static string[] ParamsEncodeList(List<string> keys, Dictionary<string, string> dict, bool isNeedEncode)
        {
            StringBuilder resultBuilder = new StringBuilder();
            StringBuilder keyResultBuilder = new StringBuilder();
            foreach (string key in keys)
            {
                string value = dict[key];
                if (isNeedEncode) resultBuilder.Append(key).Append('=').Append(UrlEncode(value)).Append('&');
                else resultBuilder.Append(key).Append('=').Append(value).Append('&');
                keyResultBuilder.Append(key).Append(';');
            }
            string result = resultBuilder.ToString();
            string keyResult = keyResultBuilder.ToString();
            if (result.EndsWith("&", StringComparison.OrdinalIgnoreCase))
            {
                result = result.Substring(0, result.Length - 1);
                keyResult = keyResult.Substring(0, keyResult.Length - 1);
                return new string[] { result, keyResult };
            }
            return new string[] { "", "" };
        }

        public static string GetSha1ToHexString(byte[] content)
        {
            SHA1 sha1 = new SHA1CryptoServiceProvider();
            byte[] result = sha1.ComputeHash(content);
            sha1.Clear();
            var hexStr = new StringBuilder();
            foreach (byte b in result)
            {
                hexStr.Append(b.ToString("x2")); // to lower
            }
            return hexStr.ToString();
        }

        public static string GetHamcSha1ToHexString(string key, string content)
        {
            HMACSHA1 hmacSha1 = new HMACSHA1(Encoding.UTF8.GetBytes(key));
            byte[] result = hmacSha1.ComputeHash(Encoding.UTF8.GetBytes(content));
            hmacSha1.Clear();
            var hexStr = new StringBuilder();
            foreach (byte b in result)
            {
                hexStr.Append(b.ToString("x2")); // to lower
            }

            return hexStr.ToString();
        }

        public static string BuildSignature(string secretId, string secretKey, string method, string path, Dictionary<string, string> parms, Dictionary<string, string> headers, long expire)
        {
            StringBuilder formatString = new StringBuilder();
            formatString.Append(method.ToLower()).Append('\n'); // method
            formatString.Append(path).Append('\n'); // path

            Dictionary<string, string> filteredParms = new Dictionary<string, string>();
            List<string> parmKeys = new List<string>();
            foreach (KeyValuePair<string, string> kv in parms)
            {
                parmKeys.Add(kv.Key.ToLower());
                filteredParms[kv.Key.ToLower()] = kv.Value;
            }
            parmKeys.Sort(delegate(string x, string y) { return string.Compare(x, y); });

            Dictionary<string, string> filteredHeaders = new Dictionary<string, string>();
            List<string> headerKeys = new List<string>();
            foreach (KeyValuePair<string, string> kv in headers)
            {
                string lowerKey = kv.Key.ToLower();
                if (lowerKey.Equals("content-type") || lowerKey.Equals("content-md5") || lowerKey.Equals("host") || lowerKey[0] == 'x')
                {
                    headerKeys.Add(lowerKey);
                    filteredHeaders[lowerKey] = kv.Value;
                }
            }
            headerKeys.Sort(delegate(string x, string y) { return string.Compare(x, y); });
            string[] headerResult = ParamsEncodeList(headerKeys, filteredHeaders, true);
            string[] parameterResult = ParamsEncodeList(parmKeys, filteredParms, false);
            formatString.Append(parameterResult[0]).Append('\n').Append(headerResult[0]).Append('\n');
            long now = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalMilliseconds / 1000;
            string signTime = (now - 60).ToString() + ";" + (now + expire / 1000).ToString();
            // signTime = "1510109254;1510109314";
            StringBuilder stringToSign = new StringBuilder();
            stringToSign.Append(SHA1).Append("\n").Append(signTime).Append('\n')
                .Append(GetSha1ToHexString(Encoding.UTF8.GetBytes(formatString.ToString()))).Append('\n');
            string signKey = GetHamcSha1ToHexString(secretKey, signTime);
            StringBuilder signBuilder = new StringBuilder();
            signBuilder.Append(Q_SIGN_ALGORITHM).Append('=').Append(SHA1).Append('&')
                .Append(Q_AK).Append('=').Append(secretId).Append('&')
                .Append(Q_SIGN_TIME).Append('=').Append(signTime).Append('&')
                .Append(Q_KEY_TIME).Append('=').Append(signTime).Append('&')
                .Append(Q_HEADER_LIST).Append('=').Append(headerResult[1]).Append('&')
                .Append(Q_URL_PARAM_LIST).Append('=').Append(parameterResult[1]).Append('&')
                .Append(Q_SIGNATURE).Append('=').Append(GetHamcSha1ToHexString(signKey, stringToSign.ToString()));
            return signBuilder.ToString();
        }
    }
}
