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
            
        }
        
        [Test]
        public void Input_0_ShouldBe_Now()
        {
            var format = new HumanTimer();
            var result = format.ToHumanTime(0);

            result.Should().Be("now");
        }

    }
}