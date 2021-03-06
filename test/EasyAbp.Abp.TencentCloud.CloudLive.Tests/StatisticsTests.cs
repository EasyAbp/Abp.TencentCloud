﻿using System;
using System.Linq;
using System.Threading.Tasks;
using Shouldly;
using Xunit;
using EasyAbp.Abp.TencentCloud.CloudLive.Statistics.Model;

namespace EasyAbp.Abp.TencentCloud.CloudLive.Tests
{
    public class StatisticsTests : AbpTencentCloudCloudLiveTestBase
    {
        [Fact]
        public async Task DescribeLiveStreamPushInfoListRequest_Test()
        {
            var resp = await TencentCloudApiRequester.SendRequestAsync<DescribeLiveStreamPushInfoListResponse>(
                new DescribeLiveStreamPushInfoListRequest(),
                TencentCloudCloudLiveOptions.EndPoint);

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
                TencentCloudCloudLiveOptions.EndPoint);

            resp.RequestId.ShouldNotBeNull();
            var allFlux = resp.DataInfoList.Where(x => x.Flux > 0).Sum(x => x.Flux);
            var maxBandwidth = resp.DataInfoList.Where(x => x.Bandwidth > 0).Max(x => x.Bandwidth);
        }

        [Fact]
        public async Task DescribeStreamDayPlayInfoListRequest_Test()
        {
            var resp = await TencentCloudApiRequester.SendRequestAsync<DescribeStreamDayPlayInfoListResponse>(
                new DescribeStreamDayPlayInfoListRequest(
                    "2020-03-12"),
                TencentCloudCloudLiveOptions.EndPoint);

            resp.RequestId.ShouldNotBeNull();
            resp.DataInfoList.Count.ShouldBeGreaterThan(0);
        }
    }
}