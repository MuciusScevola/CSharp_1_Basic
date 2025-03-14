namespace Theme02_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a1, a2, a3;
            a1 = a2 = a3 = Convert.ToInt32(Console.ReadLine());
            /*b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());*/
            Console.WriteLine($"Исходные значения: {a1},{a2},{a3}");
            a1 = a2;
            a2 = a3;
            a3 = a1;
            Console.WriteLine($"Переприсвоенные значения: {a1},{a2},{a3}");*/
            Console.WriteLine("Нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
