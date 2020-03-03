using System.Collections.Generic;
using Zony.Abp.TencentCloudSdk.Common.Models;

namespace Zony.Abp.TencentCloudSdk.CloudLive.Statistics.Model
{
    public class DescribeLiveStreamPushInfoListResponse : CommonResponse
    {
        /// <summary>
        /// 
        /// </summary>
        public List<PushDataInfo> DataInfoList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int PageNum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int TotalNum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int TotalPage { get; set; }
    }

    public class PushDataInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public string Acodec { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string AppName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int AsampleRate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int AudioFps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int AudioSpeed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string BeginPushTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ClientIp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string PushDomain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Resolution { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ServerIp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string StreamName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Vcodec { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int VideoFps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int VideoSpeed { get; set; }
    }
}