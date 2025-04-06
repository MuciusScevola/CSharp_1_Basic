namespace Theme07_Task03
{
    internal class Program
    {
        static void Main()
        {
            /* Напишите метод PrintNumbers, который выводит на экран числа из массива. 
             * У метода должен быть необязательный параметр reverse,
             * который по умолчанию равен false. Если reverse равен true, числа выводятся в обратном порядке.
            */
            /* Console.WriteLine("Введите целые числа через пробел: ");
            string[] inArray = Console.ReadLine().Split();
            int[] numbers = Array.ConvertAll(inArray, int.Parse);
            */
            int[] numbers = { 1, 2, 3, 4, 5 }; // Тестовый массив.

            Console.WriteLine($"Исходный массив: ");
            PrintNumbers(numbers);
            Console.WriteLine($"\nПеревернутый массив: ");
            PrintNumbers(numbers, true);

            Console.WriteLine("\nНажмите любую клавишу.");
            Console.ReadKey();
        }

        static void PrintNumbers(int[] numbers, bool reverse = false)
        {
            // Реверс массива.
            /* if (reverse)
            {
                Array.Reverse(numbers);
            }
            Console.WriteLine(string.Join(" ", numbers));*/
            // Ввыод массива в обратном порядке.
            if (reverse)
            {
                for (int i = numbers.Length - 1; i >= 0; i--)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
            else
            {
                foreach (int number in numbers)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}

