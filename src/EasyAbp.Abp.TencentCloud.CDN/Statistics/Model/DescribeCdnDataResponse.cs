using System;
using System.Collections.Generic;
using EasyAbp.Abp.TencentCloud.Common.Models;

namespace EasyAbp.Abp.TencentCloud.CDN.Statistics.Model
{
    public class DescribeCdnDataResponse : CommonResponse
    {
        /// <summary>
        /// 返回数据的时间粒度，查询时指定。具体值有以下几项:<br/>
        /// min: 1 分钟粒度。<br/>
        /// 5min: 5 分钟粒度。<br/>
        /// hour: 1 小时粒度。<br/>
        /// day: 天粒度。
        /// </summary>
        public string Interval { get; set; }

        public List<CdnResourceData> Data { get; set; }
    }

    public class CdnResourceData
    {
        /// <summary>
        /// 资源名称，根据接口查询条件的不同，分为以下几类:<br/>
        /// 具体域名: 用于表示该域名下面的明细数据。
        /// multiDomains: 多域名汇总明细数据。
        /// 项目 ID: 指定项目查询时，显示为项目的 ID。
        /// all: 账号维度的明细数据。
        /// </summary>
        public string Resource { get; set; }

        /// <summary>
        /// 资源对应的数据明细，具体参考 <see cref="CdnDataItem"/> 类。
        /// </summary>
        public List<CdnDataItem> CdnData { get; set; }
    }

    public class CdnDataItem
    {
        /// <summary>
        /// 查询指定的指标名称: <br/>
        /// flux: 流量，单位为 byte。<br/>
        /// bandwidth: 带宽，单位为 bps。<br/>
        /// request: 请求数，单位为 次。<br/>
        /// fluxHitRate: 流量命中率，单位为 %。<br/>
        /// statusCode: 状态码，返回 2XX、3XX、4XX、5XX 汇总数据，单位为 个。<br/>
        /// 2XX: 返回 2XX 状态码汇总及各 2 开头状态码数据，单位为 个。<br/>
        /// 3XX: 返回 3XX 状态码汇总及各 3 开头状态码数据，单位为 个。<br/>
        /// 4XX: 返回 4XX 状态码汇总及各 4 开头状态码数据，单位为 个。<br/>
        /// 5XX: 返回 5XX 状态码汇总及各 5 开头状态码数据，单位为 个。<br/>
        /// 或指定查询的某一具体状态码。
        /// </summary>
        public string Metric { get; set; }

        /// <summary>
        /// 明细数据的集合。
        /// </summary>
        public List<CdnTimestampData> DetailData { get; set; }

        /// <summary>
        /// 汇总数据。
        /// </summary>
        public CdnSummarizedData SummarizedData { get; set; }
    }

    public class CdnTimestampData
    {
        /// <summary>
        /// 数据统计时间点，采用向前汇总模式。<br/>
        /// 以 5 分钟粒度为例，13:35:00 时间点代表的统计数据区间为 13:35:00 至 13:39:59。
        /// </summary>
        public DateTime Time { get; set; }

        /// <summary>
        /// 数据的具体值。
        /// </summary>
        public float Value { get; set; }
    }

    public class CdnSummarizedData
    {
        /// <summary>
        /// 汇总方式，存在以下几种:<br/>
        /// sum: 累加求和。<br/>
        /// max: 最大值，带宽模式下，采用 5 分钟粒度汇总数据，计算峰值带宽。<br/>
        /// avg: 平均值。
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 汇总后的数据值。
        /// </summary>
        public float Value { get; set; }
    }
}