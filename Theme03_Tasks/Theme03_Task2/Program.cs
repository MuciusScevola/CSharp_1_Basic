namespace Theme03_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nmr1, nmr2, nmr3;
            nmr1 = Convert.ToInt32(Console.ReadLine());
            nmr2 = Convert.ToInt32(Console.ReadLine());
            nmr3 = Convert.ToInt32(Console.ReadLine());

            if (nmr1 >= nmr2 && nmr1 >= nmr3)
            {
                Console.WriteLine($"Максимум = {nmr1}");
            }
            else if (nmr2 >= nmr1 && nmr2 >= nmr3)
            {
                Console.WriteLine($"Максимум = {nmr2}");
            }
            else if (nmr3 >= nmr1 && nmr3 >= nmr2)
            {
                Console.WriteLine($"Максимум = {nmr3}");
            }
            else if (nmr1 >= nmr2 && nmr2 >= nmr3)
            {
                Console.WriteLine($"Максимум = {nmr1}"); 
            }
            else if (nmr2 >= nmr1 && nmr3 >= nmr1)
            {
                Console.WriteLine($"Максимум = {nmr2}");
            }
            else if (nmr3 >= nmr1 && nmr1 >= nmr2)
            {
                Console.WriteLine($"Максимум = {nmr3}");
            }
            
            Console.WriteLine("Нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
