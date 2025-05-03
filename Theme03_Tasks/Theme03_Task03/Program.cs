namespace Theme03_Task03
{
    internal class Program
    {
        static void Main()
        {
            // Вводятся четыре числа. Вывести большее из них.
            int nmr1, nmr2, nmr3, nmr4;
            Console.WriteLine("Введите первое число:");
            nmr1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            nmr2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье число:");
            nmr3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите четвертое число:");
            nmr4 = Convert.ToInt32(Console.ReadLine());

            int max1 = nmr1 >= nmr2 ? nmr1 : nmr2;
            int max2 = nmr3 >= nmr4 ? nmr3 : nmr4;
            int max = max1 >= max2 ? max1 : max2;

            Console.WriteLine($"Максимум = {max}");

            Console.WriteLine("\nНажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
