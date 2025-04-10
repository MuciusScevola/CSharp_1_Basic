namespace Them05_Task03
{
    internal class Program
    {
        static void Main()
        {
            //Сформировать одномерный массив из 10 случайных чисел из диапазона [0, 50].
            //Найти и вывести значение максимального, минимального элементов и их индексы.
            const int n = 10;
            int[] arr = new int[n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(0, 51);
                Console.Write(arr[i]);
                Console.Write(i < arr.Length - 1 ? " | " : "");
            }

            int arrMax = arr[0]; // Максимум.
            int arrMin = arr[0]; // Минимум.
            int maxIndex = 0; // Индекс максимума.
            int minIndex = 0; // Индекс минимума.

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > arrMax)
                {
                    arrMax = arr[i];
                    maxIndex = i;
                }
                if (arr[i] < arrMin)
                {
                    arrMin = arr[i];
                    minIndex = i;
                }
            }

            Console.WriteLine($"\nМаксимум: {arrMax} (индекс: {maxIndex})");
            Console.WriteLine($"Минимум: {arrMin} (индекс: {minIndex})");

            Console.WriteLine("\nНажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
