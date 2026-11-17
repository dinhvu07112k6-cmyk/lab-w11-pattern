/****************/
//Mã sinh viên  : 202419021 
//Họ tên  : Phạm Đình Vũ
/****************/
namespace lab_11.Models
{
    public sealed record AlertEvent(
        string SensorName,
        double Value,
        string Unit,
        string Severity,
        DateTime OccurredAt);
}