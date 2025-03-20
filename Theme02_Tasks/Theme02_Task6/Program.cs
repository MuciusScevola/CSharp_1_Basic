namespace Theme02_Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double length;
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Введенное значение длины: {length}");

            double lengthRound = (Math.Round(length / 0.5)) * 0.5;
            Console.WriteLine($"Округлённое значение длины: {lengthRound}");

            /*
             var inputs = new[] { 17.01, 17.099, 17.1, 17.2, 17.24, 17.25, 17.26, 17.3, 17.5, 17.51, 17.6, 17.74, 17.75, 17.76, 17.9, 18}; // Массив тестовых значений. Значения "0.25" и "0.75", получаются, граничные.
            foreach (var value in inputs)
            {
                Console.WriteLine($"{value} => {Math.Round(value * 2) / 2}");
            }
            */
            Console.WriteLine("Нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
