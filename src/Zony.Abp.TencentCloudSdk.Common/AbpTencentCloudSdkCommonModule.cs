using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Zony.Abp.TencentCloudSdk.Common
{
    public class AbpTencentCloudSdkCommonModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClient(TencentCommonConsts.DefaultHttpClientName);
        }
    }
}