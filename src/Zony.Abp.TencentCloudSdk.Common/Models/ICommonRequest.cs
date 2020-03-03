using System.Net.Http;

namespace Zony.Abp.TencentCloudSdk.Common.Models
{
    public interface ICommonRequest
    {
        HttpRequestMessage HttpRequestMessage { get; }

        void SetAction(string action);

        void SetRegion(string region);

        void SetVersion(string version);

        void SetToken(string token);

        void SetEndpoint(string endpoint);

        void SetAuthorization(string id, string key);
    }
}