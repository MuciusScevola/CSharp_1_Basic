namespace Theme13_Task01
{
    class Program
    {
        public delegate int Transformer(int a);
        public static int[] Transform(int[] array, Transformer transformer)
        {
            int[] transArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            { transArray[i] = transformer(array[i]); }

            return transArray;
        }

        static void Main()
        {
            // Исходный массив.
            Random random = new Random();

            int arraySize = 10;

            int[] numbers = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            { numbers[i] = random.Next(-10, 10); }

            Console.WriteLine("Сгенерированный массив:" + $"\n[{string.Join(", ", numbers)}]");

            // Демонстрация работы метода Transform.
            Transformer doubleTransformer = x => x * 2;
            int[] doubledNumbers = Transform(numbers, doubleTransformer);
            Console.WriteLine("\nУдвоение всех чисел:" + $"\n[{string.Join(", ", doubledNumbers)}]");

            Transformer squareTransformer = x => x * x;
            int[] squaredNumbers = Transform(numbers, squareTransformer);
            Console.WriteLine("\nВозведение в квадрат:" + $"\n[{string.Join(", ", squaredNumbers)}]");

            Transformer absTransformer = x => Math.Abs(x);
            int[] absNumbers = Transform(numbers, absTransformer);
            Console.WriteLine("\nЗамена чисел на их модули:" + $"\n[{string.Join(", ", absNumbers)})");

            Console.WriteLine("\nНажмите люую клавишу.");
            Console.ReadKey();
        }
    }
}