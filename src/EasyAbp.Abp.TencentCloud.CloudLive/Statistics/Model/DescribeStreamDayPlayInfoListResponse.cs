using System.Collections.Generic;
using EasyAbp.Abp.TencentCloud.Common.Models;

namespace EasyAbp.Abp.TencentCloud.CloudLive.Statistics.Model
{
    public class DescribeStreamDayPlayInfoListResponse : CommonResponse
    {
        /// <summary>
        /// 
        /// </summary>
        public List<StreamInfo> DataInfoList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int TotalNum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int TotalPage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int PageNum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int PageSize { get; set; }
    }

    public class StreamInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public string StreamName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int TotalFlux { get; set; }
    }
}