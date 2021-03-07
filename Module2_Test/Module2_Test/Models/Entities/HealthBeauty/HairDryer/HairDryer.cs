using System;
using Module2_Test.Enums;

namespace Module2_Test.Models.Entities.HealthBeauty.HairDryer
{
    public class HairDryer : HealthBeautyDevice
    {
        protected HairDryer(DateTime dateOfManufacture, Countries countryProducer, Producers producerName, string modelName, double width, double height, double length, int wattage, int numberOfSpeed)
            : base(dateOfManufacture, countryProducer, producerName, modelName, width, height, length, wattage)
        {
            NumberOfSpeed = numberOfSpeed;
        }

        public int NumberOfSpeed { get; }

        public override UserGenders UserGender => UserGenders.Both;

        public override bool IsWireless => false;
    }
}
