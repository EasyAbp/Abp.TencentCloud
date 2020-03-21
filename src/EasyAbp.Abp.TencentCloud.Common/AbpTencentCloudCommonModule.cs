using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace EasyAbp.Abp.TencentCloud.Common
{
    public class AbpTencentCloudCommonModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClient(TencentCommonConsts.DefaultHttpClientName);
        }
    }
}