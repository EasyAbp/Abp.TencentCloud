using Microsoft.Extensions.Options;
using Zony.Abp.TencentCloudSdk.Common;
using Zony.Abp.TencentCloudSdk.Common.Requester;
using Zony.Abp.TencentCloudSdk.TestBase;

namespace Zony.Abp.TencentCloudSdk.CloudMonitor.Tests
{
    public class AbpTencentCloudSdkCloudMonitorTestBase : AbpTencentCloudSdkTestBase<AbpTencentCloudSdkCloudMonitorTestsModule>
    {
        protected readonly ITencentCloudApiRequester TencentCloudApiRequester;
        protected readonly AbpTencentCloudSdkCloudMonitorOptions TencentCloudSdkCloudMonitorOptions;
        protected readonly AbpTencentCloudSdkCommonOptions TencentCloudSdkCommonOptions;

        public AbpTencentCloudSdkCloudMonitorTestBase()
        {
            TencentCloudApiRequester = GetRequiredService<ITencentCloudApiRequester>();
            TencentCloudSdkCloudMonitorOptions = GetRequiredService<IOptions<AbpTencentCloudSdkCloudMonitorOptions>>().Value;
            TencentCloudSdkCommonOptions = GetRequiredService<IOptions<AbpTencentCloudSdkCommonOptions>>().Value;
        }
    }
}