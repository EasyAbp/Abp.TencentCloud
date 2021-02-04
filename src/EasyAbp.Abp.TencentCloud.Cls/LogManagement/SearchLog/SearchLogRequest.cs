using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using EasyAbp.Abp.TencentCloud.Common.Models;

namespace EasyAbp.Abp.TencentCloud.Cls.LogManagement.SearchLog
{
    public class SearchLogRequest : ClsCommonRequest
    {
        public SearchLogRequest(
            string logSetId,
            string topicIds,
            DateTime startTime,
            DateTime endTime,
            string queryString,
            int limit,
            string context = null,
            string sort = null) : base(HttpMethod.Get, "searchlog", "http")
        {
            HttpRequestMessage.Method = HttpMethod.Get;

            SetRequestParamsRecord("logset_id", logSetId);
            SetRequestParamsRecord("topic_ids", topicIds);
            SetRequestParamsRecord("start_time", startTime.ToString("yyyy-MM-dd HH:mm:ss"));
            SetRequestParamsRecord("end_time", endTime.ToString("yyyy-MM-dd HH:mm:ss"));
            SetRequestParamsRecord("query_string", queryString);
            SetRequestParamsRecord("limit", limit.ToString());
            if (context != null) SetRequestParamsRecord("context", context);
            if (sort != null) SetRequestParamsRecord("sort", sort);
        }
    }
}