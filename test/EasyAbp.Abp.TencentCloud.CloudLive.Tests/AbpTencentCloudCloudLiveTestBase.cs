using Microsoft.Extensions.Options;
using EasyAbp.Abp.TencentCloud.Common.Requester;
using EasyAbp.Abp.TencentCloud.TestBase;

namespace EasyAbp.Abp.TencentCloud.CloudLive.Tests
{
    public class AbpTencentCloudCloudLiveTestBase : AbpTencentCloudTestBase<AbpTencentCloudCloudLiveTestsModule>
    {
        protected readonly ITencentCloudApiRequester TencentCloudApiRequester;
        protected readonly AbpTencentCloudCloudLiveOptions TencentCloudCloudLiveOptions;

        public AbpTencentCloudCloudLiveTestBase()
        {
            TencentCloudApiRequester = GetRequiredService<ITencentCloudApiRequester>();
            TencentCloudCloudLiveOptions = GetRequiredService<IOptions<AbpTencentCloudCloudLiveOptions>>().Value;
        }
    }
}