namespace Theme07_Task04
{
    internal class Program
    {
        static void Main()
        {
            /* Напишите метод FindMax, который принимает переменное количество чисел 
             * и возвращает максимальное значение. Используйте ключевое слово params.
            */

            Console.WriteLine("Введите числа через пробел: ");
            string[] inArray = Console.ReadLine().Split();
            int[] numbers = Array.ConvertAll(inArray, int.Parse);

            int resultMax = FindMax(numbers);
            Console.WriteLine($"Максимальное число = {resultMax}");

            // Тестовые вызовы
            Console.WriteLine($"FindMax(1, 5, 3) → {FindMax(1, 5, 3)}");
            Console.WriteLine($"FindMax(-10, -5, -20) → {FindMax(-10, -5, -20)}");
            Console.WriteLine($"FindMax(7, 3, 9) → {FindMax(new int[] { 7, 3, 9 })}");
            
            Console.WriteLine("Нажмите любую клавишу.");
            Console.ReadKey();

        }
        static int FindMax(params int[] numbers)
        {
            int max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                    max = numbers[i];
            }
            return max;
        }
    }
}
