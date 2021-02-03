using System;
using System.Linq;
using System.Threading.Tasks;
using EasyAbp.Abp.TencentCloud.Cls.LogManagement.SearchLog;
using Shouldly;
using Xunit;

namespace EasyAbp.Abp.TencentCloud.Cls.Tests.LogManagement
{
    public class SearchLogTests : AbpTencentCloudClsTestBase
    {
        [Fact]
        public async Task Should_Get_Logs()
        {
            var result = await TencentCloudApiRequester.SendRequestAsync<SearchLogResponse>(
                new SearchLogRequest(
                    "",
                    "",
                    DateTime.Now.AddDays(-7),
                    DateTime.Now,
                    "",
                    100),
                TencentCloudClsOptions.EndPoint);

            result.ShouldNotBeNull();
            result.Error.ShouldBeNull();
            result.Results.ShouldNotBeEmpty();
            result.Results.First().Content.ShouldNotBeNullOrEmpty();
        }
    }
}