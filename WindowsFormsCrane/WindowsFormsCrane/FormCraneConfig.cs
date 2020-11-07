using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsCrane
{
    public partial class FormCraneConfig : Form
    {

        // Переменная-выбранный кран
        Platform crane = null;

        // Событие
        private event Action<Platform> eventAddCrane;

        public FormCraneConfig()
        {
            InitializeComponent();
            panelPink.MouseDown += panelColor_MouseDown;
            panelOrange.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelAqua.MouseDown += panelColor_MouseDown;
            panelGray.MouseDown += panelColor_MouseDown;
            panelPurple.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;
            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }

        // Отрисовать кран
        private void DrawCrane()
        {
            if (crane != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxCrane.Width, pictureBoxCrane.Height);
                Graphics gr = Graphics.FromImage(bmp);
                crane.SetPosition(25, 250, pictureBoxCrane.Width, pictureBoxCrane.Height);
                crane.DrawCrane(gr);
                pictureBoxCrane.Image = bmp;
            }
        }

        // Добавление события
        public void AddEvent(Action<Platform> ev)
        {
            if (eventAddCrane == null)
            {
                eventAddCrane = new Action<Platform>(ev);
            }
            else
            {
                eventAddCrane += ev;
            }
        }

        // Передаем информацию при нажатии на Label
        private void labelTrackedVehicle_MouseDown(object sender, MouseEventArgs e)
        {
            labelTrackedVehicle.DoDragDrop(labelTrackedVehicle.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelHoistingCrane_MouseDown(object sender, MouseEventArgs e)
        {
            labelHoistingCrane.DoDragDrop(labelHoistingCrane.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        // Проверка получаемой информации (ее типа на соответствие требуемому)
        private void panelCrane_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        // Действия при приеме перетаскиваемой информации
        private void panelCrane_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Гусеничная машина":
                    crane = new TrackedVehicle((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value, Color.White);
                    break;
                case "Подъемный кран":
                    crane = new HoistingCrane((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value, Color.White, Color.Black, checkBoxArrow.Checked, checkBoxCounterweight.Checked);
                    break;
            }
            DrawCrane();
        }

        // Отправляем цвет с панели
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }

        // Проверка получаемой информации (ее типа на соответствие требуемому)
        private void labelMainColor_DragEnter(object sender, DragEventArgs e)
        {

            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        // Принимаем основной цвет
        private void labelMainColor_DragDrop(object sender, DragEventArgs e)
        {
            if (crane != null)
            {
                crane.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawCrane();
            }
        }

        // Принимаем дополнительный цвет
        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (crane != null)
            {
                if (crane is HoistingCrane)
                {
                    (crane as HoistingCrane).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawCrane();
                }
            }
        }

        // Добавление крана
        private void buttonOk_Click(object sender, EventArgs e)
        {
            eventAddCrane?.Invoke(crane);
            Close();
        }
    }
}
