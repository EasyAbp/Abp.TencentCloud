namespace EasyAbp.Abp.TencentCloud.COS.Infrastructure
{
    public interface IBucket
    {
        public string Name { get; set; }

        public string Region { get; set; }
    }
}