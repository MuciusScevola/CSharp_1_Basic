namespace Theme09_Task02
{
    internal class Program
    {
        static void Main()
        {
            //Создать класс BankAccount, который моделирует банковский счет:
            //Поля:
            //_balance(текущий баланс, private)
            //Статическое поле:
            //_totalAccounts(общее количество созданных счетов, private)
            //Автосвойства:
            //AccountNumber(номер счета, readonly)
            //Balance(public геттер, private сеттер)
            //Конструктор:
            //Увеличивает _totalAccounts и генерирует AccountNumber(например, случайный 4-значный номер).
            //Методы:
            //Deposit(decimal amount) – пополняет баланс.
            //Withdraw(decimal amount) – снимает деньги (если хватает средств, иначе выбрасывает исключение).
            //ShowTotalAccounts() - выводит общее количество созданных счетов.
            var account1 = new BankAccount();
            account1.Deposit(1000);
            account1.Withdraw(500);

            var account2 = new BankAccount();
            account2.Deposit(2000);

            BankAccount.ShowTotalAccount();
            Console.WriteLine($"Счёт #{account1.AccountNumber}: баланс {account1.Balance}.");
            Console.WriteLine($"Счёт #{account2.AccountNumber}: баланс {account2.Balance}.");

            Console.WriteLine("\nНажмите любую клавишу.");
            Console.ReadKey();
        }
        public class BankAccount
        {
            private decimal _balance; // Поле для хранения текущего баланса.
            private static int _totalAccounts = 0; // Поле для подсчёта количества счетов.

            public int AccountNumber { get; } // Номер счёта (только чтение).

            public decimal Balance // Текущий баланс счёта.
            {
                get { return _balance; } // Возвращает значение поля _balance.
                private set { _balance = value; }
            }

            public BankAccount() // Конструктор банковского счёта.
            {
                _totalAccounts++;

                Random rnd = new Random();
                AccountNumber = rnd.Next(1000, 10000); // Генератор номера счёта.

                Balance = 0; // Инициализация баланса.
            }

            public void Deposit(decimal amount) // Пополнения счёта.
            {
                Balance += amount;
            }

            public decimal Withdraw(decimal amount)
            {
                if (amount > Balance) { throw new InvalidOperationException("Недостаточно средств на счёте."); }
                Balance -= amount;
                return Balance;
            }

            public static void ShowTotalAccount()
            {
                Console.WriteLine($"Общее количество открытых счетов: {_totalAccounts}.");
            }
        }
    }
}

