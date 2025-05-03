using System.Text;

namespace Theme03_Task12
{
    internal class Program
    {
        static void Main()
        {
            //Дано целое число в диапазоне 100–999.
            //Вывести строку - описание словесное описание данного числа.
            //Если пользователь введёт данные, не соответствующие условию задачи - выдать сообщение об ошибке.
            Console.OutputEncoding = Encoding.Unicode;

            int number;
            Console.Write("Введите целое число в диапазоне 100-999: ");
            number = Convert.ToInt32(Console.ReadLine()); ;

            // Проверка на ошибки.
            if (number < 100 || number > 999)
                Console.WriteLine("Ошибка! Введите число в диапазоне 100-999.");

            // Разбивка введенного числа на цифры.
            int hundreds = number / 100;
            int tens = (number / 10) % 10;
            int units = number % 10;

            //string description = ""; // Пустая строка для итогового описания.

            // Описание сотен
            string hundredD = ""; // Cтрока для описания сотен.
            string tenD = ""; // Строка для описания десяток.
            string unitD = ""; // Строка для описания десяток.
            switch (hundreds)
            {
                case 1: hundredD = "сто"; break;
                case 2: hundredD = "двести"; break;
                case 3: hundredD = "триста"; break;
                case 4: hundredD = "четыреста"; break;
                case 5: hundredD = "пятьсот"; break;
                case 6: hundredD = "шестьсот"; break;
                case 7: hundredD = "семьсот"; break;
                case 8: hundredD = "восемьсот"; break;
                case 9: hundredD = "девятьсот"; break;
            }

            if (tens == 1)
            {
                switch (units)
                {
                    case 0: tenD = "десять"; break;
                    case 1: tenD = "одиннадцать"; break;
                    case 2: tenD = "двенадцать"; break;
                    case 3: tenD = "тринадцать"; break;
                    case 4: tenD = "четырнадцать"; break;
                    case 5: tenD = "пятнадцать"; break;
                    case 6: tenD = "шестнадцать"; break;
                    case 7: tenD = "семнадцать"; break;
                    case 8: tenD = "восемнадцать"; break;
                    case 9: tenD = "девятнадцать"; break;
                }
            }
            else
            {
                switch (tens)
                {
                    case 2: tenD = " двадцать"; break;
                    case 3: tenD = " тридцать"; break;
                    case 4: tenD = " сорок"; break;
                    case 5: tenD = " пятьдесят"; break;
                    case 6: tenD = " шестьдесят"; break;
                    case 7: tenD = " семьдесят"; break;
                    case 8: tenD = " восемьдесят"; break;
                    case 9: tenD = " девяносто"; break;
                }

                if (units > 0)
                {
                    switch (units)
                    {
                        case 1: unitD = "один"; break;
                        case 2: unitD = "два"; break;
                        case 3: unitD = "три"; break;
                        case 4: unitD = "четыре"; break;
                        case 5: unitD = "пять"; break;
                        case 6: unitD = "шесть"; break;
                        case 7: unitD = "семь"; break;
                        case 8: unitD = "восемь"; break;
                        case 9: unitD = "девять"; break;
                    }
                }
            }

            Console.WriteLine($"{number} — «{hundredD}" + $"{(tens != 0 ? " " + tenD : "")}" + $"{(units != 0 && tens != 1 ? " " + unitD : "")}».");

            Console.WriteLine("\nНажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
