using Volo.Abp.Modularity;
using Zony.Abp.TencentCloudSdk.Common;
using Zony.Abp.TencentCloudSdk.TestBase;

namespace Zony.Abp.TencentCloudSdk.CAM.Tests
{
    [DependsOn(typeof(AbpTencentCloudSdkTestBaseModule),
        typeof(AbpTencentCloudSdkCAMModule))]
    public class AbpTencentCloudSdkCAMTestsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpTencentCloudSdkCommonOptions>(op=>op.AppId = "");
        }
    }
}