namespace Theme05_Task10
{
    internal class Program
    {
        static void Main()
        {
            //Клеточное поле размером n*n(n – константа на ваш выбор) состоит из 0 («ноликов») и 1 («крестиков»).
            //Проверить, выиграли ли «крестики»?
            //Считается, что «крестики» выиграли, если на поле найдется горизонталь, вертикали или диагональ из «крестиков».
            // Размер поля (можно изменить)
            const int N = 3;

            // Игровое поле (можно изменить для тестирования)
            int[,] field = new int[N, N]
            {
            {1, 0, 1},
            {0, 1, 0},
            {1, 0, 1}
            };

            bool xWins = false;

            // Проверка горизонталей
            for (int i = 0; i < N; i++)
            {
                bool rowWin = true;
                for (int j = 0; j < N; j++)
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
                    goto Result; // Переход к выводу результата
                }
            }

            // Проверка вертикалей
            for (int j = 0; j < N; j++)
            {
                bool colWin = true;
                for (int i = 0; i < N; i++)
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
                    goto Result; // Переход к выводу результата
                }
            }

            // Проверка главной диагонали
            bool mainDiagWin = true;
            for (int i = 0; i < N; i++)
            {
                if (field[i, i] != 1)
                {
                    mainDiagWin = false;
                    break;
                }
            }
            if (mainDiagWin)
            {
                xWins = true;
                goto Result; // Переход к выводу результата
            }

            // Проверка побочной диагонали
            bool antiDiagWin = true;
            for (int i = 0; i < N; i++)
            {
                if (field[i, N - 1 - i] != 1)
                {
                    antiDiagWin = false;
                    break;
                }
            }
            if (antiDiagWin)
            {
                xWins = true;
            }

        Result:
            Console.WriteLine("Крестики " + (xWins ? "выиграли!" : "не выиграли."));
    
    }
    }
}
