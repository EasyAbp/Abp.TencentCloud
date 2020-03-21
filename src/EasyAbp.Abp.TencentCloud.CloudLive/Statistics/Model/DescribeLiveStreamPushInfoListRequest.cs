using JetBrains.Annotations;
using EasyAbp.Abp.TencentCloud.Common.Models;

namespace EasyAbp.Abp.TencentCloud.CloudLive.Statistics.Model
{
    public sealed class DescribeLiveStreamPushInfoListRequest : CommonRequest
    {
        public DescribeLiveStreamPushInfoListRequest([CanBeNull] string pushDomain = null,
            [CanBeNull] string appName= null,
            int? pageNum= null,
            int? pageSize= null)
        {
            SetAction("DescribeLiveStreamPushInfoList");
            SetVersion("2018-08-01");

            SetRequestBody(new
            {
                pushDomain,
                appName,
                pageNum,
                pageSize
            });
        }
    }
}