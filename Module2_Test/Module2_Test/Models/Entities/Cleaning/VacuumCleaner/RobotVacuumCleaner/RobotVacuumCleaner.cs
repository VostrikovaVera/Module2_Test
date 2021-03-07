using System;
using Module2_Test.Enums;

namespace Module2_Test.Models.Entities.Cleaning.VacuumCleaner.RobotVacuumCleaner
{
    public class RobotVacuumCleaner : VacuumCleaner
    {
        protected RobotVacuumCleaner(DateTime dateOfManufacture, Countries countryProducer, Producers producerName, string modelName, double width, double height, double length, int wattage, int absorptionCapacity)
            : base(dateOfManufacture, countryProducer, producerName, modelName, width, height, length, wattage, absorptionCapacity)
        {
        }

        public override bool IsWireless => true;
    }
}