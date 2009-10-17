using System;
using NUnit.Framework;
using ParkingGarage.Core;

namespace ParkingGarage.Specs
{
    [TestFixture]
    public class When_generating_a_new_ticket
    {
        DateTime arrivalTime;
        ITicketService ticketService;
        ITicket ticket;

        [SetUp]
        public void SetUp()
        {
            ticketService = new TicketService();
            ticket = ticketService.GenerateTicket();
        }


        [Test]
        public void Ticket_should_contain_the_arrival_time_for_the_vehicle()
        {
            Assert.AreEqual(arrivalTime, ticket.ArrivalTime);
        }
    }
}