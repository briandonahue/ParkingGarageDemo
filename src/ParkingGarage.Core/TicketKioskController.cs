using System;

namespace ParkingGarage.Core
{
    public class TicketKioskController
    {
        readonly ITicketGenerator ticketGenerator;
        readonly ITicketPrinter ticketPrinter;


        public TicketKioskController(ITicketGenerator ticketGenerator, 
                                        ITicketPrinter ticketPrinter)
        {
            this.ticketGenerator = ticketGenerator;
            this.ticketPrinter = ticketPrinter;
        }

        public void PushButton()
        {
            var ticket = ticketGenerator.GenerateNewTicket();
            ticketPrinter.Print(ticket);
        }
    }
}