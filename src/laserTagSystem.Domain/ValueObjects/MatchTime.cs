namespace laserTagSystem.Domain.ValueObjects;

public sealed class MatchTime
{
    public DateTime Start { get; }
    public DateTime End { get; }

    public MatchTime(DateTime start, DateTime end)
    {
        if (end <= start)
            throw new ArgumentException("Match end time must be after start time");

        Start = start;
        End = end;
    }

    public TimeSpan Duration => End - Start;

    public bool Overlaps(MatchTime other)
    {
        return Start < other.End && End > other.Start;
    }
}
