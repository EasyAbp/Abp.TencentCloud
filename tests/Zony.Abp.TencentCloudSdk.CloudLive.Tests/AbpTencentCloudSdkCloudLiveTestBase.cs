using Microsoft.Extensions.Options;
using Zony.Abp.TencentCloudSdk.Common.Requester;
using Zony.Abp.TencentCloudSdk.TestBase;

namespace Zony.Abp.TencentCloudSdk.CloudLive.Tests
{
    public class AbpTencentCloudSdkCloudLiveTestBase : AbpTencentCloudSdkTestBase<AbpTencentCloudSdkCloudLiveTestsModule>
    {
        protected readonly ITencentCloudApiRequester TencentCloudApiRequester;
        protected readonly AbpTencentCloudSdkCloudLiveOptions TencentCloudSdkCloudLiveOptions;

        public AbpTencentCloudSdkCloudLiveTestBase()
        {
            TencentCloudApiRequester = GetRequiredService<ITencentCloudApiRequester>();
            TencentCloudSdkCloudLiveOptions = GetRequiredService<IOptions<AbpTencentCloudSdkCloudLiveOptions>>().Value;
        }
    }
}