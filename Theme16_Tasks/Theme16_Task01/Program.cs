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

            Console.WriteLine($"\nСгенерированный массив: [{string.Join(", ", array)}].");
            return array;
        }

        static double AverageOfArray(int[] array)
        {
            if (array == null || array.Length == 0)
                throw new ArgumentException("\nМассив пуст.");

            Console.WriteLine("Вычисляется среднее.");
            Thread.Sleep(1500);

            double average = array.Average();
            Console.WriteLine($"Среднее арифметическое: {average:F2}");
            return average;
        }

        static async Task<int[]> GenerateArrayAsync(int n)
        {
            await Task.Delay(1500);
            return GenerateArray(n);
        }

        static async Task<double> AverageOfArrayAsync(int[] array)
        {
            Console.WriteLine("\nВычисляется среднее...");
            await Task.Delay(750);

            double average = AverageOfArray(array);
            Console.WriteLine($"\nСреднее арифметическое: {average:F2}");
            return average;
        }

        static async Task Main()
        {
            Console.WriteLine("Проверка с использованием задач продолжения.");
            Task<int[]> task_1 = Task.Run(() => GenerateArray(10));
            Task<int[]> task_2 = task_1.ContinueWith(task =>
            {
                return task.Result;
            });

            Thread.Sleep(3000); // Пауза между способами проверки.

            Console.WriteLine("\nПроверка с помощью async/await.");
            int[] generatedArray = await GenerateArrayAsync(10);
            await AverageOfArrayAsync(generatedArray);

            Console.WriteLine("\nНажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
