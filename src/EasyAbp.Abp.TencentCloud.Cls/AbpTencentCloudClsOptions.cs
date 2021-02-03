namespace EasyAbp.Abp.TencentCloud.Cls
{
    public class AbpTencentCloudClsOptions
    {
        public string Region { get; set; }

        public bool IsIntranet { get; set; }

        public string EndPoint
        {
            get => IsIntranet ? $"{Region}.cls.tencentyun.com" : $"{Region}.cls.tencentcs.com";
            private set
            {
            }
        }

        public AbpTencentCloudClsOptions()
        {
        }

    }
}