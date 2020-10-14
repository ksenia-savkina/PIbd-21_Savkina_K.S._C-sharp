
using System.Drawing;

namespace WindowsFormsCrane
{
    public abstract class Platform : ICrane
    {
        // Левая координата отрисовки гусеничной машины
        protected float _startPosX;
        // Правая кооридната отрисовки гусеничной машины
        protected float _startPosY;
        // Ширина окна отрисовки
        protected int _pictureWidth;
        // Высота окна отрисовки
        protected int _pictureHeight;
        // Максимальная скорость гусеничной машины
        public int MaxSpeed { protected set; get; }
        // Общая масса агрегата
        public float Weight { protected set; get; }
        // Основной цвет
        public Color MainColor { protected set; get; }
        public abstract void DrawCrane(Graphics g);
        public abstract void MoveCrane(Direction direction);
        public void SetPosition(int x, int y, int width, int height)
        {
            _pictureHeight = height;
            _pictureWidth = width;
            _startPosX = x;
            _startPosY = y;
        }
    }
}
