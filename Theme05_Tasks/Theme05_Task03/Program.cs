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
            int numMax = arr[0]; // Максимум.
            //int numMin = 0; // Минимум.
            foreach (int unit in arr)
            {
                if (unit > numMax)
                {
                    numMax = unit;
                }
            }
            ////if (arr[i] > 0) countPos++;
            //else if (arr[i] < 0) countNeg++;
            //int countZero = n - countPos - countNeg; // Счетчик нулевых чисел.
            Console.WriteLine($"\nМаксимум: {numMax}.");
            //Console.WriteLine($"\nКоличество положительныех чисел: {countNeg}.");

            //Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
