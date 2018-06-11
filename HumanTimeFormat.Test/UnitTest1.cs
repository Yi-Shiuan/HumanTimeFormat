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
        public void Input_2_ShouldBe_2_second()
        {
            var result = humanTimer.ToHumanTime(2);

            result.Should().Be("2 Seconds");
        }
    }
}