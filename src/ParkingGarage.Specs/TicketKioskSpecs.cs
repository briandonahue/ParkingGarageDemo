using System;
using NUnit.Framework;
using ParkingGarage.Core;

namespace ParkingGarage.Specs
{
    [TestFixture]
    public class When_button_is_pressed
    {
        FakePrinter ticketPrinter;
        ITicket ticketToBePrinted;

        [SetUp]
        public void SetUp()
        {
            ticketToBePrinted = new FakeTicket();
            ticketPrinter = new FakePrinter();
            var generator = new FakeTicketGenerator(ticketToBePrinted);
            var kioskController = new TicketKioskController(generator, ticketPrinter);
            kioskController.PushButton();
        }

        [Test]
        public void Should_print_new_ticket()
        {
            Assert.IsTrue(ticketPrinter.ShouldHaveBeenToldToPrint(ticketToBePrinted));
        }
        
    }

    public class FakeTicket: ITicket
    {
        public DateTime ArrivalTime
        {
            get { throw new NotImplementedException(); }
        }
    }

    public class FakeTicketGenerator : ITicketGenerator
    {
        readonly ITicket ticketToBeGenerated;

        public FakeTicketGenerator(ITicket ticketToBeGenerated)
        {
            this.ticketToBeGenerated = ticketToBeGenerated;
        }

        public ITicket GenerateNewTicket()
        {
            return ticketToBeGenerated;
        }
    }

    public class FakePrinter: ITicketPrinter
    {
        ITicket ticketThatShouldBePrinted;


        public bool ShouldHaveBeenToldToPrint(ITicket ticketToBePrinted)
        {
            return ticketThatShouldBePrinted == ticketToBePrinted;
        }

        public void Print(ITicket ticketToBePrinted)
        {
            ticketThatShouldBePrinted = ticketToBePrinted;
        }
    }
}