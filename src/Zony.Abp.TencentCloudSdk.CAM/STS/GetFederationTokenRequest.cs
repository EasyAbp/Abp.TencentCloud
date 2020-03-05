using System;
using Newtonsoft.Json;
using Zony.Abp.TencentCloudSdk.CAM.Infrastructure;
using Zony.Abp.TencentCloudSdk.Common.Models;

namespace Zony.Abp.TencentCloudSdk.CAM.STS
{
    public class GetFederationTokenRequest : CommonRequest
    {
        public GetFederationTokenRequest(string region,
            string name,
            Policy policy,
            int? durationSeconds = null)
        {
            SetAction("GetFederationToken");
            SetVersion("2018-08-13");
            SetRegion(region);

            if (durationSeconds > 7200) throw new ArgumentOutOfRangeException(nameof(durationSeconds), "有效期最大时长不得超过 7200 秒。");

            SetRequestBody(new
            {
                Name = name,
                Policy = JsonConvert.SerializeObject(policy),
                DurationSeconds = durationSeconds
            });
        }
    }
}