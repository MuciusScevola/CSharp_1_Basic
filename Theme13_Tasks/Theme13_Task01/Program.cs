namespace Theme13_Task01
{
    class Program
    {
        public delegate int Transformer(int x);
        public static int[] Transform(int[] array, Transformer transformer)
        {
            int[] transformedArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            { transformedArray[i] = transformer(array[i]); }

            return transformedArray;
        }

        static void Main()
        {
            int[] numbers = { -3, -2, -1, 0, 1, 2, 3 };

            // 3. Демонстрация работы метода Transform:

            // a) Удвоение всех чисел
            Transformer doubleTransformer = x => x * 2; // Лямбда-выражение для удвоения
            int[] doubledNumbers = Transform(numbers, doubleTransformer);
            Console.WriteLine("Удвоенные числа: " + string.Join(", ", doubledNumbers));

            // b) Возведение в квадрат
            Transformer squareTransformer = x => x * x; // Лямбда-выражение для возведения в квадрат
            int[] squaredNumbers = Transform(numbers, squareTransformer);
            Console.WriteLine("Квадраты чисел: " + string.Join(", ", squaredNumbers));

            // c) Замена чисел на их модули
            Transformer absTransformer = x => Math.Abs(x); // Используем Math.Abs для получения модуля
            int[] absNumbers = Transform(numbers, absTransformer);
            Console.WriteLine("Модули чисел: " + string.Join(", ", absNumbers));
        }
    }
}