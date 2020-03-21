using System;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using EasyAbp.Abp.TencentCloud.COS.Infrastructure;

namespace EasyAbp.Abp.TencentCloud.COS.QCloudImplement
{
    public class DefaultObjectOperator : IObjectOperator, ISingletonDependency
    {
        public Task GetListAsync()
        {
            throw new NotImplementedException();
        }

        public Task SimpleUploadAsync()
        {
            throw new NotImplementedException();
        }

        public Task FormTableUploadAsync()
        {
            throw new NotImplementedException();
        }

        public Task GetMetadataAsync()
        {
            throw new NotImplementedException();
        }

        public Task DownloadAsync()
        {
            throw new NotImplementedException();
        }

        public Task CopyToAsync()
        {
            throw new NotImplementedException();
        }

        public Task PreRequestAsync()
        {
            throw new NotImplementedException();
        }

        public Task DeleteSingleFileAsync()
        {
            throw new NotImplementedException();
        }

        public Task DeleteMultiFileAsync()
        {
            throw new NotImplementedException();
        }
    }
}