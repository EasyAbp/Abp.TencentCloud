using Microsoft.Extensions.Options;
using Zony.Abp.TencentCloudSdk.Common;
using Zony.Abp.TencentCloudSdk.Common.Requester;
using Zony.Abp.TencentCloudSdk.TestBase;

namespace Zony.Abp.TencentCloudSdk.CAM.Tests
{
    public class AbpTencentCloudSdkCAMTestBase : AbpTencentCloudSdkTestBase<AbpTencentCloudSdkCAMTestsModule>
    {
        protected readonly ITencentCloudApiRequester TencentCloudApiRequester;

        protected readonly AbpTencentCloudSdkCommonOptions TencentCloudSdkCommonOptions;
        protected readonly AbpTencentCloudSdkCAMOptions TencentCloudSdkCAMOptions;

        public AbpTencentCloudSdkCAMTestBase()
        {
            TencentCloudApiRequester = GetRequiredService<TencentCloudApiRequester>();
            TencentCloudSdkCommonOptions = GetRequiredService<IOptions<AbpTencentCloudSdkCommonOptions>>().Value;
            TencentCloudSdkCAMOptions = GetRequiredService<IOptions<AbpTencentCloudSdkCAMOptions>>().Value;
        }
    }
}