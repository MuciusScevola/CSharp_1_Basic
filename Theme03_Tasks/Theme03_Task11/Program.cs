namespace Theme03_Task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, p, q, r, s;
            Console.Write("Введите длину участка: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите ширину участка: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите длину первого дома: ");
            p = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите ширину первого дома: ");
            q = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите длину второго дома: ");
            r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите ширину второго дома: ");
            s = Convert.ToDouble(Console.ReadLine());

            // Проверка всех комбинаций ориентаций домов
            bool canPlace = false;

            // Комбинация 1: (p, q) и (r, s)
            if (
                // Размещение в ряд по длине a
                (p + r <= a && Math.Max(q, s) <= b) ||
                // Размещение в ряд по ширине b
                (q + s <= b && Math.Max(p, r) <= a) ||
                // Размещение углом (p вдоль a, r вдоль b)
                (p + s <= a && Math.Max(q, r) <= b) ||
                // Размещение углом (q вдоль b, s вдоль a)
                (q + r <= b && Math.Max(p, s) <= a) ||
                // Размещение углом (p вдоль b, r вдоль a)
                (p + r <= b && Math.Max(q, s) <= a) ||
                // Размещение углом (q вдоль a, s вдоль b)
                (q + s <= a && Math.Max(p, r) <= b)
            )
                Console.WriteLine("Да");

            // Комбинация 2: (p, q) и (s, r)
            if (!canPlace && (
                (p + s <= a && Math.Max(q, r) <= b) ||
                (q + r <= b && Math.Max(p, s) <= a) ||
                (p + r <= a && Math.Max(q, s) <= b) ||
                (q + s <= b && Math.Max(p, r) <= a) ||
                (p + s <= b && Math.Max(q, r) <= a) ||
                (q + r <= a && Math.Max(p, s) <= b)
            )
                canPlace = true;

            // Комбинация 3: (q, p) и (r, s)
            if (!canPlace && (
                (q + r <= a && Math.Max(p, s) <= b) ||
                (p + s <= b && Math.Max(q, r) <= a) ||
                (q + s <= a && Math.Max(p, r) <= b) ||
                (p + r <= b && Math.Max(q, s) <= a) ||
                (q + r <= b && Math.Max(p, s) <= a) ||
                (p + s <= a && Math.Max(q, r) <= b)
            )
                canPlace = true;

            // Комбинация 4: (q, p) и (s, r)
            if (!canPlace && (
                (q + s <= a && Math.Max(p, r) <= b) ||
                (p + r <= b && Math.Max(q, s) <= a) ||
                (q + r <= a && Math.Max(p, s) <= b) ||
                (p + s <= b && Math.Max(q, r) <= a) ||
                (q + s <= b && Math.Max(p, r) <= a) ||
                (p + r <= a && Math.Max(q, s) <= b)
            )
                canPlace = true;

            // Вывод результата
            Console.WriteLine(canPlace ? "Да" : "Нет");

            Console.WriteLine("Нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
