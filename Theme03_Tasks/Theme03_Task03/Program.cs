namespace Theme03_Task03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nmr1, nmr2, nmr3, nmr4;
            nmr1 = Convert.ToInt32(Console.ReadLine());
            nmr2 = Convert.ToInt32(Console.ReadLine());
            nmr3 = Convert.ToInt32(Console.ReadLine());
            nmr4 = Convert.ToInt32(Console.ReadLine());

            int max1 = nmr1 >= nmr2 ? nmr1 : nmr2;
            int max2 = nmr3 >= nmr4 ? nmr3 : nmr4;
            int max = max1 >= max2 ? max1 : max2;

            Console.WriteLine($"Максимум = {max}");

            Console.WriteLine("Нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
