using Microsoft.Extensions.Options;
using EasyAbp.Abp.TencentCloud.Common;
using EasyAbp.Abp.TencentCloud.TestBase;

namespace EasyAbp.Abp.TencentCloud.COS.Tests
{
    public class AbpTencentCloudCOSTestBase : AbpTencentCloudTestBase<AbpTencentCloudCOSTestsModule>
    {
        protected AbpTencentCloudCommonOptions TencentCloudCommonOptions;

        public AbpTencentCloudCOSTestBase()
        {
            TencentCloudCommonOptions = GetRequiredService<IOptions<AbpTencentCloudCommonOptions>>().Value;
        }
    }
}