using System.Collections.Generic;
using EasyAbp.Abp.TencentCloud.Common.Models;

namespace EasyAbp.Abp.TencentCloud.Sms.SmsTemplates
{
    public class DescribeSmsTemplateListResponse : CommonResponse
    {
        public List<DescribeTemplateStatusSet> DescribeTemplateStatusSet { get; set; }
    }

    public class DescribeTemplateStatusSet
    {
        public int TemplateId { get; set; }

        public int International { get; set; }

        public int StatusCode { get; set; }

        public string ReviewReply { get; set; }

        public string TemplateName { get; set; }

        public string CreateTime { get; set; }

        public string TemplateContent { get; set; }
    }
}