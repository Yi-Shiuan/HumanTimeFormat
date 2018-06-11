namespace HumanTimeFormat.Test
{
    public class HumanTimer
    {
        public string ToHumanTime(int time)
        {
            var result = string.Empty;
            if (time >= 60)
            {
                var min = time / 60;
                return HumanTimeUnitFormat(min, "Minute");
            }
            
            if (time > 0)
            {
                return HumanTimeUnitFormat(time, "Second");
            }
            
            return "now";
        }

        private string HumanTimeUnitFormat(int count, string unit)
        {
            return $"{count} {unit}{(count > 1 ? "s" : string.Empty)}";
        }
    }
}