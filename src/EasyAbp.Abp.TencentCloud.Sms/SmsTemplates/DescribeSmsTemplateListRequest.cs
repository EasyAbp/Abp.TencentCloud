using EasyAbp.Abp.TencentCloud.Common.Models;

namespace EasyAbp.Abp.TencentCloud.Sms.SmsTemplates
{
    public class DescribeSmsTemplateListRequest : CommonRequest
    {
        public DescribeSmsTemplateListRequest(
            bool international,
            int[] templateIdSet,
            int? limit = null,
            int? offset = null)
        {
            SetAction("DescribeSmsTemplateList");
            SetVersion("2021-01-11");

            SetRequestBody(new
            {
                International = international ? 1 : 0,
                TemplateIdSet = templateIdSet,
                Limit = limit,
                Offset = offset
            });
        }
    }
}