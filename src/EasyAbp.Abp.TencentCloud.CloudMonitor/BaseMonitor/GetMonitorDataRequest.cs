using System.Collections.Generic;
using JetBrains.Annotations;
using EasyAbp.Abp.TencentCloud.Common.Models;

namespace EasyAbp.Abp.TencentCloud.CloudMonitor.BaseMonitor
{
    public class GetMonitorDataRequest : CommonRequest
    {
        public GetMonitorDataRequest(
            List<Instance> instances,
            string @namespace,
            string metricName,
            int? period = null,
            [CanBeNull] string startTime = null,
            [CanBeNull] string endTime = null)
        {
            SetAction("GetMonitorData");
            SetVersion("2018-07-24");

            SetRequestBody(new
            {
                Namespace = @namespace,
                MetricName = metricName,
                Instances = instances,
                Period = period,
                StartTime = startTime,
                EndTime = endTime
            });
        }
    }

    public class Dimension
    {
        public string Name { get; set; }

        public string Value { get; set; }

        public Dimension(string name, string value)
        {
            Name = name;
            Value = value;
        }

        public Dimension()
        {
        }
    }

    public class Instance
    {
        public List<Dimension> Dimensions { get; set; }
    }
}