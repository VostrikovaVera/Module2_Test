using System;
using Module2_Test.Enums;

namespace Module2_Test.Models.Entities.Climatic.AirConditioner
{
    public class AirConditioner : ClimaticDevice
    {
        protected AirConditioner(DateTime dateOfManufacture, Countries countryProducer, Producers producerName, string modelName, double width, double height, double length, int wattage, CompressorTypes compressorType, double coveredArea)
            : base(dateOfManufacture, countryProducer, producerName, modelName, width, height, length, wattage, coveredArea)
        {
            CompressorType = compressorType;
        }

        public CompressorTypes CompressorType { get; }

        public override bool IsWireless => false;
    }
}
