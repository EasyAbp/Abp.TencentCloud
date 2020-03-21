using System.Collections.Generic;
using EasyAbp.Abp.TencentCloud.Common.Models;

namespace EasyAbp.Abp.TencentCloud.CloudLive.Statistics.Model
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
        public double Bandwidth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double Flux { get; set; }

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