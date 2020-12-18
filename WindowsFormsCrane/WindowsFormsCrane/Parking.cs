using System.Collections;
using System.Collections.Generic;
using System.Drawing;

namespace WindowsFormsCrane
{
    // Параметризованный класс для хранения набора объектов от интерфейса ICrane
    /// <typeparam name="T"></typeparam>
    public class Parking<T> : IEnumerator<T>, IEnumerable<T> where T : class, ICrane
    {
        // Список объектов, которые храним
        private readonly List<T> _places;
        // Максимальное количество мест на стоянке
        private readonly int _maxCount;
        // Ширина окна отрисовки
        private readonly int pictureWidth;
        // Высота окна отрисовки
        private readonly int pictureHeight;
        // Размер парковочного места (ширина)
        private readonly int _placeSizeWidth = 240;
        // Размер парковочного места (высота)
        private readonly int _placeSizeHeight = 350;
        // Текущий элемент для вывода через IEnumerator
        private int _currentIndex;

        public T Current => _places[_currentIndex];
        object IEnumerator.Current => _places[_currentIndex];

        /// Конструктор
        /// <param name="picWidth">Рамзер стоянки - ширина</param>
        /// <param name="picHeight">Рамзер стоянки - высота</param>
        public Parking(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _maxCount = width * height;
            pictureWidth = picWidth;
            pictureHeight = picHeight;
            _places = new List<T>();
            _currentIndex = -1;
        }

        // Перегрузка оператора сложения
        // Логика действия: на стоянку добавляется кран
        /// <param name="p">Стоянка</param>
        /// <param name="crane">Добавляемый кран</param>
        public static bool operator +(Parking<T> p, T crane)
        {
            if (p._places.Count >= p._maxCount)
            {
                throw new ParkingOverflowException();
            }
            if (p._places.Contains(crane))
            {
                throw new ParkingAlreadyHaveException();
            }
            p._places.Add(crane);
            return true;
        }

        // Перегрузка оператора вычитания
        // Логика действия: с парковки забираем кран
        /// <param name="p">Стоянка</param>
        /// <param name="index">Индекс места, с которого пытаемся извлечь объект</param>
        public static T operator -(Parking<T> p, int index)
        {
            if (index < -1 || index >= p._places.Count)
            {
                throw new CraneNotFoundException(index);
            }
            T crane = p._places[index];
            p._places.RemoveAt(index);
            return crane;
        }

        // Метод отрисовки стоянки
        /// <param name="g"></param>
        public void Draw(Graphics g)
        {
            int interval = 35;
            int x = 5;
            int y = 235;
            int placesWidth = pictureWidth / _placeSizeWidth;
            DrawMarking(g);
            for (int i = 0; i < _places.Count; ++i)
            {
                _places[i].SetPosition(x + (_placeSizeWidth + interval) * (i % placesWidth), y + _placeSizeHeight * (i / placesWidth), pictureWidth, pictureHeight); ;
                _places[i].DrawCrane(g);
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
                    g.DrawLine(pen, x + (_placeSizeWidth + interval) * i, j * _placeSizeHeight, x + _placeSizeWidth + (_placeSizeWidth + interval) * i, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * (_placeSizeWidth + interval), 0, i * (_placeSizeWidth + interval), (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
            }
        }

        // Функция получения элемента из списка
        public T GetNext(int index)
        {
            if (index < 0 || index >= _places.Count)
            {
                return null;
            }
            return _places[index];
        }

        // Сортировка автомобилей на парковке
        public void Sort() => _places.Sort((IComparer<T>)new CraneComparer());

        // Метод интерфейса IEnumerator, вызываемый при удалении объекта
        public void Dispose()
        {
        }

        // Метод интерфейса IEnumerator для перехода к следующему элементу или началу коллекции
        public bool MoveNext()
        {
            _currentIndex++;
            return (_currentIndex < _places.Count);
        }

        // Метод интерфейса IEnumerator для сброса и возврата к началу коллекции
        public void Reset()
        {
            _currentIndex = -1;
        }

        // Метод интерфейса IEnumerable
        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }

        // Метод интерфейса IEnumerable
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }
    }
}