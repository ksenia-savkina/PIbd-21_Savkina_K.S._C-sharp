using System;
namespace WindowsFormsCrane
{
    //Класс-ошибка "Если на стоянке уже заняты все места"
    public class ParkingOverflowException : Exception
    {
        public ParkingOverflowException() : base("На стоянке нет свободных мест")
        { }
    }
}
