// Реализуйте систему управления умным домом на C# с использованием событий.
// Система должна отслеживать изменения состояния устройств и уведомлять пользователя о важных событиях.
// 1. Класс SmartHomeSystem
// Должен содержать:
//  Список подключенных устройств(например, свет, термостат, дверные датчики)
//  Методы для управления устройствами:
//   TurnOnLight() / TurnOffLight()
//   SetTemperature(int newTemp)
//   LockDoor() / UnlockDoor()
//  Событие DeviceStateChanged, срабатывающее при изменении состояния любого устройства.
// 2. Событие DeviceStateChanged
// Должно передавать:
//   Тип устройства("Light", "Thermostat", "Door")
//   Новое состояние(например, "On", "Off", "Locked", "Temperature set to 25°C")
//   Время изменения.
// 3. Подписка на события в Main


namespace Theme13_Task01
{
    // Отслеживание состояния устройств.
    public class DeviceStateInfo
    {
        public string DeviceType { get; }
        public string StateChange { get; }
        public DateTime TimeChange { get; }

        public DeviceStateInfo(string deviceType, string stateChange, DateTime timeChange)
        {
            DeviceType = deviceType;
            StateChange = stateChange;
            TimeChange = timeChange;
        }
    }

    // Система умного дома.
    public class SmarthomeSystem
    {
        public event Action<DeviceStateInfo> DeviceStateChanged; // Событие для уведомления.
        
        private bool _isLightOn = false;
        private int _currentTemperature = 10;
        private bool _isDoorOpen = false;

        // Управление освещением.
        public void TurnOnLight()
        {
            if (!_isLightOn)
            {
                _isLightOn = true;
                OnDeviceStateChanged("Light", "On");
            }
        }

        public void TurnOffLight()
        {
            if (_isLightOn)
            {
                _isLightOn = false;
                OnDeviceStateChanged("Light", "Off");
            }
        }

        // Управление термостатом.
        public void SetTemperature(int newTemp)
        {
            if (_currentTemperature != newTemp)
            {
                _currentTemperature = newTemp;
                OnDeviceStateChanged("Thermostat", $"Temperture set to {newTemp}°C");
            }
        }
        // Управление дверью.
        public void LockDoor()
        {
            if (_isDoorOpen)
            {
                _isDoorOpen = false;
                OnDeviceStateChanged("Door", "Locked");
            }
        }

        public void UnlockDoor()
        {
            if (!_isDoorOpen)
            {
                _isDoorOpen = true;
                OnDeviceStateChanged("Door", "Unlocked");
            }
        }

        // Метод для вызова события
        protected virtual void OnDeviceStateChanged(string deviceType, string newState)
        {
            DeviceStateChanged?.Invoke(new DeviceStateInfo(deviceType, newState, DateTime.Now));
        }
    }

    class Program
    {
        static void Main()
        {
            var smartHome = new SmarthomeSystem();

            smartHome.DeviceStateChanged += (info) =>
            {
                Console.WriteLine($"[{info.TimeChange.ToString("HH:mm:ss")}] {info.DeviceType}: {info.StateChange}");
            };

            smartHome.SetTemperature(20);
            smartHome.UnlockDoor();
            smartHome.TurnOnLight();
            smartHome.TurnOffLight();
            smartHome.LockDoor();

            Console.WriteLine("\nНажмите люую клавишу.");
            Console.ReadKey();
        }
    }
}