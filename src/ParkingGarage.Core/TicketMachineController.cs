using System;

namespace ParkingGarage.Core
{
    public class TicketMachineController
    {
        readonly ITicketService ticketService;
        readonly ITicketPrinter printer;

        public TicketMachineController(ITicketService ticketService, ITicketPrinter printer)
        {
            this.ticketService = ticketService;
            this.printer = printer;
        }

        public void PushButton()
        {
            var ticket = ticketService.GenerateTicket();
            printer.Print(ticket);

        }
    }
}