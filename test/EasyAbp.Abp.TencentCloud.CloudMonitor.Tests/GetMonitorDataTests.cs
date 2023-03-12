using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shouldly;
using Xunit;
using EasyAbp.Abp.TencentCloud.CloudMonitor.BaseMonitor;

namespace EasyAbp.Abp.TencentCloud.CloudMonitor.Tests
{
    public class GetMonitorDataTests : AbpTencentCloudCloudMonitorTestBase
    {
        [Fact]
        public async Task GetCosMonitorDataTest()
        {
            var result = await TencentCloudApiRequester.SendRequestAsync<GetMonitorDataResponse>(
                new GetMonitorDataRequest(
                    new List<Instance>
                    {
                        new Instance
                        {
                            Dimensions = new List<Dimension>
                            {
                                new Dimension("appid", TencentCloudCommonOptions.AppId)
                            }
                        },
                        new Instance
                        {
                            Dimensions = new List<Dimension>
                            {
                                new Dimension("bucket", "246e0ec0-a410-4bfb-b566")
                            }
                        }
                    },
                    "QCE/COS",
                    "InternetTraffic",
                    3600,
                    new DateTime(2020, 3, 3, 0, 0, 0).ToString("yyyy-MM-dd HH:mm:ss"),
                    new DateTime(2020, 3, 4, 0, 0, 0).ToString("yyyy-MM-dd HH:mm:ss")),
                TencentCloudCloudMonitorOptions.EndPoint);

            result.ShouldNotBeNull();
            // 单位是 MB。
            var totalFlux = (result.DataPoints.SelectMany(x => x.Values).Sum(x => x) / 1000 / 1000);
            totalFlux.ShouldBeGreaterThan(0);
        }

        [Fact]
        public async Task GetCosSpaceMonitorDataTest()
        {
            var result = await TencentCloudApiRequester.SendRequestAsync<GetMonitorDataResponse>(
                new GetMonitorDataRequest(
                    new List<Instance>
                    {
                        new Instance
                        {
                            Dimensions = new List<Dimension>
                            {
                                new Dimension("appid", TencentCloudCommonOptions.AppId)
                            }
                        },
                        new Instance
                        {
                            Dimensions = new List<Dimension>
                            {
                                new Dimension("bucket", "246e0ec0-a410-4bfb-b566")
                            }
                        }
                    },
                    "QCE/COS",
                    "StdStorage",
                    3600
                ),
                TencentCloudCloudMonitorOptions.EndPoint);

            result.ShouldNotBeNull();
            result.Error.Message.ShouldNotBeNullOrWhiteSpace();
        }
    }
}