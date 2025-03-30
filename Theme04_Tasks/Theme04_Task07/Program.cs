namespace Theme04_Task07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Вводится n. Определить количество цифр в числе
            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int numInput = number;

            int count = 0;

            while (number % 10 > 0) {
                number /= 10;
                count++;
            }

            Console.WriteLine($"Количество цифр в числе {numInput}: {count}");

            Console.WriteLine("Нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
