using Microsoft.Extensions.Options;
using Zony.Abp.TencentCloudSdk.Common;
using Zony.Abp.TencentCloudSdk.TestBase;

namespace Zony.Abp.TencentCloudSdk.COS.Tests
{
    public class AbpTencentCloudSdkCOSTestBase : AbpTencentCloudSdkTestBase<AbpTencentCloudSdkCOSTestsModule>
    {
        protected AbpTencentCloudSdkCommonOptions TencentCloudSdkCommonOptions;

        public AbpTencentCloudSdkCOSTestBase()
        {
            TencentCloudSdkCommonOptions = GetRequiredService<IOptions<AbpTencentCloudSdkCommonOptions>>().Value;
        }
    }
}