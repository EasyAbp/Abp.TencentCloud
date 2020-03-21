using Volo.Abp.Modularity;
using EasyAbp.Abp.TencentCloud.Common;

namespace EasyAbp.Abp.TencentCloud.COS
{
    [DependsOn(typeof(AbpTencentCloudCommonModule))]
    public class AbpTencentCloudCOSModule : AbpModule
    {
    }
}