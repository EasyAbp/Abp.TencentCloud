using System.Threading.Tasks;
using EasyAbp.Abp.TencentCloud.Sms.SmsTemplates;
using Shouldly;
using Xunit;

namespace EasyAbp.Abp.TencentCloud.Sms.Tests
{
    public class DescribeSmsTemplateListTests : AbpTencentCloudSmsTestBase
    {
        [Fact]
        public async Task DescribeTemplateStatusSetTest()
        {
            var result = await TencentCloudApiRequester.SendRequestAsync<DescribeSmsTemplateListResponse>(
                new DescribeSmsTemplateListRequest(
                    false,
                    new[] { 1039198, 686954 }),
                TencentCloudSmsOptions.EndPoint);

            result.ShouldNotBeNull();
            result.Error.ShouldBeNull();
            result.DescribeTemplateStatusSet.ShouldNotBeEmpty();
            result.DescribeTemplateStatusSet.Count.ShouldBe(2);
            result.DescribeTemplateStatusSet.ShouldContain(x =>
                x.TemplateId == 1039198 && x.StatusCode == 0 && x.TemplateName == "绑定手机验证码" &&
                x.TemplateContent == "您正在进行绑定手机操作，{1} 为您的验证码，如非本人操作，请忽略本短信。");
            result.DescribeTemplateStatusSet.ShouldContain(x =>
                x.TemplateId == 686954 && x.StatusCode == 0 && x.TemplateName == "验证码" &&
                x.TemplateContent == "验证码为：{1}，您正在登录，若非本人操作，请勿泄露。");
        }
    }
}