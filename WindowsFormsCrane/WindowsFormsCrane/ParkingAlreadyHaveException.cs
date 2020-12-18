using System;

namespace WindowsFormsCrane
{
    public class ParkingAlreadyHaveException : Exception
    {
        public ParkingAlreadyHaveException() : base("На стоянке уже есть такой кран")
        { }
    }
}
