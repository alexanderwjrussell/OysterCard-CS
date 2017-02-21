using System;
using System.Dynamic;

namespace OysterCard
{
    public class OysterCard
    {
        public int Balance { get; private set; }
        public bool InJourney { get; private set; }
        public const int MAXIMUM_BALANCE = 100;
        public const int MINIMUM_FARE = 2;

        public OysterCard()
        {
            int Balance = 0;
            bool InJourney = false;
        }

        public void TopUp(int amount)
        {
            if (Balance + amount > MAXIMUM_BALANCE)
                throw new Exception("Trying to top up more than maximum balance");
            Balance += amount;
        }

        public void Deduct(int amount)
        {
            if (Balance < MINIMUM_FARE)
                throw new Exception("Insufficient funds. Please top up your card before travel");
            Balance -= amount;
        }

        public void TouchIn(Terminal terminal)
        {
            InJourney = true;
        }

        public void TouchOut(Terminal terminal)
        {
            InJourney = false;
        }
    }
}
