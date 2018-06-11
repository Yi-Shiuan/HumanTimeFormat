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
            var timeStrings = new List<string>();
            var timeBoxs = new[]
            {
                new TimeUnit {TimeSec = 31536000, Unit = "Year"},
                new TimeUnit {TimeSec = 86400, Unit = "Day"},
                new TimeUnit {TimeSec = 3600, Unit = "Hour"},
                new TimeUnit {TimeSec = 60, Unit = "Minute"},
                new TimeUnit {TimeSec = 1, Unit = "Second"}
            };
            
            foreach (var timeBox in timeBoxs)
            {
                if (!timeBox.HasUnit(time))
                {
                    continue;
                }
                
                timeStrings.Add(timeBox.ToHumanReadableString(time));
                time %= timeBox.TimeSec;
            }
            
            if (timeStrings.Count == 1)
            {
                return timeStrings[0];
            }
            
            return ToHumanReadableTimeFormat(timeStrings);
        }

        private static string ToHumanReadableTimeFormat(List<string> timeUnit)
        {
            return $"{string.Join(", ", timeUnit.Take(timeUnit.Count - 1))} And {timeUnit[timeUnit.Count - 1]}";
        }
    }
}