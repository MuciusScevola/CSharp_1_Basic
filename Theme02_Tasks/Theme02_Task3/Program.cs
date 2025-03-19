namespace Theme02_Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double inches;
            inches = Convert.ToDouble(Console.ReadLine()); // Введённое значение может быть нецелочисленным.
            Console.WriteLine($"Введенное значение ISU: {inches}\"");

            double mmsFull = inches * 25.4; // Перевод дюймов в мм для разметки.
            int ms = (int)(Math.Truncate(mmsFull) / 1000);
            int cms = (int)((Math.Truncate(mmsFull) - (ms * 1000)) / 10);
            double mms = Math.Round((mmsFull - (ms * 1000) - (cms * 10)), 1); // Без округления получается ненужная точность (надо подумать, как переписать без Round).
            
            Console.WriteLine($"Полученное значение SI: {ms} м {cms} см {mms} мм");

            Console.WriteLine("Нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
