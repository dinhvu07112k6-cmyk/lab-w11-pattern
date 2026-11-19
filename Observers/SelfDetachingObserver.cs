using lab_11.Interfaces;
using lab_11.Models;
using lab_11.Sensors;


namespace lab_11.Observers
{
    public sealed class SelfDetachingObserver : IAlertObserver
    {
        private readonly SensorMonitor monitor;

        public SelfDetachingObserver(SensorMonitor monitor)
        {
            this.monitor = monitor;
        }

        public void Update(AlertEvent alertEvent)
        {
            Console.WriteLine("[SELF] Received alert and detached");
            monitor.Detach(this);
        }
    }
}