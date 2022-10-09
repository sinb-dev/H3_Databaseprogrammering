namespace Basic_ORM
{
    class UI 
    {
        protected static string GetText(string instruction, string defaultValue = "")
        {
            Console.Write($"{instruction}: ");
            string input = Console.ReadLine();
            return input == "" ? defaultValue : input;
        }

        protected static int GetInt(string instruction, int defaultValue = 0)
        {
            Console.Write($"{instruction}: ");

            string input = Console.ReadLine();

            if (input == "") return defaultValue;

            int t = 0;

            int.TryParse(Console.ReadLine(), out t);

            return t;
        }
    }
}