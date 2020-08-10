using EasyAbp.Abp.TencentCloud.Common.Models;

namespace EasyAbp.Abp.TencentCloud.Sms.SendSms
{
    public class SendSmsRequest : CommonRequest
    {
        public SendSmsRequest(
            string[] phoneNumberSet,
            string templateId,
            string smsSdkAppid,
            string sign = null,
            string[] templateParamSet = null,
            string extendCode = null,
            string senderId = null)
        {
            SetAction("SendSms");
            SetVersion("2019-07-11");

            SetRequestBody(new
            {
                PhoneNumberSet = phoneNumberSet,
                TemplateID = templateId,
                SmsSdkAppid = smsSdkAppid,
                Sign = sign,
                TemplateParamSet = templateParamSet,
                ExtendCode = extendCode,
                SenderId = senderId
            });
        }
    }
}