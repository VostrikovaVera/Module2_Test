using System;
using Module2_Test.Enums;

namespace Module2_Test.Models.Entities.Cleaning
{
    public abstract class CleaningDevice : HomeElectricDevice
    {
        protected CleaningDevice(DateTime dateOfManufacture, Countries countryProducer, Producers producerName, string modelName, double width, double height, double length, int wattage)
            : base(dateOfManufacture, countryProducer, producerName, modelName, width, height, length, wattage)
        {
        }

        public abstract CleaningTypes CleaningType { get; }
    }
}