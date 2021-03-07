using System;
using Module2_Test.Enums;

namespace Module2_Test.Models.Entities.HealthBeauty.MouthCleaning.Irrigator
{
    public class Irrigator : MouthCleaningDevice
    {
        protected Irrigator(DateTime dateOfManufacture, Countries countryProducer, Producers producerName, string modelName, double width, double height, double length, int wattage, CleaningTechnologyTypes cleaningTechnologyType, double liquidContaiberVolume, double liquidContainerVolume)
            : base(dateOfManufacture, countryProducer, producerName, modelName, width, height, length, wattage, cleaningTechnologyType)
        {
            LiquidContaiberVolume = liquidContainerVolume;
        }

        public double LiquidContaiberVolume { get; }
    }
}
