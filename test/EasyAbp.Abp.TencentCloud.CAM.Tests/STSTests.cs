using System.Collections.Generic;
using System.Threading.Tasks;
using Shouldly;
using Xunit;
using EasyAbp.Abp.TencentCloud.CAM.Infrastructure;
using EasyAbp.Abp.TencentCloud.CAM.STS;

namespace EasyAbp.Abp.TencentCloud.CAM.Tests
{
    public class STSTests : AbpTencentCloudCAMTestBase
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
                            "name/cos:PutObject",
                            "name/cos:PostObject",
                            "name/cos:InitiateMultipartUpload",
                            "name/cos:ListMultipartUploads",
                            "name/cos:ListParts",
                            "name/cos:UploadPart",
                            "name/cos:CompleteMultipartUpload",
                            "name/cos:AbortMultipartUpload",
                            "name/cos:GetBucket",
                            "name/cos:HeadObject"
                        },
                        Resource = new List<string>
                        {
                            // TODO: 如果是 COS 的话，需要手动构造前缀。
                            $"qcs::cos:ap-chengdu:uid/{TencentCloudCommonOptions.AppId}:d780c447-3f23-9212-f4d3-39f3d9a69a3e-{TencentCloudCommonOptions.AppId}/*"
                        }
                    }
                }
            };

            var result = await TencentCloudApiRequester.SendRequestAsync<GetFederationTokenResponse>(
                new GetFederationTokenRequest(
                    "ETS",
                    policy,
                    7200), "sts.tencentcloudapi.com"
            );

            result.ShouldNotBeNull();
        }
    }
}