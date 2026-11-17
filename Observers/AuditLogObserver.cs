/****************/
//Mã sinh viên  : 202419021 
//Họ tên  : Phạm Đình Vũ
/****************/
using lab_11.Models;
using lab_11.Interfaces;


namespace lab_11.Observers
{
    public sealed class AuditLogObserver : IAlertObserver
    {
        public void Update(AlertEvent alertEvent)
        {
            Console.WriteLine(
                $"[AUDIT] {alertEvent.OccurredAt:yyyy-MM-dd HH:mm:ss} | " +
                $"{alertEvent.SensorName} | " +
                $"{alertEvent.Value:F1} {alertEvent.Unit} | " +
                $"{alertEvent.Severity}");
        }
    }
}