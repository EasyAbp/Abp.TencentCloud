using System;

namespace EasyAbp.Abp.TencentCloud.Common
{
    public static class DateTimeExtensions
    {
        public static long GetUtcUnixTimestamp() => DateTimeOffset.UtcNow.ToUnixTimeSeconds();

        public static DateTime GetUtcDate(long unixTimestamp) => new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds(unixTimestamp);
    }
}