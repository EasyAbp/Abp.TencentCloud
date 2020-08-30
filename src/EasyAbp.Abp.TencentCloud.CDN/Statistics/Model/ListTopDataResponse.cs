using System.Collections.Generic;
using EasyAbp.Abp.TencentCloud.Common.Models;

namespace EasyAbp.Abp.TencentCloud.CDN.Statistics.Model
{
    public class ListTopDataResponse : CommonResponse
    {
        /// <summary>
        /// 各个资源的 Top 访问数据详情。
        /// </summary>
        public List<ListTopData> Data { get; set; }
    }

    public class ListTopData
    {
        /// <summary>
        /// 资源名称，根据查询条件不同分为以下几类。<br/>
        /// 具体域名: 表示该域名明细数据。<br/>
        /// multiDomains: 表示多域名汇总明细数据。<br/>
        /// 项目 ID: 指定项目查询时，显示为项目 ID。<br/>
        /// all: 账号维度明细数据。
        /// </summary>
        public string Resource { get; set; }

        /// <summary>
        /// 排序结果详情。
        /// </summary>
        public List<TopDetailData> DetailData { get; set; }
    }

    public class TopDetailData
    {
        /// <summary>
        /// 数据类型的名称。
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 数据值。
        /// </summary>
        public int Value { get; set; }
    }
}