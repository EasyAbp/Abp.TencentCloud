namespace EasyAbp.Abp.TencentCloud.CAM
{
    public class AbpTencentCloudCAMOptions
    {
        public string EndPoint { get; set; }

        public AbpTencentCloudCAMOptions()
        {
            EndPoint = "cam.tencentcloudapi.com";
        }
    }
}