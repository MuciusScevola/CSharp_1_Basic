namespace Theme03_Task12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Дано целое число в диапазоне 100–999.
            //Вывести строку - описание словесное описание данного числа.
            //Если пользователь введёт данные, не соответствующие условию задачи - выдать сообщение об ошибке.

            int number;
            Console.Write("Введите число в диапазоне 100-999: ");
            number = Convert.ToInt32(Console.ReadLine()); ;
            int hundreds = number / 100;
            int tens = (number / 10) % 10;
            int units = number % 10;

            if (number < 100 || number > 999)
            {
                Console.WriteLine("Ошибка! Введите число в диапазоне 100-999.");
            }

            switch (hundreds)
            {
                case 1: description = "сто"; break;
                case 2: description = "двести"; break;
                case 3: description = "триста"; break;
                case 4: description = "четыреста"; break;
                case 5: description = "пятьсот"; break;
                case 6: description = "шестьсот"; break;
                case 7: description = "семьсот"; break;
                case 8: description = "восемьсот"; break;
                case 9: description = "девятьсот"; break;
            }

            // Описание десятков и единиц
            if (tens == 1)
            {
                string tens = "";
                switch (units)
                {
                    case 0: teens = "десять"; break;
                    case 1: teens = "одиннадцать"; break;
                    case 2: teens = "двенадцать"; break;
                    case 3: teens = "тринадцать"; break;
                    case 4: teens = "четырнадцать"; break;
                    case 5: teens = "пятнадцать"; break;
                    case 6: teens = "шестнадцать"; break;
                    case 7: teens = "семнадцать"; break;
                    case 8: teens = "восемнадцать"; break;
                    case 9: teens = "девятнадцать"; break;
                }
                description += (description.Length > 0 ? " " : "") + teens;
            }
            else
            {
                // Десятки
                if (tens > 1)
                {
                    string tensStr = "";
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
                    description += (description.Length > 0 ? " " : "") + tensStr;
                }

                // Единицы
                if (units > 0)
                {
                    string unitsStr = "";
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
                    description += (description.Length > 0 ? " " : "") + unitsStr;
                }
            }
            Console.WriteLine($"{number} — «{description}»");

            /*

    // Проверка диапазона


    // Получаем отдельные цифры числа
    int hundreds = number / 100;
    int tens = (number / 10) % 10;
    int units = number % 10;

    string result = "";

    // Описание сотен
    switch (hundreds)
    {
        case 1: result += "сто "; break;
        case 2: result += "двести "; break;
        case 3: result += "триста "; break;
        case 4: result += "четыреста "; break;
        case 5: result += "пятьсот "; break;
        case 6: result += "шестьсот "; break;
        case 7: result += "семьсот "; break;
        case 8: result += "восемьсот "; break;
        case 9: result += "девятьсот "; break;
    }

    // Описание десятков и единиц
    if (tens == 1)
    {
        // Особый случай для чисел 10-19
        switch (units)
        {
            case 0: result += "десять"; break;
            case 1: result += "одиннадцать"; break;
            case 2: result += "двенадцать"; break;
            case 3: result += "тринадцать"; break;
            case 4: result += "четырнадцать"; break;
            case 5: result += "пятнадцать"; break;
            case 6: result += "шестнадцать"; break;
            case 7: result += "семнадцать"; break;
            case 8: result += "восемнадцать"; break;
            case 9: result += "девятнадцать"; break;
        }
    }
    else
    {
        // Описание десятков (20-99)
        switch (tens)
        {
            case 2: result += "двадцать "; break;
            case 3: result += "тридцать "; break;
            case 4: result += "сорок "; break;
            case 5: result += "пятьдесят "; break;
            case 6: result += "шестьдесят "; break;
            case 7: result += "семьдесят "; break;
            case 8: result += "восемьдесят "; break;
            case 9: result += "девяносто "; break;
        }

        // Описание единиц (только если десятки не 1)
        switch (units)
        {
            case 1: result += "один"; break;
            case 2: result += "два"; break;
            case 3: result += "три"; break;
            case 4: result += "четыре"; break;
            case 5: result += "пять"; break;
            case 6: result += "шесть"; break;
            case 7: result += "семь"; break;
            case 8: result += "восемь"; break;
            case 9: result += "девять"; break;
        }
    }

    Console.WriteLine(result.Trim()); // Удаляем возможные пробелы в конце
            */
            Console.WriteLine("\nНажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
}