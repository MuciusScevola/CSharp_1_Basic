using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Theme04_Task03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Вводятся целые числа a>0, b>0. Найти a^b. Не использовать класс Math
            Console.Write("Введите целое число a (a > 0): ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите целое число b (b > 0): ");
            int b = Convert.ToInt32(Console.ReadLine());

            long result = 1;
            for (int i = 1; i <= b; i++)
            {
                result *= a;
            }

            Console.WriteLine($"Результат {a}^{b} (при b > ) = {result}");

            Console.WriteLine("Нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
