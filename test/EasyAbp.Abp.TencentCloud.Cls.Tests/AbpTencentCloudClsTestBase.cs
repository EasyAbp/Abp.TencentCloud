using EasyAbp.Abp.TencentCloud.Common;
using EasyAbp.Abp.TencentCloud.Common.Requester;
using EasyAbp.Abp.TencentCloud.TestBase;
using Microsoft.Extensions.Options;

namespace EasyAbp.Abp.TencentCloud.Cls.Tests
{
    public class AbpTencentCloudClsTestBase : AbpTencentCloudTestBase<AbpTencentCloudClsTestsModule>
    {
        protected readonly ITencentCloudApiRequester TencentCloudApiRequester;
        protected readonly AbpTencentCloudClsOptions TencentCloudClsOptions;
        protected readonly AbpTencentCloudCommonOptions TencentCloudCommonOptions;

        public AbpTencentCloudClsTestBase()
        {
            TencentCloudApiRequester = GetRequiredService<ITencentCloudApiRequester>();
            TencentCloudClsOptions = GetRequiredService<IOptions<AbpTencentCloudClsOptions>>().Value;
            TencentCloudCommonOptions = GetRequiredService<IOptions<AbpTencentCloudCommonOptions>>().Value;
        }
    }
}