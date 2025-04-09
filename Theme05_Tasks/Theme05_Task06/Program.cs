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

            Console.WriteLine($"Матрица {n}x{n} из 0 и 1");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = i == j ? 0 : 1;
                    Console.Write(arr[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n\nНажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
