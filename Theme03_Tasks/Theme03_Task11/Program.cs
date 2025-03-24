using System.ComponentModel;

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

            if (p + r >= a)
            {
                if (q + s >= b) {
                    {
                    Console.WriteLine("Да");
                }
            }
            else if
            {
                Console.WriteLine("Да.");
            }
            else
            {
                Console.WriteLine("Нет.");
            }

            Console.WriteLine("Нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
