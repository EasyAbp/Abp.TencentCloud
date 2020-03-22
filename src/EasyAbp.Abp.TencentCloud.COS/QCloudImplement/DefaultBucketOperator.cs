using System;
using System.Threading.Tasks;
using COSXML.Model.Bucket;
using Volo.Abp.DependencyInjection;
using EasyAbp.Abp.TencentCloud.COS.Infrastructure;

namespace EasyAbp.Abp.TencentCloud.COS.QCloudImplement
{
    public class DefaultBucketOperator : IBucketOperator, ITransientDependency
    {
        protected readonly CosServerWrapObject CosServerWrapObject;

        public DefaultBucketOperator(CosServerWrapObject cosServerWrapObject)
        {
            CosServerWrapObject = cosServerWrapObject;
        }

        public Task<string> CreateAsync(string bucket)
        {
            var request = CosServerWrapObject.CosXmlServer.PutBucket(new PutBucketRequest(bucket));
            var result = request.GetResultInfo();

            return Task.FromResult(result);
        }

        public Task<string> DeleteAsync(string bucket)
        {
            var request = CosServerWrapObject.CosXmlServer.DeleteBucket(new DeleteBucketRequest(bucket));
            throw new NotImplementedException();
        }

        public Task<string> ConfigureCorsAsync(string[] sourceOrigin)
        {
            throw new NotImplementedException();
        }

        public Task GetCorsInfoAsync()
        {
            throw new NotImplementedException();
        }

        public Task DeleteCorsAsync()
        {
            throw new NotImplementedException();
        }

        public Task ConfigureLifecycleAsync()
        {
            throw new NotImplementedException();
        }

        public Task GetLifecycleInfoAsync()
        {
            throw new NotImplementedException();
        }

        public Task DeleteLifecycleAsync()
        {
            throw new NotImplementedException();
        }

        public Task ConfigureVersioningAsync()
        {
            throw new NotImplementedException();
        }

        public Task GetVersioningAsync()
        {
            throw new NotImplementedException();
        }

        public Task ConfigureReplicationAsync()
        {
            throw new NotImplementedException();
        }

        public Task GetReplicationAsync()
        {
            throw new NotImplementedException();
        }

        public Task DeleteReplicationAsync()
        {
            throw new NotImplementedException();
        }
    }
}