namespace Theme03_Task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Можно ли на прямоугольном участке застройки размером a * b метров разместить два дома размером в плане p * q и r * s метров?
            //Дома можно располагать только параллельно сторонам участка. Дома могу стоять «вплотную» друг к другу.
            double a, b, p, q, r, s;
            Console.Write("Введите длину участка a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите ширину участка b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите длину первого дома p: ");
            p = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите ширину первого дома q: ");
            q = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите длину второго дома r: ");
            r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите ширину второго дома s: ");
            s = Convert.ToDouble(Console.ReadLine());

            // За точку отсчета комбинаций размещения и положения взят нижний левый угол земельного участка.
            // Комбинация 1: (p, q) и (r, s)
            if ((p + r <= a && Math.Max(q, s) <= b) || (p + s <= a && Math.Max(q, r) <= b) // Дом 1 - p по размеру а, дом 2 - r по a (вариант 1), s по a (2)
                || (q + s <= a && Math.Max(p, r) <= b) || (q + r <= a && Math.Max(p, s) <= b)) // Дом 1 - q по a, дом 2 - r по b (1), s по b (2)
            {
                Console.WriteLine("Да");
            }
            else if ((q + s <= b && Math.Max(p, r) <= a) || (q + r <= b && Math.Max(p, s) <= a) // Дом 1 - q по размеру b, дом 2 - r по b (вариант 1), s по b (2)
                || (p + r <= b && Math.Max(q, s) <= a) || (p + s <= b && Math.Max(q, r) <= a)) // Дом 1 - q по a, дом 2 - r по b (1), s по b (2)
            {
                Console.WriteLine("Да");
            }
            else
            {
                Console.WriteLine("Да");
            }

            Console.WriteLine("\nНажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
