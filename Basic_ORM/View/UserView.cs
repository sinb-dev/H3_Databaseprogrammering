namespace Basic_ORM {
    class UserView : UI
    {
        public static void Print() 
        {
            ConsoleKey key = ConsoleKey.A;
            while (key != ConsoleKey.Escape)
            {
                Console.Clear();
                Console.WriteLine("1. Show users");
                Console.WriteLine("2. Create user");
                Console.WriteLine("3. Edit user");
                Console.WriteLine("4. Delete user");
                key = Console.ReadKey().Key;
                switch (key) {
                    case ConsoleKey.D1:
                        UserView.List();
                        break;
                    case ConsoleKey.D2:
                        UserView.Add();
                        break;
                    case ConsoleKey.D3:
                        UserView.Edit();
                        break;
                    case ConsoleKey.D4:
                        UserView.Delete();
                        break;

                }
            }
        }
        public static void List() 
        {
            Console.Clear();
            var list = (new User()).Select("id = 1");
            foreach (User u in list)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", u.Id, u.Username, u.Password, u.Created.ToString("yy-mm-dd HH:MM:ss"));
            }

            Console.ReadKey();
        }

        public static void Edit()
        {
            Console.Clear();
            int id = GetInt("Enter ID of user:");

            var list = (new User()).Select("id = "+id);
            if (list.Count != 1) {
                Console.WriteLine("Unable to find User with ID "+id);
            }
            User u = list[0] as User;

            u.Username = GetText("Username");
            u.Password = GetText("Password");

            u.Save();
        }

        public static void Delete()
        {
            Console.Clear();
            int id = GetInt("Enter ID of user:");

            var list = (new User()).Select("id = "+id);
            if (list.Count != 1) {
                Console.WriteLine("Unable to find User with ID "+id);
            }
            User u = list[0] as User;

            u.Delete();
        }

        public static void Add()
        {
            Console.Clear();
            User u = new User();

            u.Username = GetText("Username");
            u.Password = GetText("Password");

            u.Save();
        }
    }


}