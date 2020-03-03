using System;
using System.Threading.Tasks;
using Shouldly;
using Xunit;
using Zony.Abp.TencentCloudSdk.CloudLive.Statistics.Model;

namespace Zony.Abp.TencentCloudSdk.CloudLive.Tests
{
    public class StatisticsTests : AbpTencentCloudSdkCloudLiveTestBase
    {
        [Fact]
        public async Task DescribeLiveStreamPushInfoListRequest_Test()
        {
            var resp = await TencentCloudApiRequester.SendRequestAsync<DescribeLiveStreamPushInfoListResponse>(
                new DescribeLiveStreamPushInfoListRequest(),
                TencentCloudSdkCloudLiveOptions.EndPoint);

            resp.RequestId.ShouldNotBeNull();
        }

        [Fact]
        public async Task DescribeStreamPlayInfoListRequest_Test()
        {
            var resp = await TencentCloudApiRequester.SendRequestAsync<DescribeStreamPlayInfoListResponse>(
                new DescribeStreamPlayInfoListRequest(
                    new DateTime(2020, 3, 3, 0, 0, 0).ToString("yyyy-MM-dd HH:mm:ss"),
                    new DateTime(2020, 3, 4, 0, 0, 0).ToString("yyyy-MM-dd HH:mm:ss"),
                    null,
                    "7396CB03-E2C7-4C96-8919-E9BA2FC0D1DC-GD1517841547"),
                TencentCloudSdkCloudLiveOptions.EndPoint);

            resp.RequestId.ShouldNotBeNull();
        }
    }
}