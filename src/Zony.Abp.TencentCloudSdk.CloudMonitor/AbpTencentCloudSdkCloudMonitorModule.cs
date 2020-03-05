using Volo.Abp.Modularity;
using Zony.Abp.TencentCloudSdk.Common;

namespace Zony.Abp.TencentCloudSdk.CloudMonitor
{
    [DependsOn(typeof(AbpTencentCloudSdkCommonModule))]
    public class AbpTencentCloudSdkCloudMonitorModule : AbpModule
    {
        
    }
}