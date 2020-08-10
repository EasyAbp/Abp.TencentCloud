namespace EasyAbp.Abp.TencentCloud.Sms
{
    public class AbpTencentCloudSmsOptions
    {
        public string EndPoint { get; set; }
        
        public string DefaultSmsSdkAppid { get; set; }
        
        public string DefaultSign { get; set; }
        
        public string DefaultExtendCode { get; set; }
        
        public string DefaultSenderId { get; set; }

        public AbpTencentCloudSmsOptions()
        {
            EndPoint = "sms.tencentcloudapi.com";
        }
    }
}