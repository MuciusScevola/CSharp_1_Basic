namespace Theme07_Task05
{
    internal class Program
    {
        static void Main()
        {
            /* Напишите перегруженные методы Multiply,
             * которые могут умножать два числа (целые или дробные) и возвращать результат.
            */
            Console.WriteLine("Введите первое целое число: ");
            int a1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе целое число: ");
            int b1 = Convert.ToInt32(Console.ReadLine());

            var result1 = Multiply(a1, b1);
            Console.WriteLine($"{a1} + {b1} = {result1}");

            Console.WriteLine("Введите первое вещественное число: ");
            double a2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите второе вещественное число: ");
            double b2 = Convert.ToDouble(Console.ReadLine());

            var result2 = Multiply(a2, b2);
            Console.WriteLine($"{a1} + {b1} = {result2}");
        }
        static int Multiply(int a, int b)
        {
            return a * b;
        }
        static double Multiply(double a, double b)
        {
            return a * b;
        }
    }
}
