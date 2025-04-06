namespace Theme07_Task02
{
    internal class Program
    {
        static void Main()
        {
            /* Создайте метод CalcCube для вычисления объема и площади поверхности куба по длине его ребра.
             * Метод должен иметь 3 параметра - длина ребра, out-параметр для объема
             * и out-параметр для площади поверхности.
            */
            Console.Write("Введите длину ребра: ");
            double edgeLength = Convert.ToDouble(Console.ReadLine());

            CalcCube(edgeLength, out double volume, out double square);
            Console.WriteLine($"Площадь поверхности куба: {square}.");
            Console.WriteLine($"Объем куба: {volume}.");

            Console.WriteLine("Нажмите любую клавишу.");
            Console.ReadKey();
        }

        static void CalcCube(double a, out double volume, out double square)
        {
            volume = Math.Pow(a, 3);
            square = 6 * Math.Pow(a, 2);
        }
    }
    }
