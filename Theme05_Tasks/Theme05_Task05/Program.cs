namespace Theme05_Task05
{
    internal class Program
    {
        static void Main()
        {
            //Сформировать одномерный массив из 10 случайных чисел в диапазоне [-50, 50].
            //Первые 5 элементов упорядочить по возрастанию, вторые 5 – по убыванию.
            //Вывести отсортированный таким образом массив на экран.
            const int n = 10;
            int[] arr = new int[n];
            Random rnd = new Random();

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(-50, 51);
                Console.Write(arr[i]);
                Console.Write(i < arr.Length - 1 ? " | " : "");
            }
            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            for (int i = 5; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("\nОтсортированный массив:");
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                Console.Write(arr[i]);
                if (i == 4) Console.Write(" || ");
                else if (i < arr.Length - 1) Console.Write(" | "); ;
            }

            Console.WriteLine("\n\nНажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
