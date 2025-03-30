namespace Theme04_Task04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Вводятся целые числа a>0, b<0. Найти a^b. Не использовать класс Math
            Console.Write("Введите целое число a (a > 0): ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите целое число b (b < 0): ");
            int b = Convert.ToInt32(Console.ReadLine());

            double result = 1.0;
            for (int i = b; i < b; i++)
            {
                result *= 1.0 / a;
            }

            Console.WriteLine($"Результат {a}^({b}) (при b < 0) = {result}");

            Console.WriteLine("Нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
