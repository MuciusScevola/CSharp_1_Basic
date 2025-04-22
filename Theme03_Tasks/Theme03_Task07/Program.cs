namespace Theme03_Task07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Вводится число. Вывести «Да», если оно двухзначное, и «Нет» в противном случае.
            int number;
            Console.Write("Введите число: ");
            number = Convert.ToInt32(Console.ReadLine());

            if (Math.Abs(number) > 9 && Math.Abs(number) < 100)
            {
                Console.WriteLine($"Да - число \"{number}\" двухзначное.");
            }
            else
            {
                Console.WriteLine($"Нет - число \"{number}\" не двухзначное.");
            }

            Console.WriteLine("\nНажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
