/****************/
//Mã sinh viên  : 202419021 
//Họ tên  : Phạm Đình Vũ
/****************/

using lab_11.Devices;
using lab_11.Interfaces;
using lab_11.Models;

namespace lab_11.Mediators
{
    public sealed class EmergencyMediator : IEmergencyMediator
    {
        private readonly Alarm alarm;
        private readonly DoorController door;
        private readonly VentilationController ventilation;

        public EmergencyMediator(
            Alarm alarm,
            DoorController door,
            VentilationController ventilation)
        {
            this.alarm = alarm;
            this.door = door;
            this.ventilation = ventilation;
        }

        public void HandleEmergency(AlertEvent alertEvent)
        {
            Console.WriteLine(
                $"[EMERGENCY] {alertEvent.SensorName}: " +
                $"{alertEvent.Severity}");

            alarm.Activate();
            door.Unlock();
            ventilation.TurnOn();
        }
    }
}