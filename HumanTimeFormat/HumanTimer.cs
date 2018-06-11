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
            
            var result = string.Empty;
            var hour = time / 3600;
            
            if (hour >= 1)
            {
                time %= 3600;
                result = HumanTimeUnitFormat(hour, "Hour");
            }
            
            var min = time / 60;
            if (min >= 1)
            {
                time %= 60;
                result = HumanTimeUnitFormat(min, "Minute");
            }
            
            if (time > 0)
            {
                if (min > 0)
                {
                    result = $"{result} And ";
                }
                
                result = $"{result}{HumanTimeUnitFormat(time, "Second")}";
            }
            
            return result;
        }

        private string HumanTimeUnitFormat(int count, string unit)
        {
            return $"{count} {unit}{(count > 1 ? "s" : string.Empty)}";
        }
    }
}