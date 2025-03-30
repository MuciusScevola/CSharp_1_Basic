namespace Theme04_Task08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Вводится число. Вывести его в зеркальном виде. Количество цифр в числе заранее неизвестно
            int number;
            Console.Write("Введите число: ");
            number = Convert.ToInt32(Console.ReadLine());

            int numMirror = 0;

            while (number != 0)
            {
                int digit = number % 10;
                numMirror = numMirror * 10 + digit;
                number /= 10;
            }

            Console.WriteLine($"Отзеркаленное число = {numMirror}.");

            Console.WriteLine("Нажмите любую клавишу.");
            Console.ReadKey();

        }
    }
}
