using System;
using Module2_Test.Enums;

namespace Module2_Test.Models.Entities.Climatic
{
    public abstract class ClimaticDevice : HomeElectricDevice
    {
        protected ClimaticDevice(DateTime dateOfManufacture, Countries countryProducer, Producers producerName, string modelName, double width, double height, double length, int wattage, double coveredArea)
            : base(dateOfManufacture, countryProducer, producerName, modelName, width, height, length, wattage)
        {
            CoveredArea = coveredArea;
        }

        public double CoveredArea { get; }
    }
}
