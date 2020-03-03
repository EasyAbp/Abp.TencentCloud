using Volo.Abp;
using Volo.Abp.Modularity;
using Volo.Abp.Testing;

namespace Zony.Abp.TencentCloudSdk.TestBase
{
    public class AbpTencentCloudSdkTestBase<TStartupModule> : AbpIntegratedTest<TStartupModule> where TStartupModule : IAbpModule
    {
        protected override void SetAbpApplicationCreationOptions(AbpApplicationCreationOptions options)
        {
            options.UseAutofac();
        }
    }
}