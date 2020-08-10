using System.Linq;
using System.Threading.Tasks;
using EasyAbp.Abp.TencentCloud.Sms.SendMessage;
using Shouldly;
using Xunit;

namespace EasyAbp.Abp.TencentCloud.CloudMonitor.Tests
{
    public class SendMessageTests : AbpTencentCloudCloudMonitorTestBase
    {
        [Fact]
        public async Task SendMessageTest()
        {
            var result = await TencentCloudApiRequester.SendRequestAsync<SendMessageResponse>(
                new SendMessageRequest(
                    "86",
                    new []{"13000000000"},
                    "400000",
                    "",
                    "小米科技",
                    new []{"123456"}),
                TencentCloudSmsOptions.EndPoint);

            result.ShouldNotBeNull();
            result.SendStatusSet.ShouldNotBeNull();
            result.SendStatusSet.ShouldNotBeEmpty();
            result.SendStatusSet.First().Code.ShouldBe("Ok");
        }
    }
}