namespace EasyAbp.Abp.TencentCloud.CloudMonitor
{
    public class AbpTencentCloudCloudMonitorOptions
    {
        public string EndPoint { get; set; }

        public AbpTencentCloudCloudMonitorOptions()
        {
            EndPoint = "monitor.tencentcloudapi.com";
        }
    }
}