using EasyAbp.Abp.TencentCloud.Common;
using EasyAbp.Abp.TencentCloud.Common.Requester;
using EasyAbp.Abp.TencentCloud.TestBase;
using Microsoft.Extensions.Options;

namespace EasyAbp.Abp.TencentCloud.Sms.Tests
{
    public class AbpTencentCloudSmsTestBase : AbpTencentCloudTestBase<AbpTencentCloudSmsTestsModule>
    {
        protected readonly ITencentCloudApiRequester TencentCloudApiRequester;
        protected readonly AbpTencentCloudSmsOptions TencentCloudSmsOptions;
        protected readonly AbpTencentCloudCommonOptions TencentCloudCommonOptions;

        public AbpTencentCloudSmsTestBase()
        {
            TencentCloudApiRequester = GetRequiredService<ITencentCloudApiRequester>();
            TencentCloudSmsOptions = GetRequiredService<IOptions<AbpTencentCloudSmsOptions>>().Value;
            TencentCloudCommonOptions = GetRequiredService<IOptions<AbpTencentCloudCommonOptions>>().Value;
        }
    }
}