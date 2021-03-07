using System;
using Module2_Test.Enums;

namespace Module2_Test.Models.Entities.HealthBeauty.MouthCleaning.Toothbrush
{
    public class Toothbrush : MouthCleaningDevice
    {
        protected Toothbrush(DateTime dateOfManufacture, Countries countryProducer, Producers producerName, string modelName, double width, double height, double length, int wattage, CleaningTechnologyTypes cleaningTechnologyType)
            : base(dateOfManufacture, countryProducer, producerName, modelName, width, height, length, wattage, cleaningTechnologyType)
        {
        }
    }
}
