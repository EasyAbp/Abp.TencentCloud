using System.Threading.Tasks;

namespace Zony.Abp.TencentCloudSdk.COS.Infrastructure
{
    public interface IObjectOperator
    {
        Task GetListAsync();

        Task SimpleUploadAsync();

        Task FormTableUploadAsync();

        Task GetMetadataAsync();

        Task DownloadAsync();

        Task CopyToAsync();

        Task PreRequestAsync();

        Task DeleteSingleFileAsync();

        Task DeleteMultiFileAsync();
    }
}