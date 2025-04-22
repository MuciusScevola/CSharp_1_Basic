
namespace Theme03_Task05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Вводится число. Вывести «Да», если оно оканчивается на 0, и «Нет» в противном случае.
            int number;
            Console.Write("Введите число: ");
            number = Convert.ToInt32(Console.ReadLine());
            var zero = (number % 10 == 0) ? $"Да - число \"{number}\" окончивается на 0." : $"Нет - число \"{number}\" не оканчивается на 0.";
            Console.WriteLine($"{zero}");

            Console.WriteLine("\nНажмите любую клавишу.");
            Console.ReadKey();

        }
    }
}
