namespace Theme03_Task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Можно ли на прямоугольном участке застройки размером a * b метров разместить два дома размером в плане p * q и r * s метров?
            //Дома можно располагать только параллельно сторонам участка. Дома могу стоять «вплотную» друг к другу.

            // Размеры участка
            Console.Write("Введите длину участка (a): ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите ширину участка (b): ");
            int b = int.Parse(Console.ReadLine());

            // Размеры первого дома
            Console.Write("Введите длину первого дома (p): ");
            int p = int.Parse(Console.ReadLine());
            Console.Write("Введите ширину первого дома (q): ");
            int q = int.Parse(Console.ReadLine());

            // Размеры второго дома
            Console.Write("Введите длину второго дома (r): ");
            int r = int.Parse(Console.ReadLine());
            Console.Write("Введите ширину второго дома (s): ");
            int s = int.Parse(Console.ReadLine());

            // Проверка всех возможных вариантов размещения

            // Вариант 1: оба дома в стандартной ориентации
            bool variant1 = (p + r <= a && Math.Max(q, s) <= b) ||
                            (Math.Max(p, r) <= a && q + s <= b);

            // Вариант 2: первый дом повернут, второй стандартный
            bool variant2 = (q + r <= a && Math.Max(p, s) <= b) ||
                            (Math.Max(q, r) <= a && p + s <= b);

            // Вариант 3: первый дом стандартный, второй повернут
            bool variant3 = (p + s <= a && Math.Max(q, r) <= b) ||
                            (Math.Max(p, s) <= a && q + r <= b);

            // Вариант 4: оба дома повернуты
            bool variant4 = (q + s <= a && Math.Max(p, r) <= b) ||
                            (Math.Max(q, s) <= a && p + r <= b);

            // Проверяем, выполняется ли хотя бы один вариант
            bool canPlace = variant1 || variant2 || variant3 || variant4;

            // Выводим результат
            if (canPlace)
            {
                Console.WriteLine("Да, можно разместить оба дома на участке.");
            }
            else
            {
                Console.WriteLine("Нет, нельзя разместить оба дома на участке.");
            }
        }
    }

    Console.WriteLine("\nНажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
