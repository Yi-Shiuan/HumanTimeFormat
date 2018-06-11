namespace HumanTimeFormat.Test
{
    public class HumanTimer
    {
        public string ToHumanTime(int time)
        {
            if (time > 0)
            {
                return $"{time} Second";
            }
            
            return "now";
        }
    }
}