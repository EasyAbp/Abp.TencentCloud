using System.Collections.Generic;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace EasyAbp.Abp.TencentCloud.CAM.Infrastructure
{
    public class Policy
    {
        [JsonPropertyName("version")]
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonPropertyName("statement")]
        [JsonProperty("statement")]
        public List<Statement> Statements { get; set; }
    }

    public class Statement
    {
        // TODO: 有待完善。
        // public Principal principal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("effect")]
        [JsonProperty("effect")]
        public string Effect { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("action")]
        [JsonProperty("action")]
        public List<string> Action { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("resource")]
        [JsonProperty("resource")]
        public List<string> Resource { get; set; }

        // TODO: 有待完善。
        // public Condition condition { get; set; }
    }
}