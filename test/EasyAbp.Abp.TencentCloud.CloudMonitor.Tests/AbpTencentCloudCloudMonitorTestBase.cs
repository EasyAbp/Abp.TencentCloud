﻿using Microsoft.Extensions.Options;
using EasyAbp.Abp.TencentCloud.Common;
using EasyAbp.Abp.TencentCloud.Common.Requester;
using EasyAbp.Abp.TencentCloud.TestBase;

namespace EasyAbp.Abp.TencentCloud.CloudMonitor.Tests
{
    public class AbpTencentCloudCloudMonitorTestBase : AbpTencentCloudTestBase<AbpTencentCloudCloudMonitorTestsModule>
    {
        protected readonly ITencentCloudApiRequester TencentCloudApiRequester;
        protected readonly AbpTencentCloudCloudMonitorOptions TencentCloudCloudMonitorOptions;
        protected readonly AbpTencentCloudCommonOptions TencentCloudCommonOptions;

        public AbpTencentCloudCloudMonitorTestBase()
        {
            TencentCloudApiRequester = GetRequiredService<ITencentCloudApiRequester>();
            TencentCloudCloudMonitorOptions = GetRequiredService<IOptions<AbpTencentCloudCloudMonitorOptions>>().Value;
            TencentCloudCommonOptions = GetRequiredService<IOptions<AbpTencentCloudCommonOptions>>().Value;
        }
    }
}