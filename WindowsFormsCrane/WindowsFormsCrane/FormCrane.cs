using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsCrane
{
    public partial class FormCrane : Form
    {
        private ICrane crane;

        public FormCrane()
        {
            InitializeComponent();
        }
        /// Передача крана на форму
        public void SetCrane(ICrane crane)
        {
            this.crane = crane;
            Draw();
        }

        // Метод отрисовки крана
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxCrane.Width, pictureBoxCrane.Height);
            Graphics gr = Graphics.FromImage(bmp);
            crane?.DrawCrane(gr);
            pictureBoxCrane.Image = bmp;
        }

        // Обработка нажатия кнопки "Создать гусеничную машину"
        private void buttonCreateTrackedVehicle_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            crane = new TrackedVehicle(rnd.Next(1, 3), rnd.Next(25, 50), Color.Blue);
            crane.SetPosition(rnd.Next(0, 100), rnd.Next(20, 100), pictureBoxCrane.Width, pictureBoxCrane.Height);
            Draw();
        }

        // Обработка нажатия кнопки "Создать подъемный кран"
        private void buttonCreateHoistingCrane_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            crane = new HoistingCrane(rnd.Next(1, 3), rnd.Next(25, 50), Color.Blue, Color.Gray, true, true);
            crane.SetPosition(rnd.Next(0, 100), rnd.Next(230, 325), pictureBoxCrane.Width, pictureBoxCrane.Height);
            Draw();
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    crane?.MoveCrane(Direction.Up);
                    break;
                case "buttonDown":
                    crane?.MoveCrane(Direction.Down);
                    break;
                case "buttonLeft":
                    crane?.MoveCrane(Direction.Left);
                    break;
                case "buttonRight":
                    crane?.MoveCrane(Direction.Right);
                    break;
            }
            Draw();
        }
    }
}
