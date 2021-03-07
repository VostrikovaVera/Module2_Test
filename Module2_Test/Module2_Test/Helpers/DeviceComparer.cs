using System.Collections;
using Module2_Test.Models.Entities;

namespace Module2_Test.Helpers
{
    public class DeviceComparer : IComparer
    {
        public int Compare(object i1, object i2)
        {
            var a = i1 as HomeElectricDevice;
            var b = i2 as HomeElectricDevice;

            if (a.DateOfManufacture > b.DateOfManufacture)
            {
                return -1;
            }
            else if (a.DateOfManufacture < b.DateOfManufacture)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
