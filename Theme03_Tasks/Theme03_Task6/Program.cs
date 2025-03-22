namespace Theme03_Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            number = Convert.ToInt32(Console.ReadLine());
            var evenOdd = (number % 2 == 0) ? "Да - число четное" : "Нет - число нечетное";
            Console.WriteLine(evenOdd);

            Console.WriteLine("Нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
