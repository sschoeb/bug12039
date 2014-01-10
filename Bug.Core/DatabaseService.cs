using System.Collections.Generic;
using System.Linq;
using Cirrious.MvvmCross.Plugins.Sqlite;

namespace Bug.Core
{
    public class DatabaseService
    {
        private readonly ISQLiteConnectionFactory _connectionFactory;

        public DatabaseService(ISQLiteConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
            using (var connection = connectionFactory.Create("db"))
            {
                connection.CreateTable<DemoModel>();
            }
        }

        public List<T> GetAll<T>() where T : new() 
        {
            using (var connection = _connectionFactory.Create("db"))
            {
                return connection.Table<T>().Where(x => x.ToString().Length > 0).ToList();
            }
        }
    }
}
