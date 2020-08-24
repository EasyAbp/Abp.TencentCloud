using System.Collections.Generic;
using EasyAbp.Abp.TencentCloud.Common.Models;

namespace EasyAbp.Abp.TencentCloud.CDN.Statistics.Model
{
    public class DescribeBillingDataResponse : CommonResponse
    {
        /// <summary>
        /// 
        /// </summary>
        public string RequestId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<DataItem> Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Interval { get; set; }
    }

    public class DetailDataItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string Time { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int Value { get; set; }
    }

    public class SummarizedData
    {
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int Value { get; set; }
    }

    public class BillingDataItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string Metric { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<DetailDataItem> DetailData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public SummarizedData SummarizedData { get; set; }
    }

    public class DataItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string Resource { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<BillingDataItem> BillingData { get; set; }
    }
}