namespace Theme04_Task06
{
    internal class Program
    {
        static void Main()
        {
            // Вводится n. Определить, является ли оно степенью 2-ки
            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int numInput = number; // Чтобы вывести введенное число.
            while (number % 2 == 0) // Пока число четное.
            {
                number /= 2; // Делим его на 2.
            }

            string isPowerOfTwo = number == 1 ? $"Введенное число {numInput} является степенью двойки" : $"Введенное число {numInput} не является степенью двойки";

            Console.WriteLine(isPowerOfTwo);

            Console.WriteLine("Нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
