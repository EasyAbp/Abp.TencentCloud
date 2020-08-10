using System.Linq;
using System.Threading.Tasks;
using EasyAbp.Abp.TencentCloud.Sms.SendSms;
using Shouldly;
using Xunit;

namespace EasyAbp.Abp.TencentCloud.CloudMonitor.Tests
{
    public class SendSmsTests : AbpTencentCloudCloudMonitorTestBase
    {
        [Fact]
        public async Task SendSmsTest()
        {
            var result = await TencentCloudApiRequester.SendRequestAsync<SendSmsResponse>(
                new SendSmsRequest(
                    new []{"+8613000000000"},
                    "400000",
                    "",
                    "多态科技",
                    new []{"123456"}),
                TencentCloudSmsOptions.EndPoint);

            result.ShouldNotBeNull();
            result.Error.ShouldBeNull();
            result.SendStatusSet.ShouldNotBeNull();
            result.SendStatusSet.ShouldNotBeEmpty();
            result.SendStatusSet.First().Code.ShouldBe("Ok");
        }
    }
}