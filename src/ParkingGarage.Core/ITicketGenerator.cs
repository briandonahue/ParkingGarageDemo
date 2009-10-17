namespace ParkingGarage.Core
{
    public interface ITicketGenerator
    {
        ITicket GenerateNewTicket();
    }
}