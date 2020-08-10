namespace EasyAbp.Abp.TencentCloud.Common.Models
{
    public class CommonResponse : ICommonResponse
    {
        public string RequestId { get; set; }
        
        public ErrorModel Error { get; set; }
    }

    public class ErrorModel
    {
        public string Code { get; set; }
        
        public string Message { get; set; }
    }
}