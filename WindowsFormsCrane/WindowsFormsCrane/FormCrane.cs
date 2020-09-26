using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsCrane
{
    public partial class FormCrane : Form
    {
        private HoistingCrane crane;

        public FormCrane()
        {
            InitializeComponent();
        }

        // Метод отрисовки крана
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxCrane.Width, pictureBoxCrane.Height);
            Graphics gr = Graphics.FromImage(bmp);
            crane.DrawCrane(gr);
            pictureBoxCrane.Image = bmp;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            crane = new HoistingCrane(rnd.Next(1, 3), rnd.Next(25, 50), Color.Blue, Color.Gray, true, true);
            crane.SetPosition(rnd.Next(0, 100), rnd.Next(20, 100), pictureBoxCrane.Width, pictureBoxCrane.Height);
            Draw();
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    crane.MoveCrane(Direction.Up);
                    break;
                case "buttonDown":
                    crane.MoveCrane(Direction.Down);
                    break;
                case "buttonLeft":
                    crane.MoveCrane(Direction.Left);
                    break;
                case "buttonRight":
                    crane.MoveCrane(Direction.Right);
                    break;
            }
            Draw();
        }
    }
}
