using System.Collections.Generic;
using EasyAbp.Abp.TencentCloud.Common.Models;

namespace EasyAbp.Abp.TencentCloud.CDN.Statistics.Model
{
    /// <summary>
    /// 用于查询 CDN 实时访问监控数据。
    /// </summary>
    public class DescribeCdnDataRequest : CommonRequest
    {
        /// <summary>
        /// 构造一个新的 <see cref="DescribeCdnDataRequest"/> 请求。
        /// </summary>
        /// <param name="startTime">
        /// 查询起始时间，如：2018-09-04 10:40:00，返回结果大于等于指定时间。<br/>
        /// 根据指定时间粒度不同，会进行向前归整，如 2018-09-04 10:40:00 在按 1 小时的时间粒度查询时，返回的第一个数据对应时间点为 2018-09-04 10:00:00。<br/>
        /// 起始时间与结束时间间隔小于等于 90 天。
        /// </param>
        /// <param name="endTime">
        /// 查询结束时间，如：2018-09-04 10:40:00，返回结果小于等于指定时间。<br/>
        /// 根据指定时间粒度不同，会进行向前归整，如 2018-09-04 10:40:00 在按 1 小时的时间粒度查询时，返回的最后一个数据对应时间点为 2018-09-04 10:00:00。<br/>
        /// 起始时间与结束时间间隔小于等于 90 天。
        /// </param>
        /// <param name="metric">指定查询指标，支持的查询类型定义参考 <see cref="CdnQueryMetrics"/> 类。</param>
        /// <param name="domains">指定查询域名列表，最多可一次性查询 30 个加速域名明细。</param>
        /// <param name="project">
        /// 指定要查询的项目 ID。<br/>
        /// 未填充域名情况下，指定项目查询，若填充了具体域名信息，以域名为主。
        /// </param>
        /// <param name="interval">
        /// 时间粒度，支持模式如下：<br/>
        /// min：1 分钟粒度，查询区间需要小于等于 24 小时。<br/>
        /// 5min：5 分钟粒度，查询区间需要小于等于 31 天。<br/>
        /// hour：1 小时粒度，查询区间需要小于等于 31 天内。<br/>
        /// day：天粒度，查询区间需要大于 31 天。<br/>
        /// Area 字段为 overseas 时暂不支持1分钟粒度数据查询。
        /// </param>
        /// <param name="detail">
        /// 多域名查询时，默认（false)返回多个域名的汇总数据。<br/>
        /// 可按需指定为 true，返回每一个 Domain 的明细数据(statusCode 指标暂不支持)。
        /// </param>
        /// <param name="isp">
        /// 查询中国境内CDN数据时，指定运营商查询，不填充表示查询所有运营商。<br/>
        /// 指定运营商查询时，不可同时指定省份、IP协议查询。
        /// </param>
        /// <param name="district">
        /// 查询中国境内CDN数据时，指定省份查询，不填充表示查询所有省份。<br/>
        /// 查询中国境外CDN数据时，指定国家/地区查询，不填充表示查询所有国家/地区。<br/>
        /// 指定(中国境内)省份查询时，不可同时指定运营商、IP协议查询。
        /// </param>
        /// <param name="protocol">
        /// 指定协议查询，不填充表示查询所有协议。<br/>
        /// all: 所有协议。<br/>
        /// http: 指定查询 HTTP 对应指标。<br/>
        /// https: 指定查询 HTTPS 对应指标。
        /// </param>
        /// <param name="dataSource">指定数据源查询，白名单功能。</param>
        /// <param name="ipProtocol">
        /// 指定IP协议查询，不填充表示查询所有协议。<br/>
        /// all: 所有协议。<br/>
        /// ipv4: 指定查询 ipv4 对应指标。<br/>
        /// ipv6: 指定查询 ipv6 对应指标。<br/>
        /// 指定IP协议查询时，不可同时指定省份、运营商查询。<br/>
        /// 注意: 非IPv6白名单用户不可指定 ipv4、ipv6 进行查询。
        /// </param>
        /// <param name="area">
        /// 指定服务地域查询，不填充表示查询中国境内 CDN 数据。<br/>
        /// mainland: 指定查询中国境内 CDN 数据。<br/>
        /// overseas: 指定查询中国境外 CDN 数据。
        /// </param>
        /// <param name="areaType">
        /// 查询中国境外CDN数据时，可指定地区类型查询，不填充表示查询服务地区数据(仅在 Area 为 overseas 时可用)。<br/>
        /// server: 指定查询服务地区(腾讯云 CDN 节点服务器所在地区)数据。<br/>
        /// client: 指定查询客户端地区(用户请求终端所在地区)数据。
        /// </param>
        public DescribeCdnDataRequest(string startTime,
            string endTime,
            string metric,
            IEnumerable<string> domains = null,
            int? project = null,
            string interval = null,
            bool? detail = null,
            int? isp = null,
            int? district = null,
            string protocol = null,
            string dataSource = null,
            string ipProtocol = null,
            string area = null,
            string areaType = null)
        {
            SetAction("DescribeCdnData");
            SetVersion("2018-06-06");
            SetRequestBody(new
            {
                StartTime = startTime,
                EndTime = endTime,
                Metric = metric,
                Domains = domains,
                Project = project,
                Interval = interval,
                Detail = detail,
                Isp = isp,
                District = district,
                Protocol = protocol,
                DataSource = dataSource,
                IpProtocol = ipProtocol,
                Area = area,
                AreaType = areaType
            });
        }
    }
}