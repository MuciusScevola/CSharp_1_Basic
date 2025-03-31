namespace Theme07_Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Два треугольника заданы длинами своих сторон.
             * Определите, площадь какого из них больше
             * (создайте метод Square для вычисления площади треугольника по длинам его сторон).
            */
            double a1 = Convert.ToDouble(Console.ReadLine());
            double b1 = Convert.ToDouble(Console.ReadLine());
            double c1 = Convert.ToDouble(Console.ReadLine());
            double a2 = Convert.ToDouble(Console.ReadLine());
            double b2 = Convert.ToDouble(Console.ReadLine());
            double c2 = Convert.ToDouble(Console.ReadLine());
            double square1 = Square(a1, b1, c1);
            double square2 = Square(a2, b2, c2);

            Console.WriteLine();


            Console.WriteLine();

            Console.WriteLine("Нажмите любую клавишу.");
            Console.ReadKey();
        }
        static double Square(double a, double b, double c)
        {
            double p = (a + b + c) / 2; // Полупериметр 
            double square = Math.Sqrt(p * (p - a) * (p - b) * (p - c)); // Площадь треугольника по формуле Герона
            return square;
        }
    }
}

