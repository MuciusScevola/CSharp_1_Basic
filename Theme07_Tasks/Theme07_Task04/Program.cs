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

            Console.WriteLine("Нажмите любую клавишу.");
            Console.ReadKey();

        }
        static int FindMax(params int[] numbers)
        {
            int max = numbers[0];
            foreach (int unit in numbers)
            {
                if (unit > max)
                    max = unit;
            }
            return max;
        }
    }
}
