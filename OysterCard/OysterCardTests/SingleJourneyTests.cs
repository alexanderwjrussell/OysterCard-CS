using System;
using NUnit.Framework;

namespace OysterCard
{
    [TestFixture]
    public class SingleJourneyTests
    {
        [Test]
        public void Should_HaveANullValueForEntryTerminal_OnInitialisation()
        {
            var journey = new SingleJourney();

            Assert.That(journey.entryTerminal, Is.EqualTo(null));
        }

        [Test]
        public void Should_HaveANullValueForExitTerminal_OnInitialisation()
        {
            var journey = new SingleJourney();

            Assert.That(journey.exitTerminal, Is.EqualTo(null));
        }

        [Test]
        public void Should_HaveANullValueForEntryTerminalZone_OnInitialisation()
        {
            var journey = new SingleJourney();

            Assert.That(journey.entryTerminalZone, Is.EqualTo(null));
        }

        [Test]
        public void Should_HaveANullValueForExitTerminalZone_OnInitialisation()
        {
            var journey = new SingleJourney();

            Assert.That(journey.exitTerminalZone, Is.EqualTo(null));
        }

        [Test]
        public void Should_RecordEntryTerminal_OnTouchIn()
        {
            var card = new OysterCard();
            var entryTerminal = new Terminal("Camden Street", 3);

            card.TopUp(50);
            card.TouchIn(entryTerminal);
            
            Assert.That(card.singleJourney.entryTerminal, Is.EqualTo("Camden Street"));
        }

        [Test]
        public void Should_RecordExitTerminal_OnTouchOut()
        {
            var card = new OysterCard();
            var entryTerminal = new Terminal("Camden Street", 3);
            var exitTerminal = new Terminal("Kings Cross", 1);

            card.TopUp(50);
            card.TouchIn(entryTerminal);
            card.TouchOut(exitTerminal);

            Assert.That(card.singleJourney.exitTerminal, Is.EqualTo("Kings Cross"));
        }

        [Test]
        public void Should_RecordEntryTerminalZone_OnTouchIn()
        {
            var card = new OysterCard();
            var entryTerminal = new Terminal("Camden Street", 3);

            card.TopUp(50);
            card.TouchIn(entryTerminal);

            Assert.That(card.singleJourney.entryTerminalZone, Is.EqualTo(3));
        }

        [Test]
        public void Should_RecordExitTerminalZone_OnTouchOut()
        {
            var card = new OysterCard();
            var entryTerminal = new Terminal("Camden Street", 3);
            var exitTerminal = new Terminal("Kings Cross", 1);

            card.TopUp(50);
            card.TouchIn(entryTerminal);
            card.TouchOut(exitTerminal);

            Assert.That(card.singleJourney.exitTerminalZone, Is.EqualTo(1));
        }
    }
}
