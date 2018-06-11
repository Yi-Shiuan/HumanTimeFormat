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
                return $"{min} Minute{(min > 1 ? "s" : string.Empty)}";
            }
            
            if (time > 0)
            {
                return $"{time} Second{(time > 1 ? "s" : string.Empty)}";
            }
            
            return "now";
        }
    }
}