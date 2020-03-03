using Volo.Abp;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;
using Zony.Abp.TencentCloudSdk.Common;

namespace Zony.Abp.TencentCloudSdk.TestBase
{
    [DependsOn(typeof(AbpTencentCloudSdkCommonModule),
        typeof(AbpTestBaseModule),
        typeof(AbpAutofacModule))]
    public class AbpTencentCloudSdkTestBaseModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpTencentCloudSdkCommonOptions>(op =>
            {
                op.SecretId = AbpTencentCloudSdkConsts.SecretId;
                op.SecretKey = AbpTencentCloudSdkConsts.SecretKey;
            });
        }
    }
}