using laserTagSystem.Domain.Entity;
using laserTagSystem.Domain.Enums;
using laserTagSystem.Domain.Exceptions;
using laserTagSystem.Domain.ValueObjects;
using NUnit;

namespace laserTagSystem.Domain.Tests;

public class Tests {
    [Test]
    public void MatchTime_EndBeforeStart_ShouldThrow() {
        var start = DateTime.UtcNow;
        var end = start.AddMinutes(-30);

        Assert.Throws<DomainException>(() =>
            new MatchTime(start, end));
    }

    [Test]
    public void Match_State_Change() {
        var match = new Match();

        match.MarkScheduled();
        Assert.That(MatchStatus.Scheduled,Is.EqualTo(match.Status));
        match.MarkOngoing();
        Assert.That(MatchStatus.Ongoing,Is.EqualTo(match.Status));

    }

}