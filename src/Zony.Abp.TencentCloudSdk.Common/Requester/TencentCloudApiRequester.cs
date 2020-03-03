﻿using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Linq;
using Volo.Abp.DependencyInjection;
using Zony.Abp.TencentCloudSdk.Common.Models;

namespace Zony.Abp.TencentCloudSdk.Common.Requester
{
    public class TencentCloudApiRequester : ITencentCloudApiRequester, ITransientDependency
    {
        protected HttpClient HttpClient { get; }
        protected IHttpClientFactory HttpClientFactory { get; }

        private readonly AbpTencentCloudSdkCommonOptions _sdkCommonOptions;

        public TencentCloudApiRequester(IHttpClientFactory httpClientFactory, IOptions<AbpTencentCloudSdkCommonOptions> sdkCommonOptions)
        {
            HttpClientFactory = httpClientFactory;
            HttpClient = httpClientFactory.CreateClient(TencentCommonConsts.DefaultHttpClientName);

            _sdkCommonOptions = sdkCommonOptions.Value;
        }

        public async Task<TResponse> SendRequestAsync<TResponse>(ICommonRequest request, string endpoint) where TResponse : ICommonResponse
        {
            request.SetEndpoint(endpoint);
            request.SetAuthorization(_sdkCommonOptions.SecretId, _sdkCommonOptions.SecretKey);

            using (var response = await HttpClient.SendAsync(request.HttpRequestMessage))
            {
                var result = await response.Content.ReadAsStringAsync();
                return JObject.Parse(result).SelectToken("$.Response").ToObject<TResponse>();
            }
        }
    }
}