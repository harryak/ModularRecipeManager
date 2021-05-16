namespace ModularRecipeManager
{
    public class MeasurementUnit
    {
        public MeasurementUnitType Type { get; }

        public MeasurementUnit BaseUnit { get; }

        public decimal BaseUnitFactor { get; }

        /// <summary>
        /// Add a new measurement unit (e.g. cups, mililiter, ...)
        /// </summary>
        /// <param name="type">One of the two types, used for conversion.</param>
        /// <param name="baseUnit">Set this unit in relation to other units, for conversion.</param>
        /// <param name="baseUnitFactor">How many [mililiters] are a [liter]?</param>
        public MeasurementUnit(MeasurementUnitType type, MeasurementUnit baseUnit, decimal baseUnitFactor)
        {
            Type = type;
            BaseUnit = baseUnit;
            BaseUnitFactor = baseUnitFactor;
        }
    }
}