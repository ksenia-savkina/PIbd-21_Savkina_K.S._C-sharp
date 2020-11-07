using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsCrane
{
    public partial class FormParking : Form
    {
        // Объект от класса-коллекции стоянок
        private readonly ParkingCollection parkingCollection;
        public FormParking()
        {
            InitializeComponent();
            parkingCollection = new ParkingCollection(pictureBoxParking.Width, pictureBoxParking.Height);
        }

        // Заполнение listBoxLevels
        private void ReloadLevels()
        {
            int index = listBoxParkings.SelectedIndex;
            listBoxParkings.Items.Clear();
            for (int i = 0; i < parkingCollection.Keys.Count; i++)
            {
                listBoxParkings.Items.Add(parkingCollection.Keys[i]);
            }
            if (listBoxParkings.Items.Count > 0 && (index == -1 || index >= listBoxParkings.Items.Count))
            {
                listBoxParkings.SelectedIndex = 0;
            }
            else if (listBoxParkings.Items.Count > 0 && index > -1 && index < listBoxParkings.Items.Count)
            {
                listBoxParkings.SelectedIndex = index;
            }
        }

        // Метод отрисовки стоянки
        private void Draw()
        {
            if (listBoxParkings.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
                Graphics gr = Graphics.FromImage(bmp);
                parkingCollection[listBoxParkings.SelectedItem.ToString()].Draw(gr);
                pictureBoxParking.Image = bmp;
            }
        }

        private void buttonTakeCrane_Click(object sender, EventArgs e)
        {
            if (listBoxParkings.SelectedIndex > -1 && maskedTextBoxPlace.Text != "")
            {
                var crane = parkingCollection[listBoxParkings.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBoxPlace.Text);
                if (crane != null)
                {
                    FormCrane form = new FormCrane();
                    form.SetCrane(crane);
                    form.ShowDialog();
                }
                Draw();
            }
        }

        // Обработка нажатия кнопки "Добавить парковку"
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddParking_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNewLevelName.Text))
            {
                MessageBox.Show("Введите название стоянки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            parkingCollection.AddParking(textBoxNewLevelName.Text);
            ReloadLevels();
        }

        // Обработка нажатия кнопки "Удалить парковку"
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelParking_Click(object sender, EventArgs e)
        {
            if (listBoxParkings.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить стоянку {listBoxParkings.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    parkingCollection.DelParking(textBoxNewLevelName.Text);
                    ReloadLevels();
                }
            }
        }

        private void listBoxParkings_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void buttonSetCrane_Click(object sender, EventArgs e)
        {
            var formCraneConfig = new FormCraneConfig();
            formCraneConfig.AddEvent(AddCrane);
            formCraneConfig.Show();
        }

        // Метод добавления машины
        /// <param name="crane"></param>
        private void AddCrane(Platform crane)
        {
            if (crane != null && listBoxParkings.SelectedIndex > -1)
            {
                if ((parkingCollection[listBoxParkings.SelectedItem.ToString()]) + crane)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Кран не удалось поставить");
                }
            }
        }
    }
}
