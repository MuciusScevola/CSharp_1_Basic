namespace Theme08_Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Смоделируйте работу простого калькулятора.
             * Программа должна запрашивать 2 целых числа, а затем – код операции.
             * После этого на консоль выводится ответ.
             * Используйте обработку деления на ноль (DivideByZeroException), нечислового ввода (FormatException).
             */
            try
            {
                Console.Write("Введите первое число: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите второе число: ");
                int b = Convert.ToInt32(Console.ReadLine());

                int operatorCode;
                while (true)
                {
                    Console.WriteLine("\nВыберите операцию:");
                    Console.WriteLine("1 - сложение.");
                    Console.WriteLine("2 - вычитание.");
                    Console.WriteLine("3 - умножение.");
                    Console.WriteLine("4 - деление.");

                    try
                    {
                        operatorCode = Convert.ToInt32(Console.ReadLine());
                        if (operatorCode >= 1 && operatorCode <= 4)
                            break;
                        else
                            Console.WriteLine("ОШИБКА: введите число от 1 до 4.");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("ОШИБКА: введите число от 1 до 4.");
                    }
                }

                if (operatorCode == 4)
                {
                    double resultDiv = Calculate4(a, b);
                    Console.WriteLine($"\n{a} / {b} = {resultDiv}");
                }
                int result = Calculate123(a, b, operatorCode);
                if (operatorCode == 1)
                    Console.WriteLine($"\n{a} + {b} = {result}");
                else if (operatorCode == 2)
                    Console.WriteLine($"\n{a} - {b} = {result}");
                else if (operatorCode == 3)
                    Console.WriteLine($"\n{a} * {b} = {result}");

            }
            catch (FormatException)
            {
                Console.WriteLine("ОШИБКА: введите целое число.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("ОШИБКА: деление на ноль!");
            }

            Console.WriteLine("\nНажмите любую клавишу.");
            Console.ReadKey();
        }

        static int Calculate123(int a, int b, int operation) // Метод только для целочисленных операций.
        {
            switch (operation)
            {
                case 1: return a + b;
                case 2: return a - b;
                case 3: return a * b;
            }
            return 0;
        }

        static double Calculate4(int a, int b) // Метод для вещественного деления.
        {
            if (b == 0)
                throw new DivideByZeroException();

            return (double)a / b;
        }
    }
}
