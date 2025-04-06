namespace Theme05_Task01
{
    internal class Program
    {
        static void Main()
        {
            // Сформировать одномерный массив из 10 случайных чисел из диапазона [0, 100].
            // Определить, каких чисел больше – четных или нечетных.
            const int n = 10;
            int[] array = new int[n];
            Random rnd = new Random();
            int s = 0;
            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(0, 101);
                s += array[i];
                Console.WriteLine($"{array[i]}");
            }


            Console.WriteLine("Нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
