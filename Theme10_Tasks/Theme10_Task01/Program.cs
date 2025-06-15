using System;
using System.Text; 

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

    public int BuildingAge
    {
        get { return DateTime.Now.Year - _yearBuilt; }
    }

    public virtual double CalculateTax()
    {
        return _area * 1000;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Адрес: {_address}.");
        Console.WriteLine($"Площадь: {_area} кв.м.");
        Console.WriteLine($"Год постройки: {_yearBuilt}.");
        Console.WriteLine($"Возраст здания: {BuildingAge} лет.");
        Console.WriteLine($"Налог на здание: {CalculateTax():C}.");
    }
    
}

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

    public override double CalculateTax()
    {
        double baseTax = base.CalculateTax();
        double floorsCoefficient = 1 + (_floors - 1) * 0.05;
        double elevatorFee = _hasElevator ? 5000 : 0;

        return baseTax * floorsCoefficient + elevatorFee;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Количество этажей: {_floors}.");
        Console.WriteLine($"Наличие лифта: {(_hasElevator ? "Да" : "Нет")}.");
        Console.WriteLine($"Средняя площадь на этаж: {AreaPerFloor:F2} кв.м.");
    }

    public double AreaPerFloor
    {
        get { return _area / _floors; }
    }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        // 1. Создание объектов обоих типов.
        Building house = new Building("пр. Ленина, 100", 450, 1965);
        MultiBuilding highHouse = new MultiBuilding("ул. Папанина, 30", 27790, 2023, 35, true);

        Console.WriteLine("Информация о здании:");
        house.DisplayInfo();

        Console.WriteLine("\nИнформация о многоэтажном здании:");
        highHouse.DisplayInfo();

        // 2. Upcasting - приведение производного класса к базовому.
        Building building = highHouse;
        Console.WriteLine("\nUpcasting - информация через базовый класс:");
        building.DisplayInfo(); // Вызовется переопределенный метод MultiBuilding.

        // 3. Downcasting - обратное приведение с проверкой типа.
        if (building is MultiBuilding)
        {
            MultiBuilding multiBuilding = (MultiBuilding)building;
            Console.WriteLine("\nDowncasting успешен:");
            Console.WriteLine($"Площадь на этаж: {multiBuilding.AreaPerFloor:F2} кв.м.");

            // Вызов уникального метода производного класса.
            Console.WriteLine($"Налог с учетом всех коэффициентов: {multiBuilding.CalculateTax():C}.");
        }

        // 4. Попытка downcasting для объекта, который не является MultiBuilding.
        if (house is MultiBuilding)
            Console.WriteLine("Этот код не выполнится.");
        else
            Console.WriteLine("\nhouse не является MultiBuilding - downcasting невозможен.");

        Console.WriteLine("\nНажмите любую клавишу.");
        Console.ReadKey();
    }
}