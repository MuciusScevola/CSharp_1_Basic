namespace Theme03_Task06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            number = Convert.ToInt32(Console.ReadLine());
            var evenOdd = (number % 2 == 0) ? "Да - число \"{number}\" четное." : "Нет - число \"{number}\" нечетное.";
            Console.WriteLine(evenOdd);

            Console.WriteLine("Нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
