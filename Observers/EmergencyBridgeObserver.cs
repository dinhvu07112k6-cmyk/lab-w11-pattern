/****************/
//Mã sinh viên  : 202419021 
//Họ tên  : Phạm Đình Vũ
/****************/
using lab_11.Interfaces;
using lab_11.Models;

namespace lab_11.Observers
{
    public sealed class EmergencyBridgeObserver : IAlertObserver
    {
        private readonly IEmergencyMediator mediator;

        public EmergencyBridgeObserver(IEmergencyMediator mediator)
        {
            this.mediator = mediator ??
                throw new ArgumentNullException(nameof(mediator));
        }

        public void Update(AlertEvent alertEvent)
        {
            if (alertEvent.Severity == "CRITICAL")
            {
                mediator.HandleEmergency(alertEvent);
            }
        }
    }
}