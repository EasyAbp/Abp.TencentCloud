using System;
using COSXML;
using COSXML.Auth;
using Microsoft.Extensions.Options;
using Volo.Abp.DependencyInjection;
using EasyAbp.Abp.TencentCloud.Common;

namespace EasyAbp.Abp.TencentCloud.COS.QCloudImplement
{
    /// <summary>
    /// Cos Xml Server 的包装对象。
    /// </summary>
    public class CosServerWrapObject : ISingletonDependency
    {
        public CosXmlServer CosXmlServer { get; protected set; }

        private readonly AbpTencentCloudCOSOptions _abpTencentCloudCOSOptions;
        private readonly AbpTencentCloudCommonOptions _abpTencentCloudCommonOptions;

        public CosServerWrapObject(IOptions<AbpTencentCloudCOSOptions> abpTencentCloudCOSOptions,
            IOptions<AbpTencentCloudCommonOptions> abpTencentCloudCommonOptions)
        {
            _abpTencentCloudCommonOptions = abpTencentCloudCommonOptions.Value;
            _abpTencentCloudCOSOptions = abpTencentCloudCOSOptions.Value;

            CosXmlServer = new CosXmlServer(BuildConfig(),
                GetCredentialProvider());
        }

        private CosXmlConfig BuildConfig()
        {
            return new CosXmlConfig.Builder()
                .SetConnectionLimit(TimeSpan.FromSeconds(_abpTencentCloudCOSOptions.ConnectionTimeout).TotalMilliseconds.To<int>())
                .SetReadWriteTimeoutMs(TimeSpan.FromSeconds(_abpTencentCloudCOSOptions.ReadWriteTimeout).TotalMilliseconds.To<int>())
                .IsHttps(true)
                .SetAppid(_abpTencentCloudCommonOptions.AppId)
                .SetRegion(_abpTencentCloudCOSOptions.Region)
                .SetDebugLog(false)
                .Build();
        }

        private QCloudCredentialProvider GetCredentialProvider()
        {
            return new DefaultQCloudCredentialProvider(_abpTencentCloudCommonOptions.SecretId,
                _abpTencentCloudCommonOptions.SecretKey, _abpTencentCloudCOSOptions.KeyDurationSecond);
        }
    }
}