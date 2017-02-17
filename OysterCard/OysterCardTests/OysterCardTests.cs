using System;
using NUnit.Framework;

namespace OysterCard
{
    [TestFixture]
    public class OysterCardTests
    {
        [Test]
        public void Should_HaveZeroBalance_OnInstantiation()
        {
            var oysterCard = new OysterCard();

            Assert.That(oysterCard.Balance, Is.EqualTo(0));
        }
    }
}