using System.Drawing;

namespace WindowsFormsCrane
{
    public class TrackedVehicle : Platform
    {
        // Ширина отрисовки гусеничной машины
        protected readonly int trackedVehicleWidth = 200;
        // Высота отрисовки гусеничной машины
        protected readonly int trackedVehicleHeight = 110;
        // Высота отрисовки кабины
        protected readonly int _cabinHeight = 20;
        public TrackedVehicle(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }

        protected TrackedVehicle(int maxSpeed, float weight, Color mainColor, int trackedVehicleWidth, int trackedVehicleHeight)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            this.trackedVehicleWidth = trackedVehicleWidth;
            this.trackedVehicleHeight = trackedVehicleHeight;
        }

        public override void MoveCrane(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - trackedVehicleWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step > _cabinHeight)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - trackedVehicleHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }

        public override void DrawCrane(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            // гусеничная машина
            Brush brM = new SolidBrush(MainColor);
            g.FillRectangle(brM, _startPosX + 70, _startPosY, 130, 50);
            g.DrawRectangle(pen, _startPosX + 70, _startPosY, 130, 50);

            Brush br1 = new SolidBrush(Color.Black);
            Brush br2 = new SolidBrush(Color.LightSteelBlue);
            g.FillRectangle(br2, _startPosX + 70, _startPosY + 50, 50, 10);
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
            g.FillPolygon(br2, points);
            g.DrawPolygon(pen, points);

            g.FillEllipse(br1, _startPosX, _startPosY + 70, 38, 38);
            g.FillEllipse(br1, _startPosX + 38, _startPosY + 70, 38, 38);
            g.FillEllipse(br1, _startPosX + 38 * 2, _startPosY + 70, 38, 38);
            g.FillEllipse(br1, _startPosX + 38 * 3, _startPosY + 70, 38, 38);
            g.FillEllipse(br1, _startPosX + 38 * 4, _startPosY + 70, 38, 38);
            g.FillRectangle(brM, _startPosX + 20, _startPosY - 20, 50, 70);
            g.DrawRectangle(pen, _startPosX + 20, _startPosY - 20, 50, 70);
            g.FillRectangle(new SolidBrush(Color.LightBlue), _startPosX + 30, _startPosY - 10, 30, 40);
            g.DrawRectangle(pen, _startPosX + 30, _startPosY - 10, 30, 40);
        }
    }
}
