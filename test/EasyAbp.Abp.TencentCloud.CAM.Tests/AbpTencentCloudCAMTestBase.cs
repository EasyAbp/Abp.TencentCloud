using Microsoft.Extensions.Options;
using EasyAbp.Abp.TencentCloud.Common;
using EasyAbp.Abp.TencentCloud.Common.Requester;
using EasyAbp.Abp.TencentCloud.TestBase;

namespace EasyAbp.Abp.TencentCloud.CAM.Tests
{
    public class AbpTencentCloudCAMTestBase : AbpTencentCloudTestBase<AbpTencentCloudCAMTestsModule>
    {
        protected readonly ITencentCloudApiRequester TencentCloudApiRequester;

        protected readonly AbpTencentCloudCommonOptions TencentCloudCommonOptions;
        protected readonly AbpTencentCloudCAMOptions TencentCloudCAMOptions;

        public AbpTencentCloudCAMTestBase()
        {
            TencentCloudApiRequester = GetRequiredService<TencentCloudApiRequester>();
            TencentCloudCommonOptions = GetRequiredService<IOptions<AbpTencentCloudCommonOptions>>().Value;
            TencentCloudCAMOptions = GetRequiredService<IOptions<AbpTencentCloudCAMOptions>>().Value;
        }
    }
}