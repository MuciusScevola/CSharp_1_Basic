namespace Theme03_Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nmr1, nmr2;
            nmr1 = Convert.ToInt32(Console.ReadLine());
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

            Console.WriteLine("Нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
