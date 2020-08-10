namespace EasyAbp.Abp.TencentCloud.Sms
{
    public class AbpTencentCloudSmsOptions
    {
        public string EndPoint { get; set; }

        public AbpTencentCloudSmsOptions()
        {
            EndPoint = "sms.tencentcloudapi.com";
        }
    }
}