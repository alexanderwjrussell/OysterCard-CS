namespace OysterCard
{
    public class Terminal
    {
        public string Name { get; set; }
        public int Zone { get; set; }

        public Terminal(string name, int zone)
        {
            Name = name;
            Zone = zone;
        }
    }
}
