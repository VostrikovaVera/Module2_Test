using System;
using Module2_Test.Enums;
using Module2_Test.Helpers;
using Module2_Test.Services;
using Module2_Test.Services.Contracts;

namespace Module2_Test
{
    public class Starter
    {
        private readonly IHomeDeviceService _homeDeviceService;

        public Starter()
        {
            _homeDeviceService = new HomeDeviceService();
        }

        public void Run()
        {
            var smartHome = _homeDeviceService.CreateSmartHome();

            Array.Sort(smartHome.Devices, new DeviceComparer());

            Console.WriteLine($"There are {smartHome.PowerConsumption} types of animals living in this section!");

            for (var i = 0; i < smartHome.Devices.Length; i++)
            {
                Console.WriteLine($"Producer: {smartHome.Devices[i].ProducerName} Model: {smartHome.Devices[i].ModelName} Country of origin: {smartHome.Devices[i].CountryProducer}");
            }

            Console.WriteLine("----------------------------");

            var devicesFiltered = smartHome.Devices.FilterProducerOrigin(Producers.Xiaomi, Countries.China);

            for (var i = 0; i < devicesFiltered.Length; i++)
            {
                Console.WriteLine($"Producer: {devicesFiltered[i].ProducerName} Model: {devicesFiltered[i].ModelName} Country of origin: {devicesFiltered[i].CountryProducer}");
            }
        }
    }
}