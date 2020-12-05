using System;
namespace WindowsFormsCrane
{
    // Класс-ошибка "Если не найден кран по определенному месту"
    public class CraneNotFoundException : Exception
    {
        public CraneNotFoundException(int i) : base("Не найден кран по месту " + i)
        { }
    }
}