// Разработайте программу для управления списком игроков команды, используя стандартные методы класса List<T>.
// Требования:
//  Создайте список для хранения фамилий игроков(тип string).
//  Реализуйте следующие операции:
//   Добавление игроков "Иванов", "Петров", "Сидоров" методом Add.
//   Вставка игрока "Козлов" на позицию с индексом 1 методом Insert.
//   Проверка наличия игрока "Петров" в команде методом Contains.
//   Удаление игрока "Сидоров" методом Remove.
//   Поиск индекса игрока "Козлов" методом IndexOf.
//   Сортировка списка по алфавиту методом Sort.
//   Выведите текущий состав команды в формате:
//     1. Иванов
//     2. Козлов
//     3. Петров
//   Проверьте, пуст ли список (свойство Count), и очистите его методом Clear.

namespace Theme14_Task01
{
    internal class Program
    {
        static void Main()
        {
            List<string> team = new List<string>();

            team.Add("Иванов");
            team.Add("Петров");
            team.Add("Сидоров");

            team.Insert(1, "Козлов");

            bool isPetrov = team.Contains("Петров");
            Console.WriteLine($"Есть ли игрок \"Петров\" в команде? => {isPetrov}.");

            team.Remove("Сидоров");

            int playerKozlov = team.IndexOf("Козлов");
            Console.WriteLine($"\nИндекс игрока \"Козлов\": {playerKozlov}.");

            team.Sort();

            Console.WriteLine("\nТекущий состав команды:");
            for (int i = 0; i < team.Count; i++)
                Console.WriteLine($"  {i + 1}. {team[i]}.");

            bool isTeamEmpty = team.Count == 0;
            Console.WriteLine($"\nКоманда пуста? => {isTeamEmpty}.");

            team.Clear();

            // Выводим количество игроков после очистки
            Console.WriteLine($"\nКоличество игроков после очистки: {team.Count}.");

            Console.WriteLine("\nНажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
