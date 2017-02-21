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

        [Test]
        public void Should_NotBeAbleTo_PutMoreMoneyOnTheCardThanMaximumBalance()
        {
            var oysterCard = new OysterCard();

            Assert.Throws<Exception>(() => oysterCard.TopUp(1000));
        }

        [Test]
        public void Should_BeAbleTo_DeductMoneyForFare()
        {
            var oysterCard = new OysterCard();

            oysterCard.TopUp(20);
            oysterCard.Deduct(10);

            Assert.That(oysterCard.Balance, Is.EqualTo(10));
        }

        [Test]
        public void Should_BeAbleTo_TouchInToStartAJourney()
        {
            var oysterCard = new OysterCard();
            var terminal = new Terminal();

            oysterCard.TouchIn(terminal);

            Assert.That(oysterCard.InJourney, Is.EqualTo(true));
        }

        [Test]
        public void Should_BeAbleTo_TouchOutToCompleteAJourney()
        {
            var oysterCard = new OysterCard();
            var terminal = new Terminal();

            oysterCard.TouchIn(terminal);
            oysterCard.TouchOut(terminal);

            Assert.That(oysterCard.InJourney, Is.EqualTo(false));
        }

        [Test]
        public void Should_NotBeAbleToTravel_IfBalanceUnderMinimumRequired()
        {
            var oysterCard = new OysterCard();

            Assert.Throws<Exception>(() => oysterCard.Deduct(5));
        }
    }
}