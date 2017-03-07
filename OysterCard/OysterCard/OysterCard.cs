using System;
using System.Dynamic;

namespace OysterCard
{
    public class OysterCard
    {
        public int Balance { get; private set; }
        public bool InJourney { get; private set; }
        public SingleJourney singleJourney { get; }
        private const int MAXIMUM_BALANCE = 100;
        private const int MINIMUM_FARE = 2;

        public OysterCard()
        {
            Balance = 0;
            InJourney = false;
            singleJourney = new SingleJourney();
        }

        public void TopUp(int amount)
        {
            if (Balance + amount > MAXIMUM_BALANCE)
                throw new Exception("Trying to top up more than maximum balance");
            Balance += amount;
        }

        public void Deduct(int amount)
        {
            CheckBlance();
            Balance -= amount;
        }

        public void TouchIn(Terminal terminal)
        {
            InJourney = true;
            RecordEntryTerminal(terminal);
        }

        public void TouchOut(Terminal terminal)
        {
            InJourney = false;
            RecordExitTerminal(terminal);
        }

        private void RecordEntryTerminal(Terminal terminal)
        {
            singleJourney.entryTerminal = terminal.Name;
            singleJourney.entryTerminalZone = terminal.Zone;
        }

        private void RecordExitTerminal(Terminal terminal)
        {
            singleJourney.exitTerminal = terminal.Name;
            singleJourney.exitTerminalZone = terminal.Zone;
        }

        private void CheckBlance()
        {
            if (Balance < MINIMUM_FARE)
                throw new Exception("Insufficient funds. Please top up your card before travel");
        }
    }
}
