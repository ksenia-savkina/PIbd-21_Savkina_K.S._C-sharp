
using System.Drawing;

namespace WindowsFormsCrane
{
    // Параметризованный класс для хранения набора объектов от интерфейса ICrane
    /// <typeparam name="T"></typeparam>
    public class Parking<T> where T : class, ICrane
    {
        // Массив объектов, которые храним
        private readonly T[] _places;
        // Ширина окна отрисовки
        private readonly int pictureWidth;
        // Высота окна отрисовки
        private readonly int pictureHeight;
        // Размер парковочного места (ширина)
        private readonly int _placeSizeWidth = 240;
        // Размер парковочного места (высота)
        private readonly int _placeSizeHeight = 350;

        /// Конструктор
        /// <param name="picWidth">Рамзер стоянки - ширина</param>
        /// <param name="picHeight">Рамзер стоянки - высота</param>
        public Parking(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _places = new T[width * height];
            pictureWidth = picWidth;
            pictureHeight = picHeight;
        }
        // Перегрузка оператора сложения
        // Логика действия: на стоянку добавляется кран
        /// <param name="p">Стоянка</param>
        /// <param name="crane">Добавляемый кран</param>
        public static bool operator +(Parking<T> p, T crane)
        {
            int interval = 35;
            int x = 5;
            int y = 235;
            int placesWidth = p.pictureWidth / p._placeSizeWidth;
            for (int i = 0; i < p._places.Length; i++)
            {
                if (p._places[i] == null)
                {
                    p._places[i] = crane;
                    crane.SetPosition(x + (p._placeSizeWidth + interval) * (i % placesWidth), y + p._placeSizeHeight * (i / placesWidth), p.pictureWidth, p.pictureHeight);
                    return true;
                }
            }
            return false;
        }

        // Перегрузка оператора вычитания
        // Логика действия: с парковки забираем кран
        /// <param name="p">Стоянка</param>
        /// <param name="index">Индекс места, с которого пытаемся извлечь объект</param>
        public static T operator -(Parking<T> p, int index)
        {
            if (index >= 0 && index < p._places.Length && p._places[index] != null )
            {
                T temp = p._places[index];
                p._places[index] = null;
                return temp;
            }
            return null;
        }

        // Метод отрисовки стоянки
        /// <param name="g"></param>
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Length; i++)
            {
                _places[i]?.DrawCrane(g);
            }
        }

        // Метод отрисовки разметки парковочных мест
        /// <param name="g"></param>
        private void DrawMarking(Graphics g)
        {
            int x = 0;
            int interval = 35;
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < pictureWidth / _placeSizeWidth; i++)
            {
                for (int j = 0; j < pictureHeight / _placeSizeHeight + 1; ++j)
                {//линия рамзетки места
                    g.DrawLine(pen, x + (_placeSizeWidth + interval) * i  , j * _placeSizeHeight, x + _placeSizeWidth + (_placeSizeWidth + interval) * i, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * (_placeSizeWidth + interval), 0, i * (_placeSizeWidth + interval), (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
            }
        }
    }
}
