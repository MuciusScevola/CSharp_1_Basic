using System;

// Базовый класс Building
public class Building
{
    protected string _address;
    protected double _area;
    protected int _yearBuilt;

    public Building(string address, double area, int yearBuilt)
    {
        _address = address;
        _area = area;
        _yearBuilt = yearBuilt;
    }

    // Виртуальный метод для расчета налога
    public virtual double CalculateTax()
    {
        return _area * 1000;
    }

    // Виртуальный метод для вывода информации
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Адрес: {_address}");
        Console.WriteLine($"Площадь: {_area} кв.м");
        Console.WriteLine($"Год постройки: {_yearBuilt}");
        Console.WriteLine($"Возраст здания: {BuildingAge} лет");
        Console.WriteLine($"Налог на здание: {CalculateTax():C}");
    }

    // Свойство только для чтения - возраст здания
    public int BuildingAge
    {
        get { return DateTime.Now.Year - _yearBuilt; }
    }
}

// Производный класс MultiBuilding (запечатанный - запрещено наследование)
public sealed class MultiBuilding : Building
{
    private int _floors;
    private bool _hasElevator;

    public MultiBuilding(string address, double area, int yearBuilt, int floors, bool hasElevator)
        : base(address, area, yearBuilt)
    {
        _floors = floors;
        _hasElevator = hasElevator;
    }

    // Переопределенный метод расчета налога
    public override double CalculateTax()
    {
        double baseTax = base.CalculateTax();
        double floorsCoefficient = 1 + (_floors - 1) * 0.05;
        double elevatorFee = _hasElevator ? 5000 : 0;

        return baseTax * floorsCoefficient + elevatorFee;
    }

    // Переопределенный метод вывода информации
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Количество этажей: {_floors}");
        Console.WriteLine($"Наличие лифта: {(_hasElevator ? "Да" : "Нет")}");
        Console.WriteLine($"Средняя площадь на этаж: {AreaPerFloor:F2} кв.м");
    }

    // Новое свойство только для чтения - средняя площадь на этаж
    public double AreaPerFloor
    {
        get { return _area / _floors; }
    }
}

class Program
{
    static void Main()
    {
        // Демонстрация работы классов

        // 1. Создание объектов обоих типов
        Building house = new Building("ул. Ленина, 10", 120.5, 1995);
        MultiBuilding skyscraper = new MultiBuilding("ул. Гагарина, 42", 25000, 2010, 50, true);

        Console.WriteLine("Информация о здании:");
        house.DisplayInfo();

        Console.WriteLine("\nИнформация о многоэтажном здании:");
        skyscraper.DisplayInfo();

        // 2. Upcasting - приведение производного класса к базовому
        Building building = skyscraper;
        Console.WriteLine("\nUpcasting - информация через базовый класс:");
        building.DisplayInfo(); // Вызовется переопределенный метод MultiBuilding

        // 3. Downcasting - обратное приведение с проверкой типа
        if (building is MultiBuilding)
        {
            MultiBuilding multiBuilding = (MultiBuilding)building;
            Console.WriteLine("\nDowncasting успешен:");
            Console.WriteLine($"Площадь на этаж: {multiBuilding.AreaPerFloor:F2} кв.м");

            // Вызов уникального метода производного класса
            Console.WriteLine($"Налог с учетом всех коэффициентов: {multiBuilding.CalculateTax():C}");
        }

        // 4. Попытка downcasting для объекта, который не является MultiBuilding
        if (house is MultiBuilding)
        {
            Console.WriteLine("Этот код не выполнится");
        }
        else
        {
            Console.WriteLine("\nhouse не является MultiBuilding - downcasting невозможен");
        }

        Console.WriteLine("Нажмите любую клавишу.");
        Console.ReadKey();
    }
}