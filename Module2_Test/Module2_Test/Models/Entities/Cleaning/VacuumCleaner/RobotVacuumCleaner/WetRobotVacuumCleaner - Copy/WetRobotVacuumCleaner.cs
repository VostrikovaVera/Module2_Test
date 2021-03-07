using System;
using Module2_Test.Enums;

namespace Module2_Test.Models.Entities.Cleaning.VacuumCleaner.RobotVacuumCleaner
{
    public class WetRobotVacuumCleaner : VacuumCleaner
    {
        public WetRobotVacuumCleaner(DateTime dateOfManufacture, Countries countryProducer, Producers producerName, string modelName, double width, double height, double length, int wattage, int absorptionCapacity, double waterContainerVolume)
            : base(dateOfManufacture, countryProducer, producerName, modelName, width, height, length, wattage, absorptionCapacity)
        {
            WaterContainerVolume = waterContainerVolume;
        }

        public override bool IsWireless => false;

        public override CleaningTypes CleaningType => CleaningTypes.WetCleaning;

        public double WaterContainerVolume { get; }
    }
}