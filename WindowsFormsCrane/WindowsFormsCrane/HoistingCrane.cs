using System;
using System.Drawing;
namespace WindowsFormsCrane
{
    public class HoistingCrane : TrackedVehicle
    {
        // Высота отрисовки стрелы
        private readonly int _arrowHeight = 230;
        // Высота отрисовки противовеса
        private readonly int _counterweightHeight = 70;
        // Ширина отрисовки противовеса
        private readonly int _counterweightWidth = 30;
        // Дополнительный цвет
        public Color DopColor { private set; get; }
        // Признак наличия стрелы
        public bool Arrow { private set; get; }
        // Признак наличия противовеса
        public bool Counterweight { private set; get; }

        // Конструктор
        /// <param name="maxSpeed">Максимальная скорость(м/мин)</param>
        /// <param name="weight">Общая масса агрегата(т)</param>
        /// <param name="mainColor">Основной цвет</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        /// <param name="arrow">Признак наличия стрелы</param>
        /// <param name="counterweight">Признак наличия противовеса(м)</param>
        public HoistingCrane(int maxSpeed, float weight, Color mainColor, Color dopColor, bool arrow, bool counterweight) :
            base(maxSpeed, weight, mainColor, 200, 110)
        {
            DopColor = dopColor;
            Arrow = arrow;
            Counterweight = counterweight;
        }

        // Конструктор для загрузки с файла
        /// <param name="info"></param>
        public HoistingCrane(string info) : base(info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 6)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                Arrow = Convert.ToBoolean(strs[4]);
                Counterweight = Convert.ToBoolean(strs[5]);
            }
        }

        // Изменение направления пермещения
        public override void MoveCrane(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (Counterweight)
                    {
                        if (_startPosX + step < _pictureWidth - (trackedVehicleWidth + _counterweightWidth))
                        {
                            _startPosX += step;
                        }
                    }
                    else
                    {
                        base.MoveCrane(Direction.Right);
                    }
                    break;
                //влево
                case Direction.Left:
                    base.MoveCrane(Direction.Left);
                    break;
                //вверх
                case Direction.Up:
                    if (Arrow || Counterweight)
                    {
                        if (Arrow || Arrow && Counterweight)
                        {
                            if (_startPosY - step > _arrowHeight)
                            {
                                _startPosY -= step;
                            }
                        }
                        else if (Counterweight)
                        {
                            if (_startPosY - step > _counterweightHeight)
                            {
                                _startPosY -= step;
                            }
                        }
                    }
                    else
                    {
                        base.MoveCrane(Direction.Up);
                    }
                    break;
                //вниз
                case Direction.Down:
                    base.MoveCrane(Direction.Down);
                    break;
            }
        }
        // Отрисовка 
        public override void DrawCrane(Graphics g)
        {
            base.DrawCrane(g);
            Pen pen = new Pen(Color.Black);
            Brush brD = new SolidBrush(DopColor);

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

        // Смена дополнительного цвета
        /// <param name="color"></param>
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }

        public override string ToString()
        {
            return $"{base.ToString()}{separator}{DopColor.Name}{separator}{Arrow}{separator}{Counterweight}";
        }
    }
}
