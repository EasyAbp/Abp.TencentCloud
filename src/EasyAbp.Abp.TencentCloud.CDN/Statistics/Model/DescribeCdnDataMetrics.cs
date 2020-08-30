namespace EasyAbp.Abp.TencentCloud.CDN.Statistics.Model
{
    public class DescribeCdnDataMetrics
    {
        /// <summary>
        /// 流量，单位为 byte。
        /// </summary>
        public const string Flux = "flux";
        /// <summary>
        /// 贷款，单位为 bps。
        /// </summary>
        public const string Bandwidth = "bandwidth";
        /// <summary>
        /// 请求数，单位为 次。
        /// </summary>
        public const string Request = "request";
        /// <summary>
        /// 流量命中率，单位为 %。
        /// </summary>
        public const string FluxHitRate = "fluxHitRate";

        /// <summary>
        /// 状态码，返回 2xx、3xx、4xx、5xx 的汇总数据，单位为 个。
        /// </summary>
        public const string StatusCode = "statusCode";
        /// <summary>
        /// 返回 2xx 状态码的汇总以及 2 开头状态码数据，单位为 个。
        /// </summary>
        public const string _2xx = "2xx";
        /// <summary>
        /// 返回 3xx 状态码汇总及各 3 开头状态码数据，单位为 个。
        /// </summary>
        public const string _3xx = "3xx";
        /// <summary>
        /// 返回 4xx 状态码汇总及各 4 开头状态码数据，单位为 个。
        /// </summary>
        public const string _4xx = "4xx";
        /// <summary>
        /// 返回 5xx 状态码汇总及各 5 开头状态码数据，单位为 个。
        /// </summary>
        public const string _5xx = "5xx";
    }
}