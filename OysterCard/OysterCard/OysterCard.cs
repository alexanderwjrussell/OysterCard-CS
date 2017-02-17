using System;

namespace OysterCard
{
    public class OysterCard
    {
        public int Balance { get; private set; }
        public const int MAXIMUM_BALANCE = 100;

        public OysterCard()
        {
            int Balance = 0;
        }

        public void TopUp(int amount)
        {
            if ( Balance + amount > MAXIMUM_BALANCE)
                throw new Exception("Trying to top up more than maximum balance");
            Balance += amount;
        }

        public void Deduct(int amount)
        {
            Balance -= amount;
        }
    }
}
