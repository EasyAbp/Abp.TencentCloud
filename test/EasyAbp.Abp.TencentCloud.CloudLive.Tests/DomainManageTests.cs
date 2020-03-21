using System.Threading.Tasks;
using Shouldly;
using Xunit;
using EasyAbp.Abp.TencentCloud.CloudLive.DomainManage.Model;

namespace EasyAbp.Abp.TencentCloud.CloudLive.Tests
{
    public class DomainManageTests : AbpTencentCloudCloudLiveTestBase
    {
        [Fact]
        public async Task DescribeLiveDomains_Test()
        {
            var resp = await TencentCloudApiRequester.SendRequestAsync<DescribeLiveDomainsResponse>(new DescribeLiveDomainsRequest(), TencentCloudCloudLiveOptions.EndPoint);
            resp.RequestId.ShouldNotBeNull();
        }
    }
}