using EasyAbp.Abp.TencentCloud.Common.Models;

namespace EasyAbp.Abp.TencentCloud.Captcha.VerifyCaptcha
{
    public class VerifyCaptchaResponse : CommonResponse
    {
        public int CaptchaCode { get; set; }

        public string? CaptchaMsg { get; set; }

        public int? EvilLevel { get; set; }

        public int? GetCaptchaTime {  get; set; }

        public int? EvilBitmap { get; set; }

        public int SubmitCaptchaTime { get; set; }

        public string? DeviceRiskCategory { get; set; }
    }
}
