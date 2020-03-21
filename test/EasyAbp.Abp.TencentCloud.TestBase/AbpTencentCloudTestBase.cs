using Volo.Abp;
using Volo.Abp.Modularity;
using Volo.Abp.Testing;

namespace EasyAbp.Abp.TencentCloud.TestBase
{
    public class AbpTencentCloudTestBase<TStartupModule> : AbpIntegratedTest<TStartupModule> where TStartupModule : IAbpModule
    {
        protected override void SetAbpApplicationCreationOptions(AbpApplicationCreationOptions options)
        {
            options.UseAutofac();
        }
    }
}