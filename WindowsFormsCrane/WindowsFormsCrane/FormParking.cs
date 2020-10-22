using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsCrane
{
    public partial class FormParking : Form
    {
        // Объект от класса-стоянки
        private readonly Parking<TrackedVehicle> parking;
        public FormParking()
        {
            InitializeComponent();
            parking = new Parking<TrackedVehicle>(pictureBoxParking.Width, pictureBoxParking.Height);
            Draw();
        }

        // Метод отрисовки стоянки
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBoxParking.Image = bmp;
        }

        private void buttonSetTrackedVehicle_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var crane = new TrackedVehicle(100, 1000, dialog.Color);
                if (parking + crane)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Стоянка переполнена");
                }
            }
        }

        private void buttonSetHoistingCrane_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var crane = new HoistingCrane(100, 1000, dialog.Color, dialogDop.Color, true, true);
                    if (parking + crane)
                    {
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Стоянка переполнена");
                    }
                }
            }
        }

        private void buttonTakeCrane_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxPlace.Text != "")
            {
                var crane = parking - Convert.ToInt32(maskedTextBoxPlace.Text);
                if (crane != null)
                {
                    FormCrane form = new FormCrane();
                    form.SetCrane(crane);
                    form.ShowDialog();
                }
                Draw();
            }
        }
    }
}
