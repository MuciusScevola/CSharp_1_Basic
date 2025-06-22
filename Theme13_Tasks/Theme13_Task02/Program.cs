namespace Theme13_Task01
{
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
    //
    // Пример лога при работе программы:
    // [14:30:00] Light: Включен
    // [14:31:15] Thermostat: Температура изменена на 23°C
    // [14:35:40] Door: Заблокирована


    // Класс для хранения информации о событии изменения состояния устройства
    public class DeviceStateInfo
    {
        public string DeviceType { get; }
        public string NewState { get; }
        public DateTime ChangeTime { get; }

        public DeviceStateInfo(string deviceType, string newState, DateTime changeTime)
        {
            DeviceType = deviceType;
            NewState = newState;
            ChangeTime = changeTime;
        }
    }

    // Класс умного дома
    public class SmartHomeSystem
    {
        // Состояния устройств
        private bool isLightOn = false;
        private int currentTemperature = 20;
        private bool isDoorLocked = true;

        // Делегат для события изменения состояния
        public delegate void DeviceStateChangedHandler(DeviceStateInfo info);

        // Событие изменения состояния устройства
        public event DeviceStateChangedHandler DeviceStateChanged;

        // Методы управления устройствами

        public void TurnOnLight()
        {
            isLightOn = true;
            OnDeviceStateChanged("Light", "Включен");
        }

        public void TurnOffLight()
        {
            isLightOn = false;
            OnDeviceStateChanged("Light", "Выключен");
        }

        public void SetTemperature(int newTemp)
        {
            currentTemperature = newTemp;
            OnDeviceStateChanged("Thermostat", $"Температура изменена на {newTemp}°C");
        }

        public void LockDoor()
        {
            isDoorLocked = true;
            OnDeviceStateChanged("Door", "Заблокирована");
        }

        public void UnlockDoor()
        {
            isDoorLocked = false;
            OnDeviceStateChanged("Door", "Разблокирована");
        }

        // Метод для вызова события
        protected virtual void OnDeviceStateChanged(string deviceType, string newState)
        {
            DeviceStateChanged?.Invoke(new DeviceStateInfo(deviceType, newState, DateTime.Now));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Создаем систему умного дома
            var smartHome = new SmartHomeSystem();

            // Подписываемся на событие изменения состояния
            smartHome.DeviceStateChanged += (info) =>
            {
                Console.WriteLine($"[{info.ChangeTime.ToString("HH:mm:ss")}] {info.DeviceType}: {info.NewState}");
            };

            // Тестируем работу системы
            smartHome.TurnOnLight();
            System.Threading.Thread.Sleep(1000); // Имитация задержки между событиями

            smartHome.SetTemperature(23);
            System.Threading.Thread.Sleep(1000);

            smartHome.LockDoor();

            Console.WriteLine("\nНажмите люую клавишу.");
            Console.ReadKey();
        }
    }
}