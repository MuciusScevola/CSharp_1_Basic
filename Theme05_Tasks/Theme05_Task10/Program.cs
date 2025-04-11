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
            const int n = 3; // Размер поля (можно изменить)
            int[,] field = new int[n, n];
            Random random = new Random();

            // Заполняем поле случайными 0 и 1
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    field[i, j] = random.Next(0, 2);
                }
            }

            // Выводим поле на экран
            Console.WriteLine("Поле:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(field[i, j] + " ");
                }
                Console.WriteLine();
            }

            bool xWins = false;

            // Проверяем горизонтали
            for (int i = 0; i < n; i++)
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
                if (rowWin)
                {
                    xWins = true;
                    goto EndCheck;
                }
            }

            // Проверяем вертикали
            for (int j = 0; j < n; j++)
            {
                bool colWin = true;
                for (int i = 0; i < n; i++)
                {
                    if (field[i, j] != 1)
                    {
                        colWin = false;
                        break;
                    }
                }
                if (colWin)
                {
                    xWins = true;
                    goto EndCheck;
                }
            }

            // Проверяем главную диагональ
            bool diag1Win = true;
            for (int i = 0; i < n; i++)
            {
                if (field[i, i] != 1)
                {
                    diag1Win = false;
                    break;
                }
            }
            if (diag1Win)
            {
                xWins = true;
                goto EndCheck;
            }

            // Проверяем побочную диагональ
            bool diag2Win = true;
            for (int i = 0; i < n; i++)
            {
                if (field[i, n - 1 - i] != 1)
                {
                    diag2Win = false;
                    break;
                }
            }
            if (diag2Win)
            {
                xWins = true;
                goto EndCheck;
            }

        EndCheck:
            Console.WriteLine(xWins ? "Крестики выиграли!" : "Крестики не выиграли.");

            Console.WriteLine("\n\nНажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
