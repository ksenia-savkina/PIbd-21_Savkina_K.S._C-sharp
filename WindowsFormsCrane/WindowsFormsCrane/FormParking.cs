using NLog;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsCrane
{
    public partial class FormParking : Form
    {
        // Объект от класса-коллекции стоянок
        private readonly ParkingCollection parkingCollection;

        private readonly Logger logger;

        public FormParking()
        {
            InitializeComponent();
            parkingCollection = new ParkingCollection(pictureBoxParking.Width, pictureBoxParking.Height);
            logger = LogManager.GetCurrentClassLogger();
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
                try
                {
                    var crane = parkingCollection[listBoxParkings.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBoxPlace.Text);
                    if (crane != null)
                    {
                        FormCrane form = new FormCrane();
                        form.SetCrane(crane);
                        form.ShowDialog();
                        logger.Info($"Изъят кран {crane} с места {maskedTextBoxPlace.Text}");
                        Draw();
                    }
                }
                catch (CraneNotFoundException ex)
                {
                    logger.Warn("Кран не найден");
                    MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Warn("Неизвестная ошибка");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Обработка нажатия кнопки "Добавить парковку"
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddParking_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNewLevelName.Text))
            {
                logger.Warn("Название стоянки не введено");
                MessageBox.Show("Введите название стоянки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            logger.Info($"Добавили стоянку {textBoxNewLevelName.Text}");
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
                    logger.Info($"Удалили стоянку {listBoxParkings.SelectedItem.ToString()}");
                    parkingCollection.DelParking(textBoxNewLevelName.Text);
                    ReloadLevels();
                }
            }
        }

        private void listBoxParkings_SelectedIndexChanged(object sender, EventArgs e)
        {
            logger.Info($"Перешли на стоянку {listBoxParkings.SelectedItem.ToString()}");
            Draw();
        }

        private void buttonSetCrane_Click(object sender, EventArgs e)
        {
            var formCraneConfig = new FormCraneConfig();
            formCraneConfig.AddEvent(AddCrane);
            formCraneConfig.Show();
        }

        // Метод добавления крана
        /// <param name="crane"></param>
        private void AddCrane(Platform crane)
        {
            if (crane != null && listBoxParkings.SelectedIndex > -1)
            {
                try
                {
                    if ((parkingCollection[listBoxParkings.SelectedItem.ToString()]) + crane)
                    {
                        Draw();
                        logger.Info($"Добавлен кран {crane}");
                    }
                    else
                    {
                        logger.Warn("Кран не поставлен");
                        MessageBox.Show("Кран не удалось поставить");
                    }
                    Draw();
                }
                catch (ParkingOverflowException ex)
                {
                    logger.Warn("Стоянка переполнена");
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Warn("Неизвестная ошибка");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    parkingCollection.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    logger.Warn("Ошибка при сохранении");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    parkingCollection.LoadData(openFileDialog.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog.FileName);
                    ReloadLevels();
                    Draw();
                }
                catch (Exception ex)
                {
                    logger.Warn("Ошибка при загрузке");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
