namespace Basic_ORM
{
    class Group
    {
        public int Id {get; private set;}
        public string Groupname {get; set;}

        public static List<Group> Select(string where) 
        {
            List<Group> result = new();
            return result;
        }
    }
}