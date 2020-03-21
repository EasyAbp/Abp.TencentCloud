using System.Threading.Tasks;
using Xunit;
using EasyAbp.Abp.TencentCloud.COS.Infrastructure;

namespace EasyAbp.Abp.TencentCloud.COS.Tests
{
    public class BucketOperatorTests : AbpTencentCloudCOSTestBase
    {
        private readonly IBucketOperator _bucketOperator;

        public BucketOperatorTests()
        {
            _bucketOperator = GetRequiredService<IBucketOperator>();
        }

        [Fact]
        public async Task Create_Test()
        {
            var result = await _bucketOperator.Create($"ab4b8d76-6904-3b9c-ee76-39f3d9a79afd-{TencentCloudCommonOptions.AppId}");
            
        }
    }
}