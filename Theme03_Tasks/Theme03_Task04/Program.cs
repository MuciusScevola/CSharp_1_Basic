namespace Theme03_Task04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Вводятся три разных числа. Вывести медиану – промежуточное по величине число.
            double nmr1, nmr2, nmr3;
            nmr1 = Convert.ToDouble(Console.ReadLine());
            nmr2 = Convert.ToDouble(Console.ReadLine());
            nmr3 = Convert.ToDouble(Console.ReadLine());

            var maxNmr = Math.Max(nmr1, Math.Max(nmr2, nmr3));
            var minNmr = Math.Min(nmr1, Math.Min(nmr2, nmr3));
            if (nmr1 != maxNmr && nmr1 != minNmr)
            {
                Console.WriteLine($"Медиана = {nmr1}");

            }
            else if (nmr2 != maxNmr && nmr2 != minNmr)
            {
                Console.WriteLine($"Медиана = {nmr1}");
            }
            else {
                Console.WriteLine($"Медиана = {nmr3}");
            }


            Console.WriteLine("Нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
