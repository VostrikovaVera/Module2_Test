using System;
using Module2_Test.Enums;

namespace Module2_Test.Models.Entities.Cleaning.VacuumCleaner
{
    public abstract class VacuumCleaner : CleaningDevice
    {
        protected VacuumCleaner(DateTime dateOfManufacture, Countries countryProducer, Producers producerName, string modelName, double width, double height, double length, int wattage, int absorptionCapacity)
            : base(dateOfManufacture, countryProducer, producerName, modelName, width, height, length, wattage)
        {
            AbsorptionCapacity = absorptionCapacity;
        }

        public int AbsorptionCapacity { get; }
    }
}