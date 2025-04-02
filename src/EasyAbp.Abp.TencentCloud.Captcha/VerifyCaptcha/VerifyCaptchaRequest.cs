using EasyAbp.Abp.TencentCloud.Common.Models;

namespace EasyAbp.Abp.TencentCloud.Captcha.VerifyCaptcha
{
    public class VerifyCaptchaRequest : CommonRequest
    {
        public VerifyCaptchaRequest(
            string ticket,
            string randomString,
            string userIp,
            string captchaAppId,
            string appSecretKey,
            int? businessId,
            int? sceneId,
            string? macAddress,
            string? imei,
            int needGetCaptchaTime)
        {
            SetAction("DescribeCaptchaResult");
            SetVersion("2019-07-22");

            SetRequestBody(new
            {
                CaptchaType = 9,
                Ticket = ticket,
                Randstr = randomString,
                CaptchaAppId = captchaAppId,
                AppSecretKey = appSecretKey,
                UserIp = userIp,
                NeedGetCaptchaTime = needGetCaptchaTime,
                BusinessId = businessId,
                Imei = imei,
                SceneId = sceneId,
                MacAddress = macAddress
            });
        }
    }
}
