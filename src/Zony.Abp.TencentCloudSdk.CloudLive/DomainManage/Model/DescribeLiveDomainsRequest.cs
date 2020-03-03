using JetBrains.Annotations;
using Zony.Abp.TencentCloudSdk.Common.Models;

namespace Zony.Abp.TencentCloudSdk.CloudLive.DomainManage.Model
{
    public sealed class DescribeLiveDomainsRequest : CommonRequest
    {
        public DescribeLiveDomainsRequest(int? domainStatus = null,
            int? domainType = null,
            int? pageSize = null,
            int? pageNum = null,
            int? isDelayLive = null,
            [CanBeNull] string domainPrefix = null)
        {
            SetAction("DescribeLiveDomains");
            SetVersion("2018-08-01");

            SetRequestBody(new
            {
                domainStatus,
                domainType,
                pageSize,
                pageNum,
                isDelayLive,
                domainPrefix
            });
        }
    }
}