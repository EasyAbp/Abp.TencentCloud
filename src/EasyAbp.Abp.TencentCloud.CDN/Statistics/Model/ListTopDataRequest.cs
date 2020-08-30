using System.Collections.Generic;
using EasyAbp.Abp.TencentCloud.Common.Models;
using JetBrains.Annotations;

namespace EasyAbp.Abp.TencentCloud.CDN.Statistics.Model
{
    /// <summary>
    /// Top 数据查询，仅支持查询 90 天内的数据。<br/>
    /// QPS: 20 次/秒。
    /// </summary>
    public class ListTopDataRequest : CommonRequest
    {
        /// <summary>
        /// 构建一个新的 <see cref="ListTopDataRequest"/> 请求。
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
        /// <param name="metric">排序对象，具体内容可以参考 <see cref="ListTopDataMetrics"/>。</param>
        /// <param name="filter">排序使用的指标名称，具体内容可以参考 <see cref="ListTopDataFilter"/> 。</param>
        /// <param name="domains">指定查询域名列表，最多可一次性查询 30 个加速域名明细。</param>
        /// <param name="project">指定要查询的项目 ID，前往查看项目 ID 未填充域名情况下，指定项目查询，若填充了具体域名信息，以域名为主。</param>
        /// <param name="detail">
        /// 多域名查询时，默认为 false 返回所有域名汇总排序结果 Metric 为 url、path、district、isp。<br/>
        /// Filter 为 flux、request 时，可设置为 true，返回每一个 Domain 的排序数据。
        /// </param>
        /// <param name="code">Filter 为 statusCode、OriginStatusCode 时，填充指定状态码查询排序结果。</param>
        /// <param name="area">
        /// 指定服务地域查询，不填充表示查询中国境内 CDN 数据。<br/>
        /// mainland: 指定查询中国境内 CDN 数据。<br/>
        /// overseas: 指定查询中国境外 CDN 数据，支持的 Metric 为 url、district、host、originHost。<br/>
        /// 当 Metric 为 originHost 时仅支持 flux、request、bandwidth Filter。
        /// </param>
        /// <param name="areaType">
        /// 查询中国境外CDN数据，且仅当 Metric 为 district 或 host 时，可指定地区类型查询，不填充表示查询服务地区数据(仅在 Area 为 overseas，且 Metric 是 district 或 host 时可用)。<br/>
        /// server: 指定查询服务地区(腾讯云 CDN 节点服务器所在地区)数据。<br/>
        /// client: 指定查询客户端地区(用户请求终端所在地区)数据，当 Metric 为 host 时仅支持 flux、request、bandwidth Filter。
        /// </param>
        public ListTopDataRequest(string startTime,
            string endTime,
            string metric,
            string filter,
            List<string> domains = null,
            long? project = null,
            bool? detail = null,
            [CanBeNull] string code = null,
            [CanBeNull] string area = null,
            [CanBeNull] string areaType = null)
        {
            SetAction("ListTopData");
            SetVersion("2018-06-06");

            SetRequestBody(new
            {
                StartTime = startTime,
                EndTime = endTime,
                Metric = metric,
                Filter = filter,
                Domains = domains,
                Project = project,
                Detail = detail,
                Code = code,
                Area = area,
                AreaType = areaType
            });
        }
    }
}