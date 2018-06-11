using System.Collections.Generic;
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
            
            var timeUnit = new List<string>();
            
            var hour = time / 3600;
            if (hour > 0)
            {
                time %= 3600;
                timeUnit.Add(HumanTimeUnitFormat(hour, "Hour"));
            }
            
            var min = time / 60;
            if (min > 0)
            {
                time %= 60;
                timeUnit.Add(HumanTimeUnitFormat(min, "Minute"));
            }
            
            if (time > 0)
            {
                timeUnit.Add(HumanTimeUnitFormat(time, "Second"));
            }

            if (timeUnit.Count == 3)
            {
                return $"{timeUnit[0]}, {timeUnit[1]} And {timeUnit[2]}";
            }
            
            if(timeUnit.Count == 2)
            {
                return $"{timeUnit[0]} And {timeUnit[1]}";
            }

            return timeUnit[0];
        }

        private string HumanTimeUnitFormat(int count, string unit)
        {
            return $"{count} {unit}{(count > 1 ? "s" : string.Empty)}";
        }
    }
}