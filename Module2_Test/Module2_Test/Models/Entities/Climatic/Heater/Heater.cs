using System;
using Module2_Test.Enums;

namespace Module2_Test.Models.Entities.Climatic.Heater
{
    public class Heater : ClimaticDevice
    {
        public Heater(DateTime dateOfManufacture, Countries countryProducer, Producers producerName, string modelName, double width, double height, double length, int wattage, HeatingElementTypes heatingElementType, double coveredArea)
            : base(dateOfManufacture, countryProducer, producerName, modelName, width, height, length, wattage, coveredArea)
        {
            HeatingElementType = heatingElementType;
        }

        public HeatingElementTypes HeatingElementType { get; }

        public override bool IsWireless => false;
    }
}
