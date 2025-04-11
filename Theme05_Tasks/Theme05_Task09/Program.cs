namespace Theme05_Task09
{
    internal class Program
    {
        static void Main()
        {
            //Матрицу A(m, n) (m и n – константы с любым значением) заполнить натуральными числами
            //от 1 до n*m по спирали, начинающейся в левом верхнем углу и закрученной по часовой стрелке
            //Например,
            // 1  2  3  4 5
            //16 17 18 19 6
            //15 24 25 20 7
            //14 23 22 21 8
            //13 12 11 10 9
            const int m = 3; // Строки.
            const int n = 6; // Столбцы.
            int[,] matrix = new int[m, n];

            int num = 1;
            int top = 0, bottom = m - 1; // Верхняя и нижния границы матрицы. 
            int left = 0, right = n - 1; // Левая и нижняя границы матрицы.

            while (num <= m * n) // Очеред.элемент не больше больше общего кол.
            {
                for (int i = left; i <= right && num <= m * n; i++) // Верхняя строка - (0,0)->(0,n-1).
                {
                    matrix[top, i] = num;
                    num++;
                }
                top++; // Переход на строку вниз - новая верхняя граница.

                for (int i = top; i <= bottom && num <= m * n; i++) // Крайний правый столбец - (1,n-1)->(m-1,n-1).
                {
                    matrix[i, right] = num;
                    num++;
                }
                right--; // Сдвиг вертикальной границы влево.

                for (int i = right; i >= left && num <= m * n; i--) // Нижняя краница - (m-1,n-1)->(m-1,0).
                {
                    matrix[bottom, i] = num;
                    num++;
                }
                bottom--; // Сдвиг нижней границы вверх.

                for (int i = bottom; i >= top && num <= m * n; i--) // Крайний левый столбец - (m-1,0)->(m-1+,0).
                {
                    matrix[i, left] = num;
                    num++;
                }
                left++;
            }
            Console.WriteLine($"Матрица {m}x{n}:");

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
