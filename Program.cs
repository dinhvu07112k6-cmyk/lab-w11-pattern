using lab_11.Interfaces;            
using lab_11.Sensors;   

LegacySmokeDetector legacy = new LegacySmokeDetector(735);
ISensor sensor = new SmokeSensorAdapter(legacy);

Console.WriteLine(sensor.ReadValue()); // 73.5
Console.WriteLine(sensor.GetUnit());   // % smoke

legacy.SetSmokeLevel(500);
Console.WriteLine(sensor.ReadValue()); // 50