using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using EasyAbp.Abp.TencentCloud.Common.Models;

namespace EasyAbp.Abp.TencentCloud.Cls.LogManagement
{
    public class ClsCommonRequest : CommonRequest
    {
        public override string ResultRoot { get; } = "";

        public ClsCommonRequest(HttpMethod httpMethod, string apiPath, string scheme) : base(apiPath, scheme)
        {
            HttpRequestMessage.Method = httpMethod;
        }

        protected void SetRequestParamsRecord(string key, string value)
        {
            RequestParamsRecord[key] = HttpUtility.UrlEncode(value);
        }

        public override void SetEndpoint(string endpoint)
        {
            base.SetEndpoint(endpoint);
            
            HttpRequestMessage.RequestUri = new Uri($"{Scheme}://{Endpoint}/{ApiPath}?{RequestParamsRecord.Select(x => $"{x.Key}={x.Value}").JoinAsString("&")}");
            
            HttpRequestMessage.Headers.Host = Endpoint;
            HttpRequestMessage.Headers.Remove("X-TC-Timestamp");
        }

        public override void SetAuthorization(string id, string key)
        {
            var headers = HttpRequestMessage.Headers.ToDictionary(httpRequestHeader => httpRequestHeader.Key,
                httpRequestHeader => httpRequestHeader.Value.First());

            var sign = QcloudClsSignature.BuildSignature(id, key, HttpRequestMessage.Method.Method,
                ApiPath.EnsureStartsWith('/'), RequestParamsRecord, headers, 300000);

            HttpRequestMessage.Headers.TryAddWithoutValidation("Authorization", sign);
        }
    }
}