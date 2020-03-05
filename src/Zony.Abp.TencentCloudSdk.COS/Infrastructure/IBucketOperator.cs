using System.Threading.Tasks;

namespace Zony.Abp.TencentCloudSdk.COS.Infrastructure
{
    public interface IBucketOperator
    {
        Task Create(string bucket);

        Task Delete();

        Task ConfigureCors();

        Task GetCorsInfo();

        Task DeleteCors();

        Task ConfigureLifecycle();

        Task GetLifecycleInfo();

        Task DeleteLifecycle();

        Task ConfigureVersioning();

        Task GetVersioning();

        Task ConfigureReplication();

        Task GetReplication();

        Task DeleteReplication();
    }
}