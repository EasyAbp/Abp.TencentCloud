namespace Zony.Abp.TencentCloudSdk.CloudLive
{
    public class AbpTencentCloudSdkCloudLiveOptions
    {
        public string EndPoint { get; set; }

        public AbpTencentCloudSdkCloudLiveOptions()
        {
            EndPoint = "live.tencentcloudapi.com";
        }
    }
}