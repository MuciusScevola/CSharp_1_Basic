namespace Theme2_Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            number = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine($"Исходное число: {number}");

            int digit1 = number / 1000;
            int digit2 = (number / 100) % 10;
            int digit3 = (number / 10) % 10;
            int digit4 = number % 10;
            int numberTrans = digit1 * 1000 + digit4 * 100 + digit3 * 10 + digit2;

            Console.WriteLine($"Полученное после перемены число: {digit1}{digit4}{digit3}{digit2}"); // Вывод трансчисла без математических операций.
            /*Console.WriteLine($"Полученное после перемены число: {numberTrans}");*/  // Вывод трансчисла с помощью математических операций.

            Console.WriteLine("Нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
