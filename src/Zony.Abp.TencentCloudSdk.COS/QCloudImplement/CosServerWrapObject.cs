using System;
using COSXML;
using COSXML.Auth;
using Microsoft.Extensions.Options;
using Volo.Abp.DependencyInjection;
using Zony.Abp.TencentCloudSdk.Common;

namespace Zony.Abp.TencentCloudSdk.COS.QCloudImplement
{
    /// <summary>
    /// Cos Xml Server 的包装对象。
    /// </summary>
    public class CosServerWrapObject : ISingletonDependency
    {
        public CosXmlServer CosXmlServer { get; protected set; }

        private readonly AbpTencentCloudSdkCOSOptions _abpTencentCloudSdkCOSOptions;
        private readonly AbpTencentCloudSdkCommonOptions _abpTencentCloudSdkCommonOptions;

        public CosServerWrapObject(IOptions<AbpTencentCloudSdkCOSOptions> abpTencentCloudSdkCOSOptions,
            IOptions<AbpTencentCloudSdkCommonOptions> abpTencentCloudSdkCommonOptions)
        {
            _abpTencentCloudSdkCommonOptions = abpTencentCloudSdkCommonOptions.Value;
            _abpTencentCloudSdkCOSOptions = abpTencentCloudSdkCOSOptions.Value;

            CosXmlServer = new CosXmlServer(BuildConfig(),
                GetCredentialProvider());
        }

        private CosXmlConfig BuildConfig()
        {
            return new CosXmlConfig.Builder()
                .SetConnectionLimit(TimeSpan.FromSeconds(_abpTencentCloudSdkCOSOptions.ConnectionTimeout).TotalMilliseconds.To<int>())
                .SetReadWriteTimeoutMs(TimeSpan.FromSeconds(_abpTencentCloudSdkCOSOptions.ReadWriteTimeout).TotalMilliseconds.To<int>())
                .IsHttps(true)
                .SetAppid(_abpTencentCloudSdkCommonOptions.AppId)
                .SetRegion(_abpTencentCloudSdkCOSOptions.Region)
                .SetDebugLog(false)
                .Build();
        }

        private QCloudCredentialProvider GetCredentialProvider()
        {
            return new DefaultQCloudCredentialProvider(_abpTencentCloudSdkCommonOptions.SecretId,
                _abpTencentCloudSdkCommonOptions.SecretKey, _abpTencentCloudSdkCOSOptions.KeyDurationSecond);
        }
    }
}