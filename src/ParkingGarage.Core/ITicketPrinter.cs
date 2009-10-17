namespace ParkingGarage.Core
{
    public interface ITicketPrinter
    {
        void Print(ITicket ticketToBePrinted);
    }
}