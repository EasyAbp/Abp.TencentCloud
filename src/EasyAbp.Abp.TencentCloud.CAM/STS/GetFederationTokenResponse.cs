using EasyAbp.Abp.TencentCloud.Common.Models;

namespace EasyAbp.Abp.TencentCloud.CAM.STS
{
    public class GetFederationTokenResponse : CommonResponse
    {
        /// <summary>
        /// 
        /// </summary>
        public int ExpiredTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Expiration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Credentials Credentials { get; set; }
    }

    public class Credentials
    {
        /// <summary>
        /// 
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string TmpSecretId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string TmpSecretKey { get; set; }
    }
}