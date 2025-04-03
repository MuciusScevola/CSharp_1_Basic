namespace Theme07_Task01
{
    internal class Program
    {
        static void Main()
        {
            /* Два треугольника заданы длинами своих сторон.
             * Определите, площадь какого из них больше
             * (создайте метод Square для вычисления площади треугольника по длинам его сторон).
            */
            Console.Write("Введите длины сторон первого треугольника через пробел a1, b1, c1: ");
            string[] edgesFrt = Console.ReadLine().Split(); // Ввод значений одной строкой через пробелы.
           
            double a1 = double.Parse(edgesFrt[0]);
            double b1 = double.Parse(edgesFrt[1]);
            double c1 = double.Parse(edgesFrt[2]);
            
            Console.Write("Введите длины сторон второго треугольника через пробел a2, b2, c2: ");
            string[] edgesSnd = Console.ReadLine().Split();
            
            double a2 = double.Parse(edgesSnd[0]);
            double b2 = double.Parse(edgesSnd[1]);
            double c2 = double.Parse(edgesSnd[2]);

            double square1 = Square(a1, b1, c1);
            double square2 = Square(a2, b2, c2);

            if (square1 == 0 || square2 == 0)
            {
                Console.WriteLine("Треугольник с такими сторонами не существует. Введите корректные значения.");
            }
            else if (square1 > square2)
            {
                Console.WriteLine("Площадь первого треугольника больше.");
            }
            else if (square2 > square1)
            {
                Console.WriteLine("Площадь второго треугольника больше.");
            }
            else if (square1 == square2)
            {
                Console.WriteLine("Площади треугольников равны.");
            }

            Console.WriteLine("Нажмите любую клавишу.");
            Console.ReadKey();
        }
        static double Square(double a, double b, double c)
        {
            // Проверка на существование треугольника
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                return 0;
            }
            else
            {
                double p = (a + b + c) / 2; // Полупериметр.
                double square = Math.Sqrt(p * (p - a) * (p - b) * (p - c)); // Площадь треугольника по формуле Герона.
                return square;
            }
        }
    }
}

