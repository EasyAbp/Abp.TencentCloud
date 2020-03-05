using System.Collections.Generic;
using Newtonsoft.Json;

namespace Zony.Abp.TencentCloudSdk.CAM.Infrastructure
{
    public class Policy
    {
        [JsonProperty("version")] public string Version { get; set; }

        [JsonProperty("statement")] public List<Statement> Statements { get; set; }
    }

    public class Statement
    {
        // TODO: 有待完善。
        // public Principal principal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("effect")]
        public string Effect { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("action")]
        public List<string> Action { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("resource")]
        public List<string> Resource { get; set; }

        // TODO: 有待完善。
        // public Condition condition { get; set; }
    }
}