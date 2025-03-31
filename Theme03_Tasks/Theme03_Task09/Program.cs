using System.Text;

namespace Theme03_Task09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Вводится число. Вывести «Да», если оно попадает в диапазон(-∞; -10]Ս[10; +∞), и «Нет» в противном случае.
            Console.OutputEncoding = Encoding.Unicode;

            double number;
            number = Convert.ToDouble(Console.ReadLine());

            if (number <= -10 || number >= 10)
            {
                Console.WriteLine($"Да - число \"{number}\" попадает в диапазон (-∞; -10]Ս[10; +∞).");
            }
            else
            {
                Console.WriteLine($"Нет - число \"{number}\" не попадает в диапазон (-∞; -10]Ս[10; +∞).");
            }

            Console.WriteLine("Нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
