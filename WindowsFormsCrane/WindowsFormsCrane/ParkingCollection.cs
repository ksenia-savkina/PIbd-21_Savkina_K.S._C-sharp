
using System.Collections.Generic;
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
    }
}

