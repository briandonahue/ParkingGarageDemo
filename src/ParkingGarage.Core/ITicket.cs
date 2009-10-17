using System;

namespace ParkingGarage.Core
{
    public interface ITicket
    {
        DateTime ArrivalTime { get; }
    }
}