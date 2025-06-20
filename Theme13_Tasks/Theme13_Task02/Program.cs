using System;
using System.Collections.Generic;

namespace Theme13_Task02;

// Класс для хранения информации о событии изменения состояния устройства
public class DeviceStateChangedEventArgs : EventArgs
{
    public string DeviceType { get; } // Тип устройства ("Light", "Thermostat", "Door")
    public string NewState { get; }   // Новое состояние устройства
    public DateTime ChangeTime { get; } // Время изменения

    public DeviceStateChangedEventArgs(string deviceType, string newState)
    {
        DeviceType = deviceType;
        NewState = newState;
        ChangeTime = DateTime.Now;
    }
}

// Базовый класс для всех устройств умного дома
public abstract class SmartDevice
{
    public event EventHandler<DeviceStateChangedEventArgs> StateChanged;

    protected string deviceType;

    protected virtual void OnStateChanged(string newState)
    {
        // Вызываем событие, уведомляя подписчиков об изменении состояния
        StateChanged?.Invoke(this, new DeviceStateChangedEventArgs(deviceType, newState));
    }
}

// Класс для управления светом
public class Light : SmartDevice
{
    private bool isOn;

    public Light()
    {
        deviceType = "Light";
        isOn = false; // По умолчанию свет выключен
    }

    public void TurnOn()
    {
        if (!isOn)
        {
            isOn = true;
            OnStateChanged("Включен");
        }
    }

    public void TurnOff()
    {
        if (isOn)
        {
            isOn = false;
            OnStateChanged("Выключен");
        }
    }

    public bool IsOn => isOn;
}

// Класс для управления термостатом
public class Thermostat : SmartDevice
{
    private int temperature;

    public Thermostat()
    {
        deviceType = "Thermostat";
        temperature = 20; // Начальная температура
    }

    public void SetTemperature(int newTemp)
    {
        if (newTemp != temperature)
        {
            temperature = newTemp;
            OnStateChanged($"Температура изменена на {newTemp}°C");
        }
    }

    public int Temperature => temperature;
}

// Класс для управления дверью
public class Door : SmartDevice
{
    private bool isLocked;

    public Door()
    {
        deviceType = "Door";
        isLocked = false; // По умолчанию дверь разблокирована
    }

    public void Lock()
    {
        if (!isLocked)
        {
            isLocked = true;
            OnStateChanged("Заблокирована");
        }
    }

    public void Unlock()
    {
        if (isLocked)
        {
            isLocked = false;
            OnStateChanged("Разблокирована");
        }
    }

    public bool IsLocked => isLocked;
}

// Основной класс системы умного дома
public class SmartHomeSystem
{
    private List<SmartDevice> devices = new List<SmartDevice>();
    private Light livingRoomLight;
    private Thermostat livingRoomThermostat;
    private Door frontDoor;

    public SmartHomeSystem()
    {
        // Инициализация устройств
        livingRoomLight = new Light();
        livingRoomThermostat = new Thermostat();
        frontDoor = new Door();

        // Добавление устройств в систему
        devices.Add(livingRoomLight);
        devices.Add(livingRoomThermostat);
        devices.Add(frontDoor);

        // Подписка на события всех устройств
        foreach (var device in devices)
        {
            device.StateChanged += OnDeviceStateChanged;
        }
    }

    // Методы управления светом
    public void TurnOnLight() => livingRoomLight.TurnOn();
    public void TurnOffLight() => livingRoomLight.TurnOff();
    public bool IsLightOn => livingRoomLight.IsOn;

    // Методы управления термостатом
    public void SetTemperature(int newTemp) => livingRoomThermostat.SetTemperature(newTemp);
    public int CurrentTemperature => livingRoomThermostat.Temperature;

    // Методы управления дверью
    public void LockDoor() => frontDoor.Lock();
    public void UnlockDoor() => frontDoor.Unlock();
    public bool IsDoorLocked => frontDoor.IsLocked;

    // Обработчик события изменения состояния устройства
    private void OnDeviceStateChanged(object sender, DeviceStateChangedEventArgs e)
    {
        // Форматируем сообщение для вывода в лог
        string logMessage = $"[{e.ChangeTime.ToString("HH:mm:ss")}] {e.DeviceType}: {e.NewState}";
        Console.WriteLine(logMessage);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Запуск системы умного дома...");

        // Создаем экземпляр системы умного дома
        var smartHome = new SmartHomeSystem();

        // Демонстрация работы системы
        smartHome.TurnOnLight();              // Включаем свет
        smartHome.SetTemperature(23);          // Устанавливаем температуру
        smartHome.LockDoor();                 // Блокируем дверь
        smartHome.TurnOffLight();              // Выключаем свет
        smartHome.UnlockDoor();               // Разблокируем дверь
        smartHome.SetTemperature(21);          // Меняем температуру

        Console.WriteLine("Демонстрация завершена.");
    }
}