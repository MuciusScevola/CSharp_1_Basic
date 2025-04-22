namespace Theme03_Task06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Вводится число. Вывести «Да», если оно четное, и «Нет» в противном случае.
            int number;
            Console.Write("Введите число: ");
            number = Convert.ToInt32(Console.ReadLine());
            var evenOdd = (number % 2 == 0) ? $"Да - число \"{number}\" четное." : $"Нет - число \"{number}\" нечетное.";
            Console.WriteLine(evenOdd);

            Console.WriteLine("\nНажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
