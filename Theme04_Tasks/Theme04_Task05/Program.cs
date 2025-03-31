namespace Theme04_Task05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Запрашивать у пользователя число до тех пор, пока он не введет число из диапазона [20; 60]
            bool inRange = true;
            while (inRange)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                if (number >= 20 && number <= 60)
                {
                    inRange = false;
                }
                else
                {
                    Console.Write("Введите число из диапазона [20, 60]. ");
                }
            }

            Console.WriteLine("Введенное число попадает в диапазон. Конец программы.");

            Console.WriteLine("Нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
