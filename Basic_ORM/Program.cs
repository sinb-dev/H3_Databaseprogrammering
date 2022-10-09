using Basic_ORM;
const string SQLITE_DB = "users.db";

Database.Instance.SetFilename(SQLITE_DB);

ConsoleKey key = ConsoleKey.A;
while (key != ConsoleKey.Escape)
{
    Console.Clear();
    Console.WriteLine("1. Brugere");
    Console.WriteLine("2. Grupper");
    key = Console.ReadKey().Key;
    switch (key) {
        case ConsoleKey.D1:
            UserView.Print();
            break;
        case ConsoleKey.D2:
            GroupView.Print();
            break;

    }
}