namespace Basic_ORM
{
    class User : IEntity
    {
        public int Id {get; private set;}
        public string Table {get; private set;} = "user";
        public string Username {get;set;}
        public string Password {get;set;}
        public DateTime Created {get;set;}
        public DateTime LastSeen {get;set;}

        public List<IEntity> Select(string where) 
        {
            List<IEntity> result = new();
            result.Add(new User {Username = "Konrad Sommer", Password = "VewyHemlig", Created = DateTime.Now, LastSeen = DateTime.MinValue});
            result.Add(new User {Username = "Anne Dam", Password = "Quacky", Created = DateTime.Now, LastSeen = DateTime.MinValue});

            //SQLDataReader reader = Database.Instance.GetReader(....)
            return result;
        }

        public void Create()
        {
            throw new NotImplementedException();
            string sql = @"CREATE TABLE ....(
                
            )
            ";
            Database.Instance.Execute(sql);
        }

        public void Delete()
        {
            throw new NotImplementedException();
            string sql = @"DELETE FROM ....(
                
            )
            ";
            Database.Instance.Execute(sql);
        }

        public void Drop()
        {
            throw new NotImplementedException();
            string sql = @"DROP TABLE ....";
            Database.Instance.Execute(sql);
        }

        public void Save()
        {
            throw new NotImplementedException();
            if (Id == 0)
            {
                string sql = @"INSERT INTO ....";
            } 
            else 
            {
                string sql = @$"UPDATE ... WHERE Id = {Id}";
            }
            
        }
    }
}