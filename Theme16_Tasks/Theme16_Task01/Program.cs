// Разработать метод для формирования массива
// и метод для расчета среднего арифметического всех чисел в массиве
// (в методах сделать искусственную задержку - имитация длительных вычислений).
// В методе Main выполнить проверку работы методов 2-мя способами -
// сначала используя задачи продолжения, затем - с помощью async/await.

using System.CodeDom.Compiler;
using System.Threading.Tasks;

namespace Theme16_Task01
{
    class Program
    {
        static int[] GenerateArray(int n)
        {
            Console.WriteLine("Генерация массива...");
            var random = new Random();
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-100, 101);
                Thread.Sleep(200);
            }

            Console.WriteLine($"Сгенерированный массив: [{string.Join(", ", array)}].");
            return array;
        }

        static double AverageOfArray(int[] array)
        {
            if (array == null || array.Length == 0)
                throw new ArgumentException("\nМассив пуст.");

            Console.WriteLine("\nВычисляется среднее арифметическое.");
            Thread.Sleep(750);

            double average = array.Average();
            Console.WriteLine($"Результат: {average:F2}");
            return average;
        }

        static async Task<int[]> GenerateArrayAsync(int n)
        {
            await Task.Delay(750);
            return GenerateArray(n);
        }

        static async Task<double> AverageOfArrayAsync(int[] array)
        {
            await Task.Delay(750);

            double average = AverageOfArray(array);
            return average;
        }

        // 
        static async Task Main()
        {
            Console.WriteLine("Проверка с использованием задач продолжения.");
            Console.WriteLine();
            Task<int[]> task_1 = Task.Run(() => GenerateArray(10));
            Task task_2 = task_1.ContinueWith(task =>
            {
                AverageOfArray(task.Result);
            });

            await task_2;

            Thread.Sleep(2000); // Пауза между способами проверки.

            Console.WriteLine("\nПроверка с помощью async/await.");
            Console.WriteLine();
            int[] generatedArray = await GenerateArrayAsync(10);
            await AverageOfArrayAsync(generatedArray);

            Console.WriteLine("\nНажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
