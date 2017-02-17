namespace OysterCard
{
    public class OysterCard
    {
        public int Balance { get; private set; }

        public OysterCard()
        {
            int Balance = 0;
        }

        public void TopUp(int amount)
        {
            Balance += amount;
        }
    }
}
