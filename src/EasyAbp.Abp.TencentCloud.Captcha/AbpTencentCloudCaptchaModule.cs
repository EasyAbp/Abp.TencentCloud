using EasyAbp.Abp.TencentCloud.Common;
using Volo.Abp.Modularity;

namespace EasyAbp.Abp.TencentCloud.Captcha
{
    [DependsOn(typeof(AbpTencentCloudCommonModule))]
    public class AbpTencentCloudCaptchaModule : AbpModule
    {
    }
}