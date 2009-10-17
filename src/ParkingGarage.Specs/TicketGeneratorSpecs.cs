using System;
using NUnit.Framework;
using ParkingGarage.Core;

namespace ParkingGarage.Specs
{
 
    [TestFixture]
    public class When_generating_a_new_ticket
    {
        ITicket newTicket;
        DateTime arrivalTime;

        [SetUp]
        public void SetUp()
        {
            arrivalTime = DateTime.Now;
            var ticketGenerator = new TicketGenerator(new FakeClock(arrivalTime));
            newTicket = ticketGenerator.GenerateNewTicket();
        }

        [Test]
        public void Ticket_should_contain_datetime_of_arrival()
        {
            Assert.AreEqual(arrivalTime, newTicket.ArrivalTime);
        }
        
        
    }

    public class FakeClock : IClock
    {
        readonly DateTime timeToReturn;

        public FakeClock(DateTime timeToReturn)
        {
            this.timeToReturn = timeToReturn;
        }

        public DateTime GetCurrentTime()
        {
            return timeToReturn;
        }
    }
}