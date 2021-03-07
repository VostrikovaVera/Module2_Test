using System;
using Module2_Test.Enums;

namespace Module2_Test.Models.Entities.Cleaning.SteamCleaner
{
    public class SteamCleaner : CleaningDevice
    {
        public SteamCleaner(DateTime dateOfManufacture, Countries countryProducer, Producers producerName, string modelName, double width, double height, double length, int wattage, SteamCleanerTypes steamCleanerType)
            : base(dateOfManufacture, countryProducer, producerName, modelName, width, height, length, wattage)
        {
        }

        public override bool IsWireless => false;

        public override CleaningTypes CleaningType => CleaningTypes.Steam;

        public SteamCleanerTypes SteamCleanerType { get; }
    }
}