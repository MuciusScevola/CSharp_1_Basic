namespace Theme02_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int var1, var2, var3;
            var1 = Convert.ToInt32(Console.ReadLine());
            var2 = Convert.ToInt32(Console.ReadLine());
            var3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Исходные значения: var1 = {var1}, var2 = {var2}, var3 = {var3}");
           
            int empty = var1; // Переменная "пустой стакан"
            var1 = var2;
            var2 = var3;
            var3 = empty;
            Console.WriteLine($"Переприсвоенные значения: var1 = {var1}, var2 = {var2}, var3 = {var3}");
            
            Console.WriteLine("Нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
