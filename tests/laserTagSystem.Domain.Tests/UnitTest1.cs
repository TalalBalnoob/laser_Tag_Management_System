using laserTagSystem.Domain.Entity;
using laserTagSystem.Domain.Enums;
using laserTagSystem.Domain.Exceptions;
using laserTagSystem.Domain.ValueObjects;
using NUnit;

namespace laserTagSystem.Domain.Tests;

public class Tests {
    // [SetUp]
    // public void Setup() {
    // }
    //
    // [Test]
    // public void Test1() {
    //     Assert.Pass();
    // }
    
    [Test]
    public void MatchTime_EndBeforeStart_ShouldThrow()
    {
        var start = DateTime.UtcNow;
        var end = start.AddMinutes(-30);

        Assert.Throws<DomainException>(() =>
            new MatchTime(start, end));
    }

    [Test]
    public void Match_State_Change() {
        var match = new Match();

        match.MarkScheduled();
        Assert.Equals(MatchStatus.Scheduled, match.Status);
    }

}