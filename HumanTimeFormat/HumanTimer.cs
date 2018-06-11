using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace HumanTimeFormat
{
    public class HumanTimer
    {
        public string ToHumanTime(int time)
        {
            if (time == 0)
            {
                return "now";
            }

            var timeUnit = new[]
            {
                HumanTimeUnitFormat(86400, "Day", ref time),
                HumanTimeUnitFormat(3600, "Hour", ref time),
                HumanTimeUnitFormat(60, "Minute", ref time),
                HumanTimeUnitFormat(1, "Second", ref time)
            }.Where(x => !string.IsNullOrEmpty(x)).ToList();


            if (timeUnit.Count == 1)
            {
                return timeUnit[0];
            }
            
            return string.Join(", ", timeUnit.Take(timeUnit.Count - 1)) + " And " + timeUnit[timeUnit.Count - 1];
        }

        private string HumanTimeUnitFormat(int timeBox, string unit, ref int time)
        {
            var t = time / timeBox;
            time %= timeBox;
            return t > 0 ? $"{t} {unit}{(t > 1 ? "s" : string.Empty)}" : string.Empty;
        }
    }
}