namespace Theme03_Task08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number;
            number = Convert.ToDouble(Console.ReadLine());

            if (number < -10 || number > 10)
            {
                Console.WriteLine($"Нет - число \"{number}\" не попадает в диапазон [-10, 10].");
            }
            else
            {
                Console.WriteLine($"Да - число \"{number}\" попадает в диапазон [-10, 10].");
            }

            Console.WriteLine("Нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
