using EasyAbp.Abp.TencentCloud.TestBase;
using Volo.Abp.Modularity;

namespace EasyAbp.Abp.TencentCloud.Cls.Tests
{
    [DependsOn(typeof(AbpTencentCloudClsModule),
        typeof(AbpTencentCloudTestBaseModule))]
    public class AbpTencentCloudClsTestsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpTencentCloudClsOptions>(op =>
            {
                op.Region = "ap-guangzhou";
                op.IsIntranet = false;
            });
        }
    }
}