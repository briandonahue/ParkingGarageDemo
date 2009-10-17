using System;

namespace ParkingGarage.Core
{
    public class Ticket : ITicket
    {
        readonly DateTime arrivalTime;

        public Ticket(DateTime arrivalTime)
        {
            this.arrivalTime = arrivalTime;
        }

        public DateTime ArrivalTime
        {
            get { return arrivalTime; }
        }
    }
}