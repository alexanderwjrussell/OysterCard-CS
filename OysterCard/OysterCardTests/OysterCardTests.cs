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

        [Test]
        public void Should_BeAble_ToTopUpBalance()
        {
            var oysterCard = new OysterCard();

            oysterCard.TopUp(10);

            Assert.That(oysterCard.Balance, Is.EqualTo(10));
        }
    }
}