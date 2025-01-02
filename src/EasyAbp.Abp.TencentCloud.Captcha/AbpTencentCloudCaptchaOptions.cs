namespace EasyAbp.Abp.TencentCloud.Sms
{
    public class AbpTencentCloudCaptchaOptions
    {
        public string EndPoint { get; set; }
        
        public string DefaultCaptchaAppId { get; set; }
        
        public string DefaultAppSecretKey { get; set; }
        
        public string DefaultExtendCode { get; set; }
        
        public string DefaultSenderId { get; set; }

        public AbpTencentCloudCaptchaOptions()
        {
            EndPoint = "captcha.tencentcloudapi.com";
        }
    }
}