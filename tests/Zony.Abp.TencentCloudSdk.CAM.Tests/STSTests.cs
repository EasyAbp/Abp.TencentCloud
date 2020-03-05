using System.Collections.Generic;
using System.Threading.Tasks;
using Shouldly;
using Xunit;
using Zony.Abp.TencentCloudSdk.CAM.Infrastructure;
using Zony.Abp.TencentCloudSdk.CAM.STS;

namespace Zony.Abp.TencentCloudSdk.CAM.Tests
{
    public class STSTests : AbpTencentCloudSdkCAMTestBase
    {
        [Fact]
        public async Task GenerateFederationTokenTest()
        {
            var policy = new Policy
            {
                Version = "2.0",
                Statements = new List<Statement>
                {
                    new Statement
                    {
                        Effect = "allow",
                        Action = new List<string>
                        {
                            "name/cos:PostObject",
                            "name/cos:PutObject"
                        },
                        Resource = new List<string>
                        {
                            // TODO: 如果是 COS 的话，需要手动构造前缀。
                            $"qcs::cos:ap-chengdu:uid/{TencentCloudSdkCommonOptions.AppId}:246e0ec0-a410-4bfb-b566-e28cab463dbc-{TencentCloudSdkCommonOptions.AppId}/*"
                        }
                    }
                }
            };

            var result = await TencentCloudApiRequester.SendRequestAsync<GetFederationTokenResponse>(
                new GetFederationTokenRequest(
                    "ap-chengdu",
                    "ETS",
                    policy,
                    7200), "sts.tencentcloudapi.com"
            );

            result.ShouldNotBeNull();
        }
    }
}