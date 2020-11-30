using System.Threading.Tasks;
using EasyAbp.Abp.TencentCloud.Common.Models;

namespace EasyAbp.Abp.TencentCloud.Common.Requester
{
    public interface ITencentCloudApiRequester
    {
        Task<TResponse> SendRequestAsync<TResponse>(ICommonRequest request, string endpoint) where TResponse : ICommonResponse;
        
        Task<TResponse> SendRequestAsync<TResponse>(ICommonRequest request, string endpoint, AbpTencentCloudCommonOptions options) where TResponse : ICommonResponse;
    }
}