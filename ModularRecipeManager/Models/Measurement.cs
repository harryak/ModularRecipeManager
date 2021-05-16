namespace ModularRecipeManager.Models
{
    public class Measurement
    {
        public MeasurementUnit MeasurementType { get; set; }

        private decimal _amount = 0;

        public decimal Amount
        {
            get { return _amount; }
            set
            {
                _amount = value < 0 ? 0 : value;
            }
        }

        public override string ToString()
        {
            return Amount + MeasurementType.ToString();
        }

        public Measurement ConvertTo(MeasurementUnit newType)
        {
            if (Amount <= 0)
            {
                return new Measurement { MeasurementType = newType };
            }

            if (newType.Type != MeasurementType.Type)
            {
                throw new System.Exception("Conversion not possible.");
            }

            throw new System.Exception("Not yet implemented.");
        }
    }
}