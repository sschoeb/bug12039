using Cirrious.MvvmCross.Plugins.Sqlite;

namespace Bug.Core
{
    public class DemoModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
