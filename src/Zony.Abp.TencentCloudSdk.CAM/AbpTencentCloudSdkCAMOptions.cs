namespace Zony.Abp.TencentCloudSdk.CAM
{
    public class AbpTencentCloudSdkCAMOptions
    {
        public string EndPoint { get; set; }

        public AbpTencentCloudSdkCAMOptions()
        {
            EndPoint = "cam.tencentcloudapi.com";
        }
    }
}