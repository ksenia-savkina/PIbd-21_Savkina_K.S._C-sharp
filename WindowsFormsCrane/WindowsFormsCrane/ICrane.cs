using System.Drawing;

namespace WindowsFormsCrane
{
    public interface ICrane
    {
        // Установка позиции подъемного крана
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина картинки</param>
        /// <param name="height">Высота картинки</param>
        void SetPosition(int x, int y, int width, int height);
        // Изменение направления перемещения
        /// <param name="direction">Направление</param>
        void MoveCrane(Direction direction);
        // Отрисовка
        /// <param name="g"></param>
        void DrawCrane(Graphics g);
        // Смена основного цвета
        /// <param name="color"></param>
        void SetMainColor(Color color);
    }
}
