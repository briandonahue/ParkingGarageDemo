using System;

namespace ParkingGarage.Core
{
    public class TicketMachineController
    {
        readonly ITicketService ticketService;

        public TicketMachineController(ITicketService ticketService, ITicketPrinter printer)
        {
            this.ticketService = ticketService;
        }

        public void PushButton()
        {
            
        }
    }
}