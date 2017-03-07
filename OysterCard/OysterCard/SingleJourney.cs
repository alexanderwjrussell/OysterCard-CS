using System.Security.Policy;

namespace OysterCard
{
    public class SingleJourney
    {
        public string entryTerminal { get; set; }
        public string exitTerminal { get; set; }
        public int? entryTerminalZone { get; set; }
        public int? exitTerminalZone { get; set; }
       
        public SingleJourney()
        {
            entryTerminal = null;
            entryTerminalZone = null;
            exitTerminal = null;
            exitTerminalZone = null;
        }
    }
}
