namespace Theme03_Task08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Вводится число. Вывести «Да», если оно попадает в диапазон [-10,10], и «Нет» в противном случае.
            double number;
            Console.Write("Введите число: ");
            number = Convert.ToDouble(Console.ReadLine());

            if (number < -10 || number > 10)
            {
                Console.WriteLine($"Нет - число \"{number}\" не попадает в диапазон [-10, 10].");
            }
            else
            {
                Console.WriteLine($"Да - число \"{number}\" попадает в диапазон [-10, 10].");
            }

            Console.WriteLine("\nНажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
