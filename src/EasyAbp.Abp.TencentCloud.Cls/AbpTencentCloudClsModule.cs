using EasyAbp.Abp.TencentCloud.Common;
using Volo.Abp.Modularity;

namespace EasyAbp.Abp.TencentCloud.Cls
{
    [DependsOn(typeof(AbpTencentCloudCommonModule))]
    public class AbpTencentCloudClsModule : AbpModule
    {
    }
}