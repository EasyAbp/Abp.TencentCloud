// ReSharper disable InconsistentNaming

namespace EasyAbp.Abp.TencentCloud.CDN.Statistics.Model
{
    public class ListTopDataFilter : DescribeCdnDataMetrics
    {
        /// <summary>
        /// 指定回源状态码统计，在 Code 参数中填充指定状态码。
        /// </summary>
        public const string OriginStatusCode = "OriginStatusCode";
        /// <summary>
        /// 回源 2XX 状态码。
        /// </summary>
        public const string Origin_2XX = "origin_2XX";
        /// <summary>
        /// 回源 3XX 状态码。
        /// </summary>
        public const string Origin_3XX = "origin_3XX";
        /// <summary>
        /// 回源 4XX 状态码。
        /// </summary>
        public const string Origin_4XX = "origin_4XX";
        /// <summary>
        /// 回源 5XX 状态码。
        /// </summary>
        public const string Origin_5XX = "origin_5XX";
    }
}