using System;

namespace ParkingGarage.Core
{
    public interface IClock
    {
        DateTime GetCurrentTime();
    }
}