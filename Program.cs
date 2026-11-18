/****************/
//Mã sinh viên  : 202419021 
//Họ tên  : Phạm Đình Vũ
/****************/
using lab_11.Devices;
using lab_11.Interfaces;
using lab_11.Mediators;
using lab_11.Observers;
using lab_11.Sensors;

LegacySmokeDetector legacy = new LegacySmokeDetector(400);
SmokeSensorAdapter sensor = new SmokeSensorAdapter(legacy);

SensorMonitor monitor = new SensorMonitor();
DashboardObserver dashboard = new DashboardObserver();

monitor.Attach(dashboard);
monitor.Attach(dashboard); // Đăng ký trùng phải bị bỏ qua

IEmergencyMediator mediator = new EmergencyMediator(
    new Alarm(),
    new DoorController(),
    new VentilationController());

monitor.Attach(new EmergencyBridgeObserver(mediator)); 

monitor.Attach(new EmailAlertObserver());
monitor.Attach(new AuditLogObserver());
monitor.CheckSensor("Room A", sensor); // 40%: không cảnh báo

legacy.SetSmokeLevel(500);
monitor.CheckSensor("Room A", sensor); // 50%: WARNING

legacy.SetSmokeLevel(735);
monitor.CheckSensor("Room A", sensor); // 73.5%: CRITICAL

monitor.Detach(dashboard);
monitor.CheckSensor("Room A", sensor); // Đã gỡ: không còn nhận

