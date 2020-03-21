using System.Collections.Generic;
using EasyAbp.Abp.TencentCloud.Common.Models;

namespace EasyAbp.Abp.TencentCloud.CloudMonitor.BaseMonitor
{
    public class GetMonitorDataResponse : CommonResponse
    {
        /// <summary>
        /// 
        /// </summary>
        public string StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int Period { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string MetricName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<DataPointItem> DataPoints { get; set; }
    }

    public class DataPointItem
    {
        /// <summary>
        /// 
        /// </summary>
        public List<DimensionItem> Dimensions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<int> Timestamps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<double> Values { get; set; }
    }

    public class DimensionItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Value { get; set; }
    }
}