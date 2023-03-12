using EasyAbp.Abp.TencentCloud.Common;
using Volo.Abp.Modularity;
using EasyAbp.Abp.TencentCloud.TestBase;

namespace EasyAbp.Abp.TencentCloud.COS.Tests
{
    [DependsOn(typeof(AbpTencentCloudTestBaseModule),
        typeof(AbpTencentCloudCOSModule))]
    public class AbpTencentCloudCOSTestsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpTencentCloudCommonOptions>(op =>
            {
                op.Region = AbpTencentCloudConsts.Region;
            });
        }
    }
}