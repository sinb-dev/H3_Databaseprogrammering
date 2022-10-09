namespace Basic_ORM {
    class GroupView : UI
    {
        public static void Print() 
        {
            ConsoleKey key = ConsoleKey.A;
            while (key != ConsoleKey.Escape)
            {
                Console.Clear();
                Console.WriteLine("1. Show groups");
                Console.WriteLine("2. Create group");
                Console.WriteLine("3. Edit group");
                Console.WriteLine("4. Delete group");
                key = Console.ReadKey().Key;
                switch (key) {
                    case ConsoleKey.D1:
                        GroupView.List();
                        break;
                    case ConsoleKey.D2:
                        GroupView.Add();
                        break;
                    case ConsoleKey.D3:
                        GroupView.Edit();
                        break;
                    case ConsoleKey.D4:
                        GroupView.Delete();
                        break;

                }
            }
        }
        public static void List() 
        {
            throw new NotImplementedException();
        }

        public static void Edit()
        {
            throw new NotImplementedException();
        }

        public static void Delete()
        {
            throw new NotImplementedException();
        }   

        public static void Add()
        {
            throw new NotImplementedException();
        }
    }


}