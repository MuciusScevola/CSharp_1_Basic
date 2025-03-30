namespace Theme04_Task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Вводится натуральное число n. Найти 1 + 1/2 + 1/3 + … + 1/n
            Console.Write("Введите натуральное число number (numner >= 1): ");
            int number = Convert.ToInt32(Console.ReadLine());

            double sum = 0.0;

            for (int i = 1; i <= number; i++)
            {
                sum += 1.0 / i;
            }
            Console.WriteLine($"Сумма ряда до 1/{number} = {sum}");

            Console.WriteLine("Нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
