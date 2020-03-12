using JetBrains.Annotations;
using Zony.Abp.TencentCloudSdk.Common.Models;

namespace Zony.Abp.TencentCloudSdk.CloudLive.Statistics.Model
{
    public class DescribeStreamDayPlayInfoListRequest : CommonRequest
    {
        /// <summary>
        /// 查询天维度每条流的播放数据，包括总流量等
        /// </summary>
        /// <param name="dayTime">需要查询的日期，格式为 yyyy-MM-dd</param>
        /// <param name="playDomain">需要查询的播放域名。</param>
        /// <param name="pageNum">页号，范围 [1,10]，默认值是 1。</param>
        /// <param name="pageSize">每页个数，范围 [100,1000]，默认值是 1000。</param>
        public DescribeStreamDayPlayInfoListRequest(string dayTime,
            [CanBeNull] string playDomain = null,
            [CanBeNull] string pageNum = null,
            [CanBeNull] string pageSize = null)
        {
            SetAction("DescribeStreamDayPlayInfoList");
            SetVersion("2018-08-01");

            SetRequestBody(new
            {
                DayTime = dayTime,
                PlayDomain = playDomain,
                PageNum = pageNum,
                PageSize = pageSize
            });
        }
    }
}