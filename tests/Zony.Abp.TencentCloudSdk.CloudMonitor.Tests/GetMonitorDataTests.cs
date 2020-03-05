using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shouldly;
using Xunit;
using Zony.Abp.TencentCloudSdk.CloudMonitor.BaseMonitor;

namespace Zony.Abp.TencentCloudSdk.CloudMonitor.Tests
{
    public class GetMonitorDataTests : AbpTencentCloudSdkCloudMonitorTestBase
    {
        [Fact]
        public async Task GetCosMonitorDataTest()
        {
            var result = await TencentCloudApiRequester.SendRequestAsync<GetMonitorDataResponse>(
                new GetMonitorDataRequest(
                    "ap-chengdu",
                    new List<Instance>
                    {
                        new Instance
                        {
                            Dimensions = new List<Dimension>
                            {
                                new Dimension("appid", TencentCloudSdkCommonOptions.AppId)
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
                TencentCloudSdkCloudMonitorOptions.EndPoint);

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
                    "ap-chengdu",
                    new List<Instance>
                    {
                        new Instance
                        {
                            Dimensions = new List<Dimension>
                            {
                                new Dimension("appid", TencentCloudSdkCommonOptions.AppId)
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
                TencentCloudSdkCloudMonitorOptions.EndPoint);

            result.ShouldNotBeNull();
        }
    }
}