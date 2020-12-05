
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WindowsFormsCrane
{
    public class ParkingCollection
    {
        // Словарь (хранилище) со стоянками
        readonly Dictionary<string, Parking<Platform>> parkingStages;
        // Возвращение списка названий стоянок
        public List<string> Keys => parkingStages.Keys.ToList();
        // Ширина окна отрисовки
        private readonly int pictureWidth;
        // Высота окна отрисовки
        private readonly int pictureHeight;
        // Разделитель для записи информации в файл
        private readonly char separator = ':';

        // Конструктор
        /// <param name="pictureWidth"></param>
        /// <param name="pictureHeight"></param>
        public ParkingCollection(int pictureWidth, int pictureHeight)
        {
            parkingStages = new Dictionary<string, Parking<Platform>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }

        // Добавление стоянки
        /// <param name="name">Название стоянки</param>
        public void AddParking(string name)
        {
            if (parkingStages.ContainsKey(name))
            {
                return;
            }
            parkingStages.Add(name, new Parking<Platform>(pictureWidth, pictureHeight));
        }

        // Удаление стоянки
        /// <param name="name">Название стоянки</param>
        public void DelParking(string name)
        {
            if (parkingStages.ContainsKey(name))
            {
                parkingStages.Remove(name);
            }
        }

        // Доступ к стоянке
        /// <param name="ind"></param>
        public Parking<Platform> this[string ind]
        {
            get
            {
                if (parkingStages.ContainsKey(ind))
                {
                    return parkingStages[ind];
                }
                return null;
            }
        }

        // Сохранение информации по кранам на стоянках в файл
        /// <param name="filename">Путь и имя файла</param>
        public void SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.WriteLine($"ParkingCollection");
                foreach (var level in parkingStages)
                {
                    //Начинаем стоянку
                    sw.WriteLine($"Parking{separator}{level.Key}");
                    ICrane crane = null;
                    for (int i = 0; (crane = level.Value.GetNext(i)) != null; i++)
                    {
                        if (crane != null)
                        {
                            //если место не пустое
                            //Записываем тип крана
                            if (crane.GetType().Name == "TrackedVehicle")
                            {
                                sw.Write($"TrackedVehicle{separator}");
                            }
                            if (crane.GetType().Name == "HoistingCrane")
                            {
                                sw.Write($"HoistingCrane{separator}");
                            }
                            //Записываемые параметры
                            sw.WriteLine(crane);
                        }
                    }
                }
                sw.Close();
            }
        }

        // Загрузка нформации по кранам на стоянках из файла
        public void LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }
            using (StreamReader sr = new StreamReader(filename))
            {
                string line;
                string key = string.Empty;
                if ((line = sr.ReadLine()).Contains("ParkingCollection"))
                {
                    //очищаем записи
                    parkingStages.Clear();
                    Platform crane = null;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.Contains("Parking"))
                        {
                            //начинаем новую стоянку
                            key = line.Split(separator)[1];
                            parkingStages.Add(key, new Parking<Platform>(pictureWidth, pictureHeight));
                            continue;
                        }
                        if (string.IsNullOrEmpty(line))
                        {
                            continue;
                        }
                        if (line.Contains("TrackedVehicle"))
                        {
                            crane = new TrackedVehicle(line.Split(separator)[1]);
                        }
                        else if (line.Contains("HoistingCrane"))
                        {
                            crane = new HoistingCrane(line.Split(separator)[1]);
                        }
                        var result = parkingStages[key] + crane;
                        if (!result)
                        {
                            throw new TypeLoadException();
                        }
                    }
                    sr.Close();
                }
                else
                {
                    throw new FormatException();
                }
            }
        }
    }
}



