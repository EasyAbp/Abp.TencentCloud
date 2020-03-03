using System.Threading.Tasks;
using Shouldly;
using Xunit;
using Zony.Abp.TencentCloudSdk.CloudLive.DomainManage.Model;

namespace Zony.Abp.TencentCloudSdk.CloudLive.Tests
{
    public class DomainManageTests : AbpTencentCloudSdkCloudLiveTestBase
    {
        [Fact]
        public async Task DescribeLiveDomains_Test()
        {
            var resp = await TencentCloudApiRequester.SendRequestAsync<DescribeLiveDomainsResponse>(new DescribeLiveDomainsRequest(), TencentCloudSdkCloudLiveOptions.EndPoint);
            resp.RequestId.ShouldNotBeNull();
        }
    }
}