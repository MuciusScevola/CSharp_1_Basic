namespace Them05_Task02
{
    internal class Program
    {
        static void Main()
        {
            //Сформировать одномерный массив из 10 случайных чисел из диапазона[-20, 20].
            //Определить количество положительных, отрицательных и равных нулю элементов.
            const int n = 10;
            int[] arr = new int[n];
            Random rnd = new Random();

            int countPos = 0; // Счетчик положительных чисел.
            int countNeg = 0; // Счетчик отрицательных чисел.
            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(-20, 21);
                Console.Write(arr[i]);
                Console.Write(i < arr.Length - 1 ? " | " : "");
                if (arr[i] > 0) countPos++;
                else if (arr[i] < 0) countNeg++;
            }
            Console.WriteLine();
            int countZero = n - countPos - countNeg; // Счетчик нулевых чисел.
            Console.WriteLine($"Количество положительныех чисел: {countPos}.");
            Console.WriteLine($"Количество положительныех чисел: {countNeg}.");
            Console.WriteLine($"Количество нулевых чисел: {countZero}.");

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
