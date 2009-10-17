    
using System;
using NUnit.Framework;
using ParkingGarage.Core;

[TestFixture]
public class When_button_is_pushed
{
    TicketMachineController ticketMachine;
    FakeTicketPrinter ticketPrinter;
    ITicket ticketToBePrinted;

    [SetUp]
    public void SetUp()
    {
        ticketToBePrinted = new FakeTicket();
        var ticketService = new FakeTicketService(ticketToBePrinted);
        ticketPrinter = new FakeTicketPrinter();
        ticketMachine = new TicketMachineController(ticketService, ticketPrinter);
        ticketMachine.PushButton();
    }

    [Test]
    public void Should_print_new_ticket()
    {
        Assert.IsTrue(ticketPrinter.PrintWasCalledFor(ticketToBePrinted));


    }
}

public class FakeTicket : ITicket
{
}

public class FakeTicketPrinter: ITicketPrinter
{
    bool printSuccessful;

    public bool PrintWasCalledFor(ITicket ticket)
    {
        return printSuccessful;
    }

    public void Print(ITicket ticket)
    {
        if(ticket == ticket)
        {
            printSuccessful = true;
        }
    }
}

public class FakeTicketService: ITicketService
{
    readonly ITicket ticketToBePrinted;

    public FakeTicketService(ITicket ticketToBePrinted)
    {
        this.ticketToBePrinted = ticketToBePrinted;
    }

    public ITicket GenerateTicket()
    {
        return ticketToBePrinted;
    }
}
