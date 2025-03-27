namespace Theme03_Task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
            else
            {
                int hundreds = number / 100;
                int tens = (number / 10) % 10;
                int units = number % 10;

                // Описание сотен
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
                    string teens = "";
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
            }
        }
    }