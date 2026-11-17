/****************/
//Mã sinh viên  : 202419021 
//Họ tên  : Phạm Đình Vũ
/****************/

using lab_11.Interfaces;
using lab_11.Models;

namespace lab_11.Sensors
{
    public sealed class SensorMonitor
    {
        private readonly List<IAlertObserver> observers = new();

        public void Attach(IAlertObserver observer)
        {
            ArgumentNullException.ThrowIfNull(observer);

            if (!observers.Contains(observer))
            {
                observers.Add(observer);
            }
        }

        public void Detach(IAlertObserver observer)
        {
            observers.Remove(observer);
        }

        public void CheckSensor(string sensorName, ISensor sensor)
        {
            ArgumentNullException.ThrowIfNull(sensor);

            double value = sensor.ReadValue();

            string? severity = value switch
            {
                >= 70 => "CRITICAL",
                >= 50 => "WARNING",
                _ => null
            };

            if (severity is null)
            {
                return;
            }

            AlertEvent alertEvent = new AlertEvent(
                sensorName,
                value,
                sensor.GetUnit(),
                severity,
                DateTime.Now);

            Notify(alertEvent);
        }

        private void Notify(AlertEvent alertEvent)
        {
            foreach (IAlertObserver observer in observers.ToArray())
            {
                try
                {
                    observer.Update(alertEvent);
                }
                catch (Exception e)
                {
                    Console.WriteLine(
                        $"[OBSERVER ERROR] {observer.GetType().Name}: {e.Message}");
                }
            }
        }
    }
}