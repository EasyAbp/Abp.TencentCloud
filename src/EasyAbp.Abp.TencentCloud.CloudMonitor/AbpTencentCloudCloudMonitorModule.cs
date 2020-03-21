using Volo.Abp.Modularity;
using EasyAbp.Abp.TencentCloud.Common;

namespace EasyAbp.Abp.TencentCloud.CloudMonitor
{
    [DependsOn(typeof(AbpTencentCloudCommonModule))]
    public class AbpTencentCloudCloudMonitorModule : AbpModule
    {
        
    }
}