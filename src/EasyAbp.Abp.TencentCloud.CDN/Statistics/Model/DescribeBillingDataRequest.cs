using EasyAbp.Abp.TencentCloud.Common.Models;
using JetBrains.Annotations;

namespace EasyAbp.Abp.TencentCloud.CDN.Statistics.Model
{
    /// <summary>
    /// 计费数据查询，用于查询实际计费数据明细。
    /// </summary>
    public sealed class DescribeBillingDataRequest : CommonRequest
    {
        /// <summary>
        /// 构造一个 <see cref="DescribeBillingDataRequest"/> 对象。
        /// </summary>
        /// <param name="startTime">
        /// 查询起始时间，如：2018-09-04 10:40:00，返回结果大于等于指定时间。<br/>
        /// 根据指定时间粒度参数不同，会进行向前取整，如指定起始时间为 2018-09-04 10:40:00 按小时粒度查询，返回的第一个数据对应时间点为 2018-09-04 10:00:00<br/>
        /// 起始时间与结束时间间隔小于等于 90 天。
        /// </param>
        /// <param name="endTime">
        /// 查询结束时间，如：2018-09-04 10:40:00，返回结果小于等于指定时间根据指定时间粒度参数不同，会进行向前取整。<br/>
        /// 如指定结束时间为 2018-09-04 10:40:00 按小时粒度查询时，返回的最后一个数据对应时间点为 2018-09-04 10:00:00 起始时间与结束时间间隔小于等于 90 天。
        /// </param>
        /// <param name="interval">
        /// 时间粒度，支持模式如下：<br/>
        /// min：1 分钟粒度，查询区间需要小于等于 24 小时。<br/>
        /// 5min：5 分钟粒度，查询区间需要小于等于 31 天。<br/>
        /// hour：1 小时粒度，查询区间需要小于等于 31 天内。<br/>
        /// day：天粒度，查询区间需要大于 31 天。<br/><br/>
        /// Area 字段为 overseas 时暂不支持1分钟粒度数据查询。
        /// </param>
        /// <param name="domain">指定域名查询计费数据。</param>
        /// <param name="project">指定项目 ID 查询，若 Domain 参数填充了具体域名信息，则返回该域名的计费数据，而非指定项目计费数据</param>
        /// <param name="area">
        /// 指定加速区域查询计费数据：<br/>
        /// mainland：中国境内<br/>
        /// overseas：中国境外<br/>
        /// 不填充时，默认为 mainland
        /// </param>
        /// <param name="district"></param>
        /// <param name="metric"></param>
        public DescribeBillingDataRequest([NotNull] string startTime,
            [NotNull] string endTime,
            [CanBeNull] string interval = null,
            [CanBeNull] string domain = null,
            long? project = null,
            [CanBeNull] string area = null,
            [CanBeNull] string district = null,
            [CanBeNull] string metric = null)
        {
            SetAction("DescribeBillingData");
            SetVersion("2018-06-06");

            SetRequestBody(new
            {
                StartTime = startTime,
                EndTime = endTime,
                Interval = interval,
                Domain = domain,
                Project = project,
                Area = area,
                District = district,
                Metric = metric
            });
        }
    }
}