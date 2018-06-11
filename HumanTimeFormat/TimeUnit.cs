public class TimeUnit
{
    public int TimeSec { get; set; }
    public string Unit { get; set; }

    public string ToHumanReadableString(int t)
    {
        var time = t / TimeSec;
        return time > 0 ? $"{time} {Unit}{(time > 1 ? "s" : string.Empty)}" : string.Empty;
    }

    public bool HasUnit(int time)
    {
        return time / TimeSec > 0;
    }
}