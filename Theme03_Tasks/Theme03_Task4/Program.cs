namespace Theme03_Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nmr1, nmr2, nmr3;
            nmr1 = Convert.ToDouble(Console.ReadLine());
            nmr2 = Convert.ToDouble(Console.ReadLine());
            nmr3 = Convert.ToDouble(Console.ReadLine());

            double avrg = (nmr1 + nmr2 + nmr3) / 3;
            Console.WriteLine(avrg);

            Console.WriteLine("Нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
