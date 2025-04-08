namespace Theme05_Task01
{
    internal class Program
    {
        static void Main()
        {
            // Сформировать одномерный массив из 10 случайных чисел из диапазона [0, 100].
            // Определить, каких чисел больше – четных или нечетных.
            const int n = 10;
            int[] arr = new int[n];
            Random rnd = new Random();

            int countEven = 0; // Счетчик четных чисел.
            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(0, 101);
                Console.Write(arr[i]);
                Console.Write(i < arr.Length - 1 ? " | " : "");
                if (arr[i] % 2 == 0) countEven++;
            }
            Console.WriteLine();
            int countOdd = n - countEven; // Счетчик нечетных чисел.
            if (countEven > countOdd) { Console.WriteLine("Четных чисел больше."); }
            else if (countEven < countOdd) { Console.WriteLine("Нечетных чисел больше."); }
            else { Console.WriteLine("Количество четных и нечетных чисел равно."); }


            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
