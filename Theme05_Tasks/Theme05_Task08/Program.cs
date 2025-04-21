namespace Theme05_Task08
{
    internal class Program
    {
        static void Main()
        {
            //Сформировать одномерный массив из 5 случайных чисел из диапазона [0, 10].
            //Найти два наибольших элемента.
            const int n = 5;
            int[] arr = new int[n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(0, 11);
                Console.Write(arr[i]);
                Console.Write(i < arr.Length - 1 ? " | " : "");
            }

            int maxFst = 0;
            int maxSnd = 0;
            foreach (int unit in arr)
            {
                if (unit > maxFst)
                {
                    maxSnd = maxFst;
                    maxFst = unit;
                }
                else if (unit > maxSnd)
                {
                    maxSnd = unit;
                }
            }
            Console.WriteLine($"\nМаксимум 1: {maxFst}");
            Console.WriteLine($"Максимум 2: {maxSnd}");

            Console.WriteLine("\nНажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
