/****************/
//Mã sinh viên  : 202419021 
//Họ tên  : Phạm Đình Vũ
/****************/
using lab_11.Models;
using lab_11.Interfaces;


namespace lab_11.Observers
{
    public sealed class DashboardObserver : IAlertObserver
    {
        public void Update(AlertEvent alertEvent)
        {
            Console.WriteLine(
                $"[DASHBOARD] {alertEvent.SensorName}: " +
                $"{alertEvent.Value:F1} {alertEvent.Unit} " +
                $"[{alertEvent.Severity}]");
        }
    }
}