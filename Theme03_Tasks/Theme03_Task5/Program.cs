using System.Threading.Channels;

namespace Theme03_Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            number = Convert.ToInt32(Console.ReadLine());
            var zero = (number % 10 == 0) ? "Да - число окончивается на 0" : "Нет - число не оканчивается на 0";
            Console.WriteLine($"{zero}");

            Console.WriteLine("Нажмите любую клавишу.");
            Console.ReadKey();

        }
    }
}
