/****************/
//Mã sinh viên  : 202419021 
//Họ tên  : Phạm Đình Vũ
/****************/
using lab_11.Interfaces;
using lab_11.Models;

namespace lab_11.Observers
{
    public sealed class EmailAlertObserver : IAlertObserver
    {
        public void Update(AlertEvent alertEvent)
        {
            Console.WriteLine(
                $"[EMAIL] {alertEvent.SensorName}: " +
                $"{alertEvent.Severity} - " +
                $"{alertEvent.Value:F1} {alertEvent.Unit}");
        }
    }
}