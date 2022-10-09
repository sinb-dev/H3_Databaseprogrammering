using System.Data.SQLite;

namespace Basic_ORM
{
    class Database
    {
        string connectionString = "";
        public static Database Instance {get; private set;}
        static Database()
        {
            Instance = new Database();
        }
        
        SQLiteConnection getConnection() 
        {
            if (connectionString == "") 
            {
                throw new Exception("Missing database filename. Use SetFilename to set one");
            }
            var connection = new SQLiteConnection(connectionString);
            try
            {
                connection.Open();
                return connection;
            }
            catch(SQLiteException e)
            {
                Console.WriteLine($"Unable to connect to {connectionString}: {e}");
            }
            return null;
            
        }
        /// <summary>
        /// Sets the database file name
        /// </summary>
        /// <param name="filename"></param>
        /// <returns>true if success, false if unable to open the database</returns>
        public bool SetFilename(string filename)
        {
            connectionString = $"Data Source={filename}";
            try 
            {
                using(var test = getConnection())
                {
                    return true;
                }
            }
            catch (NullReferenceException)
            {
                Console.WriteLine($"Unable to open {filename}, check persmissions");
                return false;
            }
            
        }

        public int Execute(string sql) 
        {
            using (var connection = getConnection())
            {
                var command = connection.CreateCommand();
                command.CommandText = sql;
                return command.ExecuteNonQuery();
            }
        }
        public SQLiteDataReader GetReader(string sql) 
        {
            using (var connection = getConnection())
            {
                var command = connection.CreateCommand();
                command.CommandText = sql;
                return command.ExecuteReader();
            };
        }
        public bool TableExists(IEntity entity) {
            var reader = GetReader($"SELECT name FROM sqlite_master WHERE type='table' AND name='{entity.Table}'");
            return reader.Read();
        }
    }
}