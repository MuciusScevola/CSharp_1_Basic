namespace Theme02_Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int var1, var2;
            var1 = Convert.ToInt32(Console.ReadLine());
            var2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Исходные значения: var1 = {var1}, var2 = {var2}");

            var1 = var1 + var2;
            var2 = var1 - var2;
            var1 = var1 - var2;
            Console.WriteLine($"Переприсвоенные значения: var1 = {var1}, var2 = {var2}");

            Console.WriteLine("Нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
