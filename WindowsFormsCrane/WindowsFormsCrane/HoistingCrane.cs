using System.Drawing;
namespace WindowsFormsCrane
{
    public class HoistingCrane
    {
        // Левая координата отрисовки гусеничной машины
        private float _startPosX;
        // Правая кооридната отрисовки гусеничной машины
        private float _startPosY;
        // Ширина окна отрисовки
        private int _pictureWidth;
        // Высота окна отрисовки
        private int _pictureHeight;
        // Ширина отрисовки гусеничной машины
        private readonly int trackedVehicleWidth = 200;
        // Высота отрисовки гусеничной машины
        private readonly int trackedVehicleHeight = 110;
        // Высота отрисовки стрелы
        private readonly int _arrowHeight = 230;
        // Высота отрисовки кабины
        private readonly int _cabinHeight = 20;
        // Высота отрисовки противовеса
        private readonly int _counterweightHeight = 70;
        // Ширина отрисовки противовеса
        private readonly int _counterweightWidth = 30;
        // Основной цвет
        public Color MainColor { private set; get; }
        // Дополнительный цвет
        public Color DopColor { private set; get; }
        // Максимальная скорость гусеничной машины
        public int MaxSpeed { private set; get; }
        // Общая масса агрегата
        public float Weight { private set; get; }
        // Признак наличия кабины
        public bool Cabin { private set; get; }
        // Признак наличия стрелы
        public bool Arrow { private set; get; }
        // Признак наличия противовеса
        public bool Counterweight { private set; get; }

        // Конструктор
        // <param name="maxSpeed">Максимальная скорость(м/мин)</param>
        // <param name="weight">Общая масса агрегата(т)</param>
        // <param name="mainColor">Основной цвет</param>
        // <param name="dopColor">Дополнительный цвет</param>

        // <param name="cabin">Признак наличия кабины</param>
        // <param name="arrow">Признак наличия стрелы</param>
        // <param name="counterweight">Признак наличия противовеса(м)</param>
        public HoistingCrane(int maxSpeed, float weight, Color mainColor, Color dopColor, bool cabin, bool arrow, bool counterweight)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Cabin = cabin;
            Arrow = arrow;
            Counterweight = counterweight;
        }

        // Установка позиции подъемного крана
        // <param name="x">Координата X</param>
        // <param name="y">Координата Y</param>
        // <param name="width">Ширина картинки</param>
        // <param name="height">Высота картинки</param>
        public void SetPosition(int x, int y, int width, int height)
        {
            if (Arrow || Cabin || Counterweight)
            {
                if (Arrow || Arrow && Counterweight && Cabin || Arrow && Counterweight || Arrow && Cabin)
                {
                    if (Arrow && Counterweight)
                        _startPosX = x + _counterweightWidth;
                    else
                        _startPosX = x;                     
                    _startPosY = y + _arrowHeight;
                }
                else if (Counterweight || Cabin && Counterweight)
                {
                    _startPosX = x + _counterweightWidth;
                    _startPosY = y + _counterweightHeight;
                }
                else if (Cabin)
                {
                    _startPosX = x;
                    _startPosY = y + _cabinHeight;
                }
            }
            else if (_startPosX >= 0 && _startPosX < _pictureWidth - trackedVehicleWidth &&
                _startPosY >= 0 && _startPosY < _pictureHeight - trackedVehicleHeight)
            {
                _startPosX = x;
                _startPosY = y;
            }
            _pictureHeight = height;
            _pictureWidth = width;
        }

        // Изменение направления пермещения
        public void MoveCrane(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (Counterweight)
                    {
                        if (_startPosX + step < _pictureWidth - (trackedVehicleWidth + _counterweightWidth))
                            _startPosX += step;
                    }
                    else if (_startPosX + step < _pictureWidth - trackedVehicleWidth)
                        _startPosX += step;
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > 0)
                        _startPosX -= step;
                    break;
                //вверх
                case Direction.Up:
                    if (Arrow || Cabin || Counterweight)
                    {
                        if (Arrow || Arrow && Counterweight && Cabin || Arrow && Counterweight || Arrow && Cabin)
                        {
                            if (_startPosY - step > _arrowHeight)
                                _startPosY -= step;
                        }
                        else if (Counterweight || Cabin && Counterweight)
                        {
                            if (_startPosY - step > _counterweightHeight)
                                _startPosY -= step;
                        }
                        else if (Cabin)
                        {
                            if (_startPosY - step > _cabinHeight)
                                _startPosY -= step;
                        }
                    }
                    else if (_startPosY - step > 0)
                        _startPosY -= step;
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - trackedVehicleHeight)
                        _startPosY += step;
                    break;
            }
        }

        // Отрисовка 
        public void DrawCrane(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            // гусеничная машина
            Brush brM = new SolidBrush(MainColor);
            g.FillRectangle(brM, _startPosX + 70, _startPosY, 130, 50);
            g.DrawRectangle(pen, _startPosX + 70, _startPosY, 130, 50);

            Brush brD = new SolidBrush(DopColor);
            g.FillRectangle(brD, _startPosX + 70, _startPosY + 50, 50, 10);
            g.DrawRectangle(pen, _startPosX + 70, _startPosY + 50, 50, 10);

            Point[] points = new Point[6]
            {
                new Point((int)(_startPosX), (int)(_startPosY + 70)),
                new Point((int)(_startPosX), (int)(_startPosY + 110)),
                new Point((int)(_startPosX + 190), (int)(_startPosY + 110)),
                new Point((int)(_startPosX + 190), (int)(_startPosY + 70)),
                new Point((int)(_startPosX + 170), (int)(_startPosY + 60)),
                new Point((int)(_startPosX + 20), (int)(_startPosY + 60)),
            };
            g.FillPolygon(brD, points);
            g.DrawPolygon(pen, points);

            Brush br1 = new SolidBrush(Color.Black);
            g.FillEllipse(br1, _startPosX, _startPosY + 70, 38, 38);
            g.FillEllipse(br1, _startPosX + 38, _startPosY + 70, 38, 38);
            g.FillEllipse(br1, _startPosX + 38 * 2, _startPosY + 70, 38, 38);
            g.FillEllipse(br1, _startPosX + 38 * 3, _startPosY + 70, 38, 38);
            g.FillEllipse(br1, _startPosX + 38 * 4, _startPosY + 70, 38, 38);

            if (Cabin)
            {
                g.FillRectangle(brM, _startPosX + 20, _startPosY - 20, 50, 70);
                g.DrawRectangle(pen, _startPosX + 20, _startPosY - 20, 50, 70);
                g.FillRectangle(new SolidBrush(Color.LightBlue), _startPosX + 30, _startPosY - 10, 30, 40);
                g.DrawRectangle(pen, _startPosX + 30, _startPosY - 10, 30, 40);
            }
            if (Counterweight)
            {
                g.FillRectangle(brD, _startPosX + 200, _startPosY - 10, 30, 60);
                g.DrawRectangle(pen, _startPosX + 200, _startPosY - 10, 30, 60);
                g.FillEllipse(brD, _startPosX + 190, _startPosY - 70, 20, 20);
                g.DrawEllipse(pen, _startPosX + 190, _startPosY - 70, 20, 20);
                g.DrawLine(pen, _startPosX + 200, _startPosY - 10, _startPosX + 200, _startPosY - 60);
                g.DrawLine(pen, _startPosX + 120, _startPosY, _startPosX + 200, _startPosY - 60);
            }
            if (Arrow)
            {
                g.DrawLine(pen, _startPosX + 30, _startPosY - 230, _startPosX + 200, _startPosY - 60);
                g.DrawLine(pen, _startPosX + 70, _startPosY - 100, _startPosX + 120, _startPosY);

                g.FillRectangle(brD, _startPosX + 10, _startPosY - 230, 20, 20);
                g.DrawRectangle(pen, _startPosX + 10, _startPosY - 230, 20, 20);

                g.FillEllipse(brD, _startPosX, _startPosY - 230, 10, 10);
                g.DrawEllipse(pen, _startPosX, _startPosY - 230, 10, 10);

                g.DrawLine(pen, _startPosX + 5, _startPosY - 225, _startPosX + 5, _startPosY - 140);

                g.FillEllipse(brD, _startPosX + 2, _startPosY - 140, 6, 10);
                g.DrawEllipse(pen, _startPosX + 2, _startPosY - 140, 6, 10);

                g.DrawLine(pen, _startPosX + 10, _startPosY - 210, _startPosX + 10, _startPosY - 100);
                g.DrawLine(pen, _startPosX + 20, _startPosY - 210, _startPosX + 20, _startPosY - 100);

                g.FillEllipse(brD, _startPosX + 10, _startPosY - 110, 10, 15);
                g.DrawEllipse(pen, _startPosX + 10, _startPosY - 110, 10, 15);

                Point[] points2 = new Point[4]
                {
                new Point((int)(_startPosX + 70), (int)(_startPosY + 30)),
                new Point((int)(_startPosX + 70), (int)(_startPosY - 100)),
                new Point((int)(_startPosX + 20), (int)(_startPosY - 230)),
                new Point((int)(_startPosX + 30), (int)(_startPosY - 100)),
                };
                g.DrawPolygon(pen, points2);
                g.DrawArc(pen, _startPosX + 10, _startPosY - 95, 10, 10, -90, 270);

                g.DrawLine(pen, _startPosX + 23, _startPosY - 190, _startPosX + 34, _startPosY - 190);
                g.DrawLine(pen, _startPosX + 26, _startPosY - 150, _startPosX + 50, _startPosY - 150);

                g.DrawLine(pen, _startPosX + 23, _startPosY - 190, _startPosX + 50, _startPosY - 150);
                g.DrawLine(pen, _startPosX + 26, _startPosY - 150, _startPosX + 34, _startPosY - 190);

                g.DrawLine(pen, _startPosX + 26, _startPosY - 150, _startPosX + 67, _startPosY - 110);
                g.DrawLine(pen, _startPosX + 30, _startPosY - 110, _startPosX + 50, _startPosY - 150);

                g.DrawLine(pen, _startPosX + 30, _startPosY - 110, _startPosX + 67, _startPosY - 110);
                g.DrawLine(pen, _startPosX + 33, _startPosY - 90, _startPosX + 69, _startPosY - 90);

                g.DrawLine(pen, _startPosX + 46, _startPosY - 50, _startPosX + 69, _startPosY - 90);
                g.DrawLine(pen, _startPosX + 33, _startPosY - 90, _startPosX + 70, _startPosY - 50);

                g.DrawLine(pen, _startPosX + 46, _startPosY - 50, _startPosX + 70, _startPosY - 50);
                g.DrawLine(pen, _startPosX + 59, _startPosY - 10, _startPosX + 70, _startPosY - 10);

                g.DrawLine(pen, _startPosX + 46, _startPosY - 50, _startPosX + 70, _startPosY - 10);
                g.DrawLine(pen, _startPosX + 59, _startPosY - 10, _startPosX + 70, _startPosY - 50);
            }
        }
    }
}
