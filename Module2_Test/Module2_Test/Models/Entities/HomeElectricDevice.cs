using System;
using Module2_Test.Enums;

namespace Module2_Test.Models.Entities
{
    public abstract class HomeElectricDevice
    {
        protected HomeElectricDevice(DateTime dateOfManufacture, Countries countryProducer, Producers producerName, string modelName, double width, double height, double length, int wattage)
        {
            DateOfManufacture = dateOfManufacture;
            CountryProducer = countryProducer;
            ProducerName = producerName;
            ModelName = modelName;
            Width = width;
            Height = height;
            Length = length;
            Wattage = wattage;
        }

        public DateTime DateOfManufacture { get; }

        public Countries CountryProducer { get; }

        public Producers ProducerName { get; }

        public string ModelName { get; }

        public double Width { get; }

        public double Height { get; }

        public double Length { get; }

        public double Wattage { get; }

        public abstract bool IsWireless { get; }
    }
}
