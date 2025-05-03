namespace Theme03_Task02
{
    internal class Program
    {
        static void Main()
        {
            // Вводятся три числа. Вывести большее их них.
            int a, b, c;
            Console.WriteLine("Введите первое число:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье число:");
            c = Convert.ToInt32(Console.ReadLine());

            if (a >= b && a >= c)
                Console.WriteLine($"Максимум = {a}");
            else if (b >= a && b >= c)
                Console.WriteLine($"Максимум = {b}");
            else if (c >= a && c >= b)
                Console.WriteLine($"Максимум = {c}");
            else if (a >= b && b >= c)
                Console.WriteLine($"Максимум = {a}");
            else if (b >= a && c >= a)
                Console.WriteLine($"Максимум = {b}");
            else if (c >= a && a >= b)
                Console.WriteLine($"Максимум = {c}");

            // Чем больше будет чисел для сравнения, тем проще запутаться в условиях.
            // Поэтому было бы круто придумать более или менее универсальный алгоритм,
            // который бы легко было модифицировать для большего количества чисел.
            //int max = a;
            //if (b > max)
            //    max = b;
            //else if (c > max)
            //    max = c;

            Console.WriteLine("\nНажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
