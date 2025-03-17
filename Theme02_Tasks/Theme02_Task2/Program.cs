namespace Theme02_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double degs, mins, secs;
            degs = Convert.ToDouble(Console.ReadLine());
            mins = Convert.ToDouble(Console.ReadLine());
            secs = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Введенное значение угла: {degs}° {mins}\" {secs}'"); // Значения минут и секунд 

            var rads = Math.PI * (degs + mins / 60 + secs / 3600) / 180; // Перевод градусной меры в радианную

            Console.WriteLine($"Полученное значение угла: {Math.Round(rads, 5)} рад");*/
            Console.WriteLine("Нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
