using System;
using System.Threading.Tasks;
using COSXML.Model.Bucket;
using Volo.Abp.DependencyInjection;
using Zony.Abp.TencentCloudSdk.COS.Infrastructure;

namespace Zony.Abp.TencentCloudSdk.COS.QCloudImplement
{
    public class DefaultBucketOperator : IBucketOperator, ITransientDependency
    {
        protected readonly CosServerWrapObject CosServerWrapObject;

        public DefaultBucketOperator(CosServerWrapObject cosServerWrapObject)
        {
            CosServerWrapObject = cosServerWrapObject;
        }

        public Task<string> Create(string bucket)
        {
            var request = CosServerWrapObject.CosXmlServer.PutBucket(new PutBucketRequest(bucket));
            var result = request.GetResultInfo();

            return Task.FromResult(result);
        }

        public Task Delete()
        {
            throw new NotImplementedException();
        }

        public Task ConfigureCors()
        {
            throw new NotImplementedException();
        }

        public Task GetCorsInfo()
        {
            throw new NotImplementedException();
        }

        public Task DeleteCors()
        {
            throw new NotImplementedException();
        }

        public Task ConfigureLifecycle()
        {
            throw new NotImplementedException();
        }

        public Task GetLifecycleInfo()
        {
            throw new NotImplementedException();
        }

        public Task DeleteLifecycle()
        {
            throw new NotImplementedException();
        }

        public Task ConfigureVersioning()
        {
            throw new NotImplementedException();
        }

        public Task GetVersioning()
        {
            throw new NotImplementedException();
        }

        public Task ConfigureReplication()
        {
            throw new NotImplementedException();
        }

        public Task GetReplication()
        {
            throw new NotImplementedException();
        }

        public Task DeleteReplication()
        {
            throw new NotImplementedException();
        }
    }
}