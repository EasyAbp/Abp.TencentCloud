using System.Threading.Tasks;

namespace EasyAbp.Abp.TencentCloud.COS.Infrastructure
{
    public interface IBucketOperator
    {
        Task<string> CreateAsync(string bucket);

        Task<string> DeleteAsync(string bucket);

        Task<string> ConfigureCorsAsync(string[] sourceOrigin);

        Task GetCorsInfoAsync();

        Task DeleteCorsAsync();

        Task ConfigureLifecycleAsync();

        Task GetLifecycleInfoAsync();

        Task DeleteLifecycleAsync();

        Task ConfigureVersioningAsync();

        Task GetVersioningAsync();

        Task ConfigureReplicationAsync();

        Task GetReplicationAsync();

        Task DeleteReplicationAsync();
    }
}