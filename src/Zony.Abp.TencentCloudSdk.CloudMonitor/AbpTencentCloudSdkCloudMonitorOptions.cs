namespace Zony.Abp.TencentCloudSdk.CloudMonitor
{
    public class AbpTencentCloudSdkCloudMonitorOptions
    {
        public string EndPoint { get; set; }

        public AbpTencentCloudSdkCloudMonitorOptions()
        {
            EndPoint = "monitor.tencentcloudapi.com";
        }
    }
}