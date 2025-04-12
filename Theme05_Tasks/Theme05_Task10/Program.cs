namespace Theme05_Task10
{
    internal class Program
    {
        static void Main()
        {
            //Клеточное поле размером n*n(n – константа на ваш выбор) состоит из 0 («ноликов») и 1 («крестиков»).
            //Проверить, выиграли ли «крестики»?
            //Считается, что «крестики» выиграли, если на поле найдется горизонталь, вертикали или диагональ из «крестиков».
            // Размер поля можно изменить.
            const int n = 3;
            int[,] field = new int[n, n];
            Random random = new Random();

            int cells = n * n; // Общее количество клеток.
            int crosses = cells / 2 + cells % 2; // Крестиков на 1 больше при нечетном количестве клеток.
            int zeros = cells - crosses;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (random.Next(0, 2) == 0 && crosses > 0)
                    {
                        field[i, j] = 1;
                        crosses--;
                    }
                    else
                    {
                        field[i, j] = 0;
                        zeros--;
                    }
                }
            }

            Console.WriteLine("Крестики-нолики:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(field[i, j] == 1 ? " X" : " O");
                }
                Console.WriteLine();
            }

            bool xWins = false; // Проверка "крестики в линию".

            for (int i = 0; i < n && !xWins; i++) //Проверка строк.
            {
                bool rowWin = true;
                for (int j = 0; j < n; j++)
                {
                    if (field[i, j] != 1)
                    {
                        rowWin = false;
                        break;
                    }
                }
                xWins = rowWin;
            }

            for (int j = 0; j < n; j++) //Проверка столбцов.
            {
                bool columnWin = true;
                for (int i = 0; i < n; i++)
                {
                    if (field[i, j] != 1)
                    {
                        columnWin = false;
                        break;
                    }
                }
                xWins = columnWin;
            }

            if (!xWins) //Проверка главной диагонали.
            {
                bool diagMainWin = true;
                for (int i = 0; i < n; i++)
                {
                    if (field[i, i] != 1)
                    {
                        diagMainWin = false;
                        break;
                    }
                }
                xWins = diagMainWin;
            }

            if (!xWins) //Проверка побочной диагонали.
            {
                bool diagSideWin = true;
                for (int i = 0; i < n; i++)
                {
                    if (field[i, n - 1 - i] != 1)
                    {
                        diagSideWin = false;
                        break;
                    }
                    xWins = diagSideWin;
                }
            }

            Console.WriteLine(xWins ? "Крестики выиграли!" : "Крестики не выиграли.");
            
            Console.WriteLine("\nНажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
