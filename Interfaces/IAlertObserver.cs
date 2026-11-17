/****************/
//Mã sinh viên  : 202419021 
//Họ tên  : Phạm Đình Vũ
/****************/
using lab_11.Models;

namespace lab_11.Interfaces
{
    public interface IAlertObserver
    {
        void Update(AlertEvent alertEvent);
    }
}