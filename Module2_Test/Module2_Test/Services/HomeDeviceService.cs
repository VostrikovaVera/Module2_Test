using System;
using Module2_Test.Enums;
using Module2_Test.Models.Entities;
using Module2_Test.Models.Entities.Cleaning.VacuumCleaner.RobotVacuumCleaner;
using Module2_Test.Models.Entities.Climatic.Heater;
using Module2_Test.Models.Entities.HealthBeauty.HairDryer;
using Module2_Test.Models.Entities.HealthBeauty.MouthCleaning.Toothbrush;
using Module2_Test.Services.Contracts;

namespace Module2_Test.Services
{
    public class HomeDeviceService : IHomeDeviceService
    {
        public HomeDeviceService()
        {
        }

        public HomeDevices CreateSmartHome()
        {
            var devices = new HomeElectricDevice[]
            {
                new HairDryer(new DateTime(2020, 12, 21), Countries.China, Producers.Philips, "ThermoProtect Ionic", 380, 270, 80, 2000, 4),
                new Heater(new DateTime(2020, 09, 22), Countries.China, Producers.Xiaomi, "SmartMi Electric Heater", 445, 680, 20, 1600, HeatingElementTypes.Ceramic, 20),
                new Toothbrush(new DateTime(2020, 10, 15), Countries.China, Producers.Xiaomi, "Oclean X Pro", 300, 130, 35, 1500, CleaningTechnologyTypes.Sonic),
                new DryRobotVacuumCleaner(new DateTime(2020, 06, 03), Countries.China, Producers.Xiaomi, "Xiaomi Mijia Mi Robot Vacuum Cleaner", 345, 345, 96, 2000, 1400),
            };

            double powerConsumption = 0;
            for (var i = 0; i < devices.Length; i++)
            {
                powerConsumption += devices[i].Wattage;
            }

            return new HomeDevices { Devices = devices, PowerConsumption = powerConsumption };
        }
    }
}
