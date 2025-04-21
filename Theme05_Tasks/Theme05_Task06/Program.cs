namespace Theme05_Task06
{
    internal class Program
    {
        static void Main()
        {
            //Сформировать двумерный массив вида:
            //    1 0 1 0 1
            //    0 1 0 1 0
            //    1 0 1 0 1
            //    0 1 0 1 0
            //    1 0 1 0 1
            const int n = 5;
            int[,] arr = new int[n, n];

            Console.WriteLine($"Матрица {n}x{n} из 0 и 1:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = (i + j) % 2 == 0 ? 0 : 1;
                    Console.Write(arr[i, j]);
                    if (j < n - 1)
                        Console.Write(" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nНажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
