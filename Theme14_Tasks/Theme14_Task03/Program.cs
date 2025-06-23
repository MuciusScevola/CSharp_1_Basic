// Разработайте систему управления подписчиками, используя HashSet<string> для хранения email-адресов.
// Система должна обеспечивать уникальность подписчиков и поддерживать основные операции с множествами.
// Требования:
//  Создайте HashSet для хранения email-подписчиков с регистронезависимым сравнением.
//  Реализуйте следующий функционал:
//   Добавление новых подписчиков:
//    alice @example.com;
//    bob @example.com;
//    charlie@example.com.
//   Попытку добавления дубликата с выводом результата операции.
//   Проверку наличия подписчиков в системе.
//  Создайте второе множество newSubscribers с подписчиками:
//   bob @example.com (существующий);
//   dave@example.com (новый);
//   eve@example.com (новый).
//  Выполните операции с множествами:
//   Объединение множеств (добавление новых подписчиков).
//   Поиск пересечения (общих подписчиков).
//  Реализуйте:
//   Удаление подписчика.
//   Проверку на подмножество.
//   Очистку всей коллекции.

namespace Theme14_Task03
{
    internal class Program
    {
        static void Main()
        {
            HashSet<string> subscribers = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            subscribers.Add("alice@example.com");
            subscribers.Add("bob@example.com");
            subscribers.Add("charlie@example.com");

            // Для наглядности отслеживания.
            //Console.WriteLine("Подписчики:");
            //foreach (string email in subscribers)
            //    Console.WriteLine($"- {email}");

            bool addedDublicate = subscribers.Add("bob@example.com");
            Console.WriteLine($"Дубликат [alice@example.com] добавлен? => {addedDublicate}.");

            Console.WriteLine($"\nЕсть ли [bob@example.com] в подписчиках? => {subscribers.Contains("bob@example.com")}");
            Console.WriteLine($"Есть ли [dave@example.com] в подписчиках? => {subscribers.Contains("dave@example.com")}");

            HashSet<string> newSubscribers = new HashSet<string>
            {
                "bob@example.com",
                "dave@example.com",
                "eve@example.com"
            };

            // Для наглядности отслеживания.
            //Console.WriteLine("\nНовые подписчики:");
            //foreach (string email in newSubscribers)
            //    Console.WriteLine($"- {email}");

            HashSet<string> united = new HashSet<string>(subscribers, StringComparer.OrdinalIgnoreCase);
            united.UnionWith(newSubscribers);
            Console.WriteLine("\nПодписчики после объединения:");
            foreach (string email in subscribers)
                Console.WriteLine($"- {email}");

            HashSet<string> intersected = new HashSet<string>(subscribers, StringComparer.OrdinalIgnoreCase);
            intersected.IntersectWith(newSubscribers);
            Console.WriteLine("\nОбщие подписчики:");
            foreach (string email in intersected)
                Console.WriteLine($"- {email}");

            Console.WriteLine($"\nУдалили [charlie@example.com]? => {united.Remove("charlie@example.com")}.");
            Console.WriteLine($"Всего подписчиков: {united.Count}.");

            HashSet<string> testSet = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            {
                "bob@example.com",
                "eve@example.com"
            };
            Console.WriteLine($"\ntestSset является подмножеством? {testSet.IsSubsetOf(united)}.");


            united.Clear();
            Console.WriteLine($"\nПодписчиков после очистки: {united.Count}.");

            Console.WriteLine("\nНажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
