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
                var min = time / 60;
            if (time >= 60)
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