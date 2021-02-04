using System.Net.Http;

namespace EasyAbp.Abp.TencentCloud.Common.Models
{
    public interface ICommonRequest
    {
        string ResultRoot { get; }

        HttpRequestMessage HttpRequestMessage { get; }

        void SetAction(string action);

        void SetRegion(string region);

        void SetVersion(string version);

        void SetToken(string token);

        void SetEndpoint(string endpoint);

        void SetAuthorization(string id, string key);
    }
}