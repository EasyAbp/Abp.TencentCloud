using Volo.Abp;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;
using EasyAbp.Abp.TencentCloud.Common;

namespace EasyAbp.Abp.TencentCloud.TestBase
{
    [DependsOn(typeof(AbpTencentCloudCommonModule),
        typeof(AbpTestBaseModule),
        typeof(AbpAutofacModule))]
    public class AbpTencentCloudTestBaseModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpTencentCloudCommonOptions>(op =>
            {
                op.SecretId = AbpTencentCloudConsts.SecretId;
                op.SecretKey = AbpTencentCloudConsts.SecretKey;
                op.AppId = AbpTencentCloudConsts.AppId;
            });
        }
    }
}