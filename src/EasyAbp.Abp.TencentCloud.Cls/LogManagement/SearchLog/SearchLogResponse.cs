using System.Collections.Generic;
using EasyAbp.Abp.TencentCloud.Common.Models;
using Newtonsoft.Json;

namespace EasyAbp.Abp.TencentCloud.Cls.LogManagement.SearchLog
{
    public class SearchLogResponse : CommonResponse
    {
        public string Context { get; set; }
        
        public bool Listover { get; set; }
        
        public List<TencentClsLogObject> Results { get; set; }
    }

    public class TencentClsLogObject
    {
        [JsonProperty("topic_id")]
        public string TopicId { get; set; }
        
        [JsonProperty("topic_name")]
        public string TopicName { get; set; }
        
        public string Timestamp { get; set; }
        
        public string Content { get; set; }
        
        public string Filename { get; set; }
        
        public string Source { get; set; }
    }
}