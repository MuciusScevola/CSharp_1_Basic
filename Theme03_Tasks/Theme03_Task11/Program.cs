namespace Theme03_Task11
{
    internal class Program
    {
        static void Main()
        {
            //Можно ли на прямоугольном участке застройки размером a * b метров разместить два дома размером в плане p * q и r * s метров?
            //Дома можно располагать только параллельно сторонам участка. Дома могу стоять вплотную друг к другу.

            Console.Write("Введите длину участка (a): ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите ширину участка (b): ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите длину первого дома (p): ");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите ширину первого дома (q): ");
            int q = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите длину второго дома (r): ");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите ширину второго дома (s): ");
            int s = Convert.ToInt32(Console.ReadLine());

            // Дома параллельны по длинным сторонам.
            bool variant1 = ((p + r) <= a && Math.Max(q, s) <= b) || (Math.Max(p, r) <= a && (q + s) <= b);

            // Дома параллельны по длинной стороне одного и ширикой стороне другого.
            bool variant2 = ((q + r) <= a && Math.Max(p, s) <= b) || (Math.Max(q, r) <= a && (p + s) <= b);
            bool variant3 = ((p + s) <= a && Math.Max(q, r) <= b) || (Math.Max(p, s) <= a && (q + r) <= b);

            // Дома параллельны по широким сторонам.
            bool variant4 = ((q + s) <= a && Math.Max(p, r) <= b) || (Math.Max(q, s) <= a && (p + r) <= b);


            // Проверяем, выполняется ли хотя бы один вариант
            bool placementPossible = variant1 || variant2 || variant3 || variant4;

            // Выводим результат
            if (placementPossible)
                Console.WriteLine("Да, можно разместить оба дома на участке.");
            else
                Console.WriteLine("Нет, нельзя разместить оба дома на участке.");


            Console.WriteLine("\nНажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
