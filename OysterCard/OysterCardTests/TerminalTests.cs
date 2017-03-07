using System;
using NUnit.Framework;

namespace OysterCard
{
    [TestFixture]
    public class TerminalTests
    {
        [Test]
        public void Should_HaveAName_OnInitialise()
        {
            var terminal = new Terminal("Camden Street", 2);

            Assert.That(terminal.Name, Is.EqualTo("Camden Street"));
        }

        [Test]
        public void Should_HaveAZone_OnInitialise()
        {
            var terminal = new Terminal("Camden Street", 2);

            Assert.That(terminal.Zone, Is.EqualTo(2));
        }
    }
}
