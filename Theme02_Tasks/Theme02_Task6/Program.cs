namespace Theme02_Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double length;
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Введенное значение длины: {length}");
            

            Console.WriteLine($"Округлённое значение длины: {Math.Ceiling(length)}");

            Console.WriteLine("Нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
