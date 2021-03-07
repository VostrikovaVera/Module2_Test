using Module2_Test.Enums;
using Module2_Test.Models;
using Module2_Test.Models.Entities;

namespace Module2_Test.Helpers
{
    public static class SmartHomeExtension
    {
        public static HomeElectricDevice[] FilterProducerOrigin(this HomeElectricDevice[] devices, Producers producer, Countries country)
        {
            var filteredItems = new HomeElectricDevice[devices.Length];
            var count = 0;

            for (var i = 0; i < devices.Length; i++)
            {
                if (devices[i].ProducerName == producer && devices[i].CountryProducer == country)
                {
                    filteredItems[i] = devices[i];
                    count++;
                }
            }

            if (count == 0)
            {
                return null;
            }

            var result = new HomeElectricDevice[count];
            var counter = 0;

            for (var i = 0; i < filteredItems.Length; i++)
            {
                if (filteredItems[i] != null)
                {
                    result[counter] = filteredItems[i];
                    counter++;
                }
            }

            return result;
        }
    }
}
