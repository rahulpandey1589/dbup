using DbUp;

namespace db_up.Data
{
    public class DatabaseIntializer
    {
        private readonly string _connectionString;

        public DatabaseIntializer(string connectionString)
        {
            _connectionString = connectionString;

        }


        public void  IntializeDbAsync()
        {
            EnsureDatabase.For.SqlDatabase(_connectionString);

            var upgrader = DeployChanges.To.SqlDatabase(_connectionString)
                .WithScriptsAndCodeEmbeddedInAssembly(typeof(DatabaseIntializer).Assembly)
                .LogToConsole()
                .Build();


            if (upgrader.IsUpgradeRequired())
            {
                var result = upgrader.PerformUpgrade();
            }
        }

    }
}
