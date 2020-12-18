using System.Collections.Generic;

namespace WindowsFormsCrane
{
    public class CraneComparer : IComparer<Platform>
    {
        public int Compare(Platform x, Platform y)
        {
            if (x is HoistingCrane && y is HoistingCrane)
            {
                return ComparerHoistingCrane((HoistingCrane)x, (HoistingCrane)y);
            }
            if (x is HoistingCrane && y is TrackedVehicle)
            {
                return -1;
            }
            if (x is TrackedVehicle && y is HoistingCrane)
            {
                return 1;
            }
            if (x is TrackedVehicle && y is TrackedVehicle)
            {
                return ComparerTrackedVehicle((TrackedVehicle)x, (TrackedVehicle)y);
            }
            return 0;
        }

        private int ComparerTrackedVehicle(TrackedVehicle x, TrackedVehicle y)
        {
            if (x.MaxSpeed != y.MaxSpeed)
            {
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
            }
            if (x.Weight != y.Weight)
            {
                return x.Weight.CompareTo(y.Weight);
            }
            if (x.MainColor != y.MainColor)
            {
                return x.MainColor.Name.CompareTo(y.MainColor.Name);
            }
            return 0;
        }

        private int ComparerHoistingCrane(HoistingCrane x, HoistingCrane y)
        {
            var res = ComparerTrackedVehicle(x, y);
            if (res != 0)
            {
                return res;
            }
            if (x.DopColor != y.DopColor)
            {
                return x.DopColor.Name.CompareTo(y.DopColor.Name);
            }
            if (x.Arrow != y.Arrow)
            {
                return x.Arrow.CompareTo(y.Arrow);
            }
            if (x.Counterweight != y.Counterweight)
            {
                return x.Counterweight.CompareTo(y.Counterweight);
            }
            return 0;
        }

    }
}
