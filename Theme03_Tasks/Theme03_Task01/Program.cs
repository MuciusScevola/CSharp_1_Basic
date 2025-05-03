namespace Theme03_Task01
{
    internal class Program
    {
        static void Main()
        {
            // Вводятся два числа. Сравнить их и вывести правильный знак «<», «>» или «=».
            int a, b;
            Console.WriteLine("Введите первое число:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
                Console.WriteLine($"{a} > {b}");
            else if (a < b)
                Console.WriteLine($"{a} < {b}");
            else if (a == b)
                Console.WriteLine($"{a} = {b}");

            // Все условия в одном тернарном операторе.
            // Console.WriteLine((a > b) ? $"{a} > {b}." : (a < b) ? $"{a} < {b}." : $"{a} = {b}.");

            Console.WriteLine("\nНажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
