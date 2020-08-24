namespace EasyAbp.Abp.TencentCloud.CDN
{
    public class AbpTencentCloudCDNOptions
    {
        public string EndPoint { get; set; }

        public AbpTencentCloudCDNOptions()
        {
            EndPoint = "cdn.tencentcloudapi.com";
        }
    }
}