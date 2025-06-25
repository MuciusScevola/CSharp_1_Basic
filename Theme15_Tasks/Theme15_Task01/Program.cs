// Модель компьютера характеризуется кодом и названием марки компьютера, типом процессора, частотой работы процессора,
//  объемом оперативной памяти, объемом жесткого диска, объемом памяти видеокарты,
//  стоимостью компьютера в условных единицах и количеством экземпляров, имеющихся в наличии.
// Создать список, содержащий 6-10 записей с различным набором значений характеристик.
// Определить:
//  - все компьютеры с указанным процессором. Название процессора запросить у пользователя;
//  - все компьютеры с объемом ОЗУ не ниже, чем указано. Объем ОЗУ запросить у пользователя;
//  - вывести весь список, отсортированный по увеличению стоимости;
//  - вывести весь список, сгруппированный по типу процессора;
//  - найти самый дорогой и самый бюджетный компьютер;
//  - есть ли хотя бы один компьютер в количестве не менее 30 штук?

using System;
using System.Linq;
using System.Text;
using Theme15_Task01;

namespace Theme15_Task01
{
    class Computer()
    {
        public string PC_Code { get; set; }
        public string PC_Mark { get; set; }
        public string CPU_Type { get; set; }
        public double CPU_Frequency { get; set; }
        public int RAM_Volume { get; set; }
        public int HDD_Volume { get; set; }
        public int GraphicCard_Volume { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public override string ToString()
        {
            return $" {PC_Code,-5} | {PC_Mark,-8} | {CPU_Type,10} | {CPU_Frequency,12} | {RAM_Volume,7} | {HDD_Volume,7} | {GraphicCard_Volume,9} | {Price,7} | {Quantity,6}";
        }
        public static string Header()
        {
            Console.WriteLine(" Код   | Марка    | Процессор  | Частота, ГГц | RAM, ГБ | HDD, ГБ | Видео, ГБ | Цена, ₽ | Кол-во");
            Console.WriteLine("-------|----------|------------|--------------|---------|---------|-----------|---------|-------");
        }

    }

}
internal class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        List<Computer> computers = new List<Computer>
        {
            new Computer
            {
                PC_Code = "PC001", PC_Mark = "Aurora", CPU_Type = "i5-12400", CPU_Frequency = 2.5, RAM_Volume = 16, HDD_Volume = 512, GraphicCard_Volume = 6, Price = 54999, Quantity = 15
            },
            new Computer
            {
                PC_Code = "PC002", PC_Mark = "Frost", CPU_Type = "Ryzen 5", CPU_Frequency = 3.6, RAM_Volume = 32, HDD_Volume = 1024, GraphicCard_Volume = 8, Price = 72999, Quantity = 20
            },
            new Computer
            {
                PC_Code = "PC003", PC_Mark = "Squall", CPU_Type = "i3-12100", CPU_Frequency = 3.3, RAM_Volume = 8, HDD_Volume = 256, GraphicCard_Volume = 4, Price = 42999, Quantity = 5
            },
            new Computer
            {
                PC_Code = "PC004", PC_Mark = "Fog", CPU_Type = "Ryzen 3", CPU_Frequency = 3.2, RAM_Volume = 8, HDD_Volume = 512, GraphicCard_Volume = 2, Price = 38999, Quantity = 7
            },
            new Computer
            {
                PC_Code = "PC005", PC_Mark = "Glaze", CPU_Type = "i7-12700", CPU_Frequency = 2.1, RAM_Volume = 64, HDD_Volume = 2048, GraphicCard_Volume = 12, Price = 104999, Quantity = 1
            },
            new Computer
            {
                PC_Code = "PC006", PC_Mark = "Dew", CPU_Type = "Ryzen 7", CPU_Frequency = 3.8, RAM_Volume = 32, HDD_Volume = 1024, GraphicCard_Volume = 16, Price = 87999, Quantity = 4
            },
            new Computer
            {
                PC_Code = "PC007", PC_Mark = "Gale", CPU_Type = "i9-12900", CPU_Frequency = 5.1, RAM_Volume = 128, HDD_Volume = 2048, GraphicCard_Volume = 24, Price = 149999, Quantity = 1
            },
            new Computer
            {
                PC_Code = "PC008", PC_Mark = "Hail", CPU_Type = "Ryzen 9", CPU_Frequency = 4.9, RAM_Volume = 64, HDD_Volume = 1024, GraphicCard_Volume = 12, Price = 119999, Quantity = 2
            }
        };


        Computer.Header();
        foreach (var comp in computers)
        {
            Console.WriteLine(comp.ToString());
        }

        // Поиск по указанному процессору.
        Console.Write("\nУкажите название процессора: ");
        string cpuQuery = Console.ReadLine();
        var cpuFiltered = computers
            .Where(c => c.CPU_Type.Contains(cpuQuery, StringComparison.OrdinalIgnoreCase))
            .ToList();
        Console.WriteLine($"\nКомпьютеры с процессором {cpuQuery}:");
        cpuFiltered
            .ForEach(Console.WriteLine);


        Console.WriteLine("\nНажмите любую клавишу.");
        Console.ReadKey();
    }
}