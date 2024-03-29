﻿namespace EasyAbp.Abp.TencentCloud.COS
{
    public class AbpTencentCloudCOSOptions
    {
        /// <summary>
        /// 连接超时时间，单位是秒，默认值为 60 秒。
        /// </summary>
        public int ConnectionTimeout { get; set; }

        /// <summary>
        /// 读写超时时间，单位是秒，默认值为 40 秒。
        /// </summary>
        public int ReadWriteTimeout { get; set; }

        /// <summary>
        /// 每次请求签名的有效时长，单位为秒，默认值为 600 秒。
        /// </summary>
        public int KeyDurationSecond { get; set; }

        public AbpTencentCloudCOSOptions()
        {
            ConnectionTimeout = 60;
            ReadWriteTimeout = 40;
            KeyDurationSecond = 600;
        }
    }
}