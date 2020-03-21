using Volo.Abp.Modularity;
using EasyAbp.Abp.TencentCloud.Common;
using EasyAbp.Abp.TencentCloud.TestBase;

namespace EasyAbp.Abp.TencentCloud.CAM.Tests
{
    [DependsOn(typeof(AbpTencentCloudTestBaseModule),
        typeof(AbpTencentCloudCAMModule))]
    public class AbpTencentCloudCAMTestsModule : AbpModule
    {
    }
}