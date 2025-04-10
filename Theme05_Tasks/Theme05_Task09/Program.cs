namespace Theme05_Task09
{
    internal class Program
    {
        static void Main()
        {
            //Матрицу A(m, n) (m и n – константы с любым значением) заполнить натуральными числами
            //от 1 до n*m по спирали, начинающейся в левом верхнем углу и закрученной по часовой стрелке
            //Например,
            //1  2   3  4 5
            //16 17 18 19 6
            //15 24 25 20 7
            //14 23 22 21 8
            //13 12 11 10 9
            const int m = 6; // Строки.
            const int n = 5; // Столбцы.
            int[,] matrix = new int[m, n];

            // Переменные для заполнения
            int num = 1;
            int top = 0, bottom = m - 1;
            int left = 0, right = n - 1;

            // Заполняем матрицу по спирали
            while (num <= m * n)
            {
                // Движение вправо (верхняя строка)
                for (int i = left; i <= right; i++)
                {
                    matrix[top, i] = num;
                    num++;
                }
                top++;

                if (num > m * n) break;

                // Движение вниз (правый столбец)
                for (int i = top; i <= bottom; i++)
                {
                    matrix[i, right] = num;
                    num++;
                }
                right--;

                if (num > m * n) break;

                // Движение влево (нижняя строка)
                for (int i = right; i >= left; i--)
                {
                    matrix[bottom, i] = num;
                    num++;
                }
                bottom--;

                if (num > m * n) break;

                // Движение вверх (левый столбец)
                for (int i = bottom; i >= top; i--)
                {
                    matrix[i, left] = num;
                    num++;
                }
                left++;
            }
            Console.WriteLine($"Матрица {n}x{m}:");
            // Выводим матрицу
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0, 3} ", matrix[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nНажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
