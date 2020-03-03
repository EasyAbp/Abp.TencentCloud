using System.Threading.Tasks;
using Zony.Abp.TencentCloudSdk.Common.Models;

namespace Zony.Abp.TencentCloudSdk.Common.Requester
{
    public interface ITencentCloudApiRequester
    {
        Task<TResponse> SendRequestAsync<TResponse>(ICommonRequest request, string endpoint) where TResponse : ICommonResponse;
    }
}