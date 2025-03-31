namespace Theme04_Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Вводится натуральное число n. Найти n!
            Console.Write("Введите натуральное число number (number >= 1): ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 20)
            {
                Console.WriteLine("Вычислить факториал не получится. Введите число до 20.");
            }
            else
            {
                long factorial = 1;
                for (int i = 1; i <= number; i++)
                {
                    factorial *= i;
                }
                Console.WriteLine($"Факториал {number}! = {factorial}");
            }
            Console.WriteLine("Нажмите любую клавишу.");
            Console.ReadKey();
        }

    }
}