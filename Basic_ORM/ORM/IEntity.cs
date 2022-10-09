namespace Basic_ORM
{
    interface IEntity
    {
        
        public int Id {get;}

        public string Table {get;}

        /// <summary>
        /// Saves the object to the database using ORM class
        /// </summary>
        public void Save();

        /// <summary>
        /// Attempts to remove current entity from the database
        /// </summary>
        public void Delete();

        /// <summary>
        /// Gets a resultset of records from the database using the where clause
        /// </summary>
        /// <param name="where"></param>
        /// <returns>result set of records</returns>
        public List<IEntity> Select(string where);

        /// <summary>
        /// Generates and runs the schema for this entitys table
        /// </summary>
        public void Create();

        /// <summary>
        /// Drops the table schema from the database
        /// </summary>
        public void Drop();
        
    }
}