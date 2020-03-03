using System.Collections.Generic;
using Zony.Abp.TencentCloudSdk.Common.Models;

namespace Zony.Abp.TencentCloudSdk.CloudLive.Statistics.Model
{
    public class DescribeStreamPlayInfoListResponse : CommonResponse
    {
        /// <summary>
        /// 
        /// </summary>
        public List<DayStreamPlayInfo> DataInfoList { get; set; }
    }

    public class DayStreamPlayInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public string Time { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int Bandwidth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int Flux { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int Request { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int Online { get; set; }
    }
}