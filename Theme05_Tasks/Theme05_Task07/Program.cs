namespace Theme05_Task07
{
    internal class Program
    {
        static void Main()
        {
            //Сформировать двумерный массив из 10 строк и 5 столбцов.
            //Заполнить его случайными числами в диапазоне [0, 10].
            //Определить максимальный элемент в каждой строке.
            const int n = 5;
            int[,] arr = new int[n, 2 * n];
            Random rnd = new Random();

            Console.WriteLine($"Матрица {n}x{2 * n} c максимумами:");
            for (int i = 0; i < n; i++)
            {
                arr[i, 0] = rnd.Next(0, 11);
                Console.Write(" {0,2}", arr[i, 0]);

                int rowMax = arr[i, 0];
                for (int j = 1; j < 2 * n; j++)
                {
                    arr[i, j] = rnd.Next(0, 11);
                    Console.Write("{0, 3}", arr[i, j]);

                    if (arr[i, j] > rowMax)
                        rowMax = arr[i, j];
                }
                Console.WriteLine($" --> Максимум: {rowMax}");
            }
            Console.WriteLine("\nНажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
