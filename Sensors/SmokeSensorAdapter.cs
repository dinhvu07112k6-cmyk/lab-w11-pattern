using lab_11.Interfaces;      
namespace lab_11.Sensors
{
    public sealed class SmokeSensorAdapter : ISensor
    {
        private readonly LegacySmokeDetector legacy;

        public SmokeSensorAdapter(LegacySmokeDetector legacy)
        {
            this.legacy = legacy ??
                throw new ArgumentNullException(nameof(legacy));
        }

        public double ReadValue()
        {
            return legacy.GetSmokeLevel() / 10.0;
        }

        public string GetUnit()
        {
            return "% smoke";
        }
    }
}