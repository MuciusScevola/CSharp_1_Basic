namespace Theme03_Task04
{
    internal class Program
    {
        static void Main()
        {
            // Вводятся три разных числа. Вывести медиану – промежуточное по величине число.
            double a, b, c;
            Console.WriteLine("Введите первое число:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите третье число:");
            c = Convert.ToDouble(Console.ReadLine());

            var maxNmr = Math.Max(a, Math.Max(b, c));
            var minNmr = Math.Min(a, Math.Min(b, c));
            if (a != maxNmr && a != minNmr)
                Console.WriteLine($"Медиана = {a}");
            else if (b != maxNmr && b != minNmr)
                Console.WriteLine($"Медиана = {a}");
            else
                Console.WriteLine($"Медиана = {c}");

            // Другая идея решения заключается в том, чтобы отсортировать числа a, b, c по возрастанию и взять b
            //if (a > b)
            //{
            //    int t = a;
            //    a = b;
            //    b = t;
            //}
            //if (a > c)
            //{
            //    int t = a;
            //    a = c;
            //    c = t;
            //}
            //if (b > c)
            //{
            //    int t = b;
            //    b = c;
            //    c = t;
            //}
            //Console.WriteLine(b);

            Console.WriteLine("\nНажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
