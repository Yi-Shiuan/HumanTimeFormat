using System;
using FluentAssertions;
using NUnit.Framework;

namespace HumanTimeFormat.Test
{
    [TestFixture]
    public class UnitTest1
    {
        private HumanTimer humanTimer;

        [SetUp]
        public void Setup()
        {
            humanTimer = new HumanTimer();
        }
        
        [Test]
        public void Input_0_ShouldBe_Now()
        {
            var result = humanTimer.ToHumanTime(0);

            result.Should().Be("now");
        }

        [Test]
        public void Input_1_ShouldBe_1_second()
        {
            var result = humanTimer.ToHumanTime(1);

            result.Should().Be("1 Second");
        }
        
        [Test]
        public void Input_2_ShouldBe_2_seconds()
        {
            var result = humanTimer.ToHumanTime(2);

            result.Should().Be("2 Seconds");
        }
        
        [Test]
        public void Input_60_ShouldBe_1_Minute()
        {
            var result = humanTimer.ToHumanTime(60);

            result.Should().Be("1 Minute");
        }
        
        [Test]
        public void Input_61_ShouldBe_1_Minute_And_1_Second()
        {
            var result = humanTimer.ToHumanTime(61);

            result.Should().Be("1 Minute And 1 Second");
        }
        
        [Test]
        public void Input_3600_ShouldBe_1_Hour()
        {
            var result = humanTimer.ToHumanTime(3600);

            result.Should().Be("1 Hour");
        }
        
        [Test]
        public void Input_3660_ShouldBe_1_Hour_1_Minute_1_Second()
        {
            var result = humanTimer.ToHumanTime(3661);

            result.Should().Be("1 Hour, 1 Minute And 1 Second");
        }
    }
}