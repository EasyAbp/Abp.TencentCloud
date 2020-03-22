using System;
using System.Threading.Tasks;
using Xunit;
using EasyAbp.Abp.TencentCloud.COS.Infrastructure;
using Shouldly;

namespace EasyAbp.Abp.TencentCloud.COS.Tests
{
    public class BucketOperatorTests : AbpTencentCloudCOSTestBase
    {
        private readonly IBucketOperator _bucketOperator;
        private readonly string _bucketName = Guid.NewGuid().ToString();

        public BucketOperatorTests()
        {
            _bucketOperator = GetRequiredService<IBucketOperator>();
        }

        [Fact]
        public async Task Create_Test()
        {
            var result = await _bucketOperator.CreateAsync(_bucketName);
            result.ShouldNotBeNull();
        }

        [Fact]
        public async Task Delete_Test()
        {
            var result = await _bucketOperator.DeleteAsync(_bucketName);
            result.ShouldNotBeNull();
        }
    }
}