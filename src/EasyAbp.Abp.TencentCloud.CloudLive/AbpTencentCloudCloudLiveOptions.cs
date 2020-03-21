namespace EasyAbp.Abp.TencentCloud.CloudLive
{
    public class AbpTencentCloudCloudLiveOptions
    {
        public string EndPoint { get; set; }

        public AbpTencentCloudCloudLiveOptions()
        {
            EndPoint = "live.tencentcloudapi.com";
        }
    }
}