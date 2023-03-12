using System;
using Newtonsoft.Json;
using EasyAbp.Abp.TencentCloud.CAM.Infrastructure;
using EasyAbp.Abp.TencentCloud.Common.Models;

namespace EasyAbp.Abp.TencentCloud.CAM.STS
{
    public class GetFederationTokenRequest : CommonRequest
    {
        public GetFederationTokenRequest(
            string name,
            Policy policy,
            int? durationSeconds = null)
        {
            SetAction("GetFederationToken");
            SetVersion("2018-08-13");

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