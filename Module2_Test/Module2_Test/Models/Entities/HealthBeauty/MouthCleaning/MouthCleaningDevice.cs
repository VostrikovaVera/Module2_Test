using System;
using Module2_Test.Enums;

namespace Module2_Test.Models.Entities.HealthBeauty.MouthCleaning
{
    public abstract class MouthCleaningDevice : HealthBeautyDevice
    {
        protected MouthCleaningDevice(DateTime dateOfManufacture, Countries countryProducer, Producers producerName, string modelName, double width, double height, double length, int wattage, CleaningTechnologyTypes cleaningTechnologyType)
            : base(dateOfManufacture, countryProducer, producerName, modelName, width, height, length, wattage)
        {
            CleaningTechnologyType = cleaningTechnologyType;
        }

        public override bool IsWireless => true;

        public override UserGenders UserGender => UserGenders.Both;

        public CleaningTechnologyTypes CleaningTechnologyType { get; }
    }
}
