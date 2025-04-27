namespace Theme03_Task01
{
    internal class Program
    {
        static void Main()
        {
            // Вводятся два числа. Сравнить их и вывести правильный знак «<», «>» или «=».
            int nmr1, nmr2;
            Console.WriteLine("Введите первое число:");
            nmr1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            nmr2 = Convert.ToInt32(Console.ReadLine());

            if (nmr1 > nmr2)
            {
                Console.WriteLine($"{nmr1} > {nmr2}");
            }
            else if (nmr1 < nmr2)
            {
                Console.WriteLine($"{nmr1} < {nmr2}");
            }
            else if (nmr1 == nmr2)
            {
                Console.WriteLine($"{nmr1} = {nmr2}");
            } 

            Console.WriteLine("\nНажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
