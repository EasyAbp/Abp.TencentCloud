using System.Threading.Tasks;

namespace EasyAbp.Abp.TencentCloud.COS.Infrastructure
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