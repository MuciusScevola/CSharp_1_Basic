namespace Theme05_Task04
{
    internal class Program
    {
        static void Main()
        {
            //Сформировать одномерный массив из 10 случайных чисел из диапазона [0, 10].
            //Перевернуть массив, т.е. переставить элементы массива в обратном порядке.
            const int n = 10;
            int[] arr = new int[n];
            Random rnd = new Random();

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(0, 51);
                Console.Write(arr[i]);
                Console.Write(i < arr.Length - 1 ? " | " : "");
            }
            Console.WriteLine();

            Console.WriteLine("\nОтраженный массив:");
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i]);
                if (i > 0) Console.Write(" | ");
            }

            Console.WriteLine("\n\nНажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
