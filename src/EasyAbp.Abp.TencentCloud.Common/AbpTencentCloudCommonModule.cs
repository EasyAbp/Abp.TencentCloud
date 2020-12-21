using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Json;
using Volo.Abp.Modularity;

namespace EasyAbp.Abp.TencentCloud.Common
{
    [DependsOn(typeof(AbpJsonModule))]
    public class AbpTencentCloudCommonModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClient(TencentCommonConsts.DefaultHttpClientName);
        }
    }
}