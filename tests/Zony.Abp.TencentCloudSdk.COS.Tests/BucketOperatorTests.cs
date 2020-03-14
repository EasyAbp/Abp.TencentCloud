using System.Threading.Tasks;
using Xunit;
using Zony.Abp.TencentCloudSdk.COS.Infrastructure;

namespace Zony.Abp.TencentCloudSdk.COS.Tests
{
    public class BucketOperatorTests : AbpTencentCloudSdkCOSTestBase
    {
        private readonly IBucketOperator _bucketOperator;

        public BucketOperatorTests()
        {
            _bucketOperator = GetRequiredService<IBucketOperator>();
        }

        [Fact]
        public async Task Create_Test()
        {
            var result = await _bucketOperator.Create($"ab4b8d76-6904-3b9c-ee76-39f3d9a79afd-{TencentCloudSdkCommonOptions.AppId}");
            
        }
    }
}