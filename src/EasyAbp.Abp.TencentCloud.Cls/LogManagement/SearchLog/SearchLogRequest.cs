using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using EasyAbp.Abp.TencentCloud.Common.Models;

namespace EasyAbp.Abp.TencentCloud.Cls.LogManagement.SearchLog
{
    public class SearchLogRequest : CommonRequest
    {
        public SearchLogRequest(
            string logSetId,
            string topicIds,
            DateTime startTime,
            DateTime endTime,
            string queryString,
            int limit,
            string context = null,
            string sort = null) : base("searchlog", "http")
        {
            HttpRequestMessage.Method = HttpMethod.Get;

            RequestParamsRecord["logset_id"] = logSetId;
            RequestParamsRecord["topic_ids"] = topicIds;
            RequestParamsRecord["start_time"] = startTime.ToString("yyyy-MM-dd HH:mm:ss");
            RequestParamsRecord["end_time"] = endTime.ToString("yyyy-MM-dd HH:mm:ss");
            RequestParamsRecord["query_string"] = queryString;
            RequestParamsRecord["limit"] = limit.ToString();
            if (context != null) RequestParamsRecord["context"] = context;
            if (sort != null) RequestParamsRecord["sort"] = sort;
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

            var sign = QcloudClsSignature.BuildSignature(id, key, HttpRequestMessage.Method.Method, "/searchlog",
                RequestParamsRecord, headers, 300000);

            HttpRequestMessage.Headers.TryAddWithoutValidation("Authorization", sign);
        }
    }
}