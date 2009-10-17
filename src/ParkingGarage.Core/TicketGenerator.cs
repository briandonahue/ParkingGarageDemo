namespace ParkingGarage.Core
{
    public class TicketGenerator:ITicketGenerator
    {
        readonly IClock clock;

        public TicketGenerator(IClock clock)
        {
            this.clock = clock;
        }

        public ITicket GenerateNewTicket()
        {
            return new Ticket(clock.GetCurrentTime());
        }
    }
}