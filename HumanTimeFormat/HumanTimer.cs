namespace HumanTimeFormat.Test
{
    public class HumanTimer
    {
        public string ToHumanTime(int time)
        {
            if (time > 0)
            {
                return $"{time} Second{(time > 1 ? "s" : string.Empty)}";
            }
            
            return "now";
        }
    }
}