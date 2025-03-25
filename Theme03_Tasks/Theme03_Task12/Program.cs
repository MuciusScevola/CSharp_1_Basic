namespace Theme03_Task12
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите число в диапазоне 100-999: ");
            int number;

            if (int.TryParse(Console.ReadLine(), out number))
            {
                if (number >= 100 && number <= 999)
                {
                    string description = GetNumberDescription(number);
                    Console.WriteLine($"{number} — «{description}»");
                }
                else
                {
                    Console.WriteLine("Ошибка: число должно быть в диапазоне 100-999");
                }
            }
            else
            {
                Console.WriteLine("Ошибка: введено не целое число");
            }
        }

        static string GetNumberDescription(int number)
        {
            int hundreds = number / 100;
            int tens = (number / 10) % 10;
            int units = number % 10;

            string hundredsStr = "";
            string tensStr = "";
            string unitsStr = "";

            // Описание сотен
            switch (hundreds)
            {
                case 1: hundredsStr = "сто"; break;
                case 2: hundredsStr = "двести"; break;
                case 3: hundredsStr = "триста"; break;
                case 4: hundredsStr = "четыреста"; break;
                case 5: hundredsStr = "пятьсот"; break;
                case 6: hundredsStr = "шестьсот"; break;
                case 7: hundredsStr = "семьсот"; break;
                case 8: hundredsStr = "восемьсот"; break;
                case 9: hundredsStr = "девятьсот"; break;
            }

            // Описание десятков и единиц (особые случаи 10-19)
            if (tens == 1)
            {
                switch (units)
                {
                    case 0: tensStr = "десять"; break;
                    case 1: tensStr = "одиннадцать"; break;
                    case 2: tensStr = "двенадцать"; break;
                    case 3: tensStr = "тринадцать"; break;
                    case 4: tensStr = "четырнадцать"; break;
                    case 5: tensStr = "пятнадцать"; break;
                    case 6: tensStr = "шестнадцать"; break;
                    case 7: tensStr = "семнадцать"; break;
                    case 8: tensStr = "восемнадцать"; break;
                    case 9: tensStr = "девятнадцать"; break;
                }
            }
            else
            {
                // Описание десятков
                switch (tens)
                {
                    case 2: tensStr = "двадцать"; break;
                    case 3: tensStr = "тридцать"; break;
                    case 4: tensStr = "сорок"; break;
                    case 5: tensStr = "пятьдесят"; break;
                    case 6: tensStr = "шестьдесят"; break;
                    case 7: tensStr = "семьдесят"; break;
                    case 8: tensStr = "восемьдесят"; break;
                    case 9: tensStr = "девяносто"; break;
                }

                // Описание единиц
                switch (units)
                {
                    case 1: unitsStr = "один"; break;
                    case 2: unitsStr = "два"; break;
                    case 3: unitsStr = "три"; break;
                    case 4: unitsStr = "четыре"; break;
                    case 5: unitsStr = "пять"; break;
                    case 6: unitsStr = "шесть"; break;
                    case 7: unitsStr = "семь"; break;
                    case 8: unitsStr = "восемь"; break;
                    case 9: unitsStr = "девять"; break;
                }
            }

            // Собираем итоговую строку
            string result = hundredsStr;

            if (!string.IsNullOrEmpty(tensStr))
            {
                result += (string.IsNullOrEmpty(result) ? "" : " ") + tensStr;
            }

            if (!string.IsNullOrEmpty(unitsStr) && tens != 1)
            {
                result += (string.IsNullOrEmpty(result) ? "" : " ") + unitsStr;
            }

            return result;
        }
    }
}
