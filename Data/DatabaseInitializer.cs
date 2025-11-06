using DbUp;

namespace db_up.Data
{
    public class DatabaseInitializer
    {
        private readonly string _connectionString;

        public DatabaseInitializer(string connectionString)
        {
            _connectionString = connectionString;
        }


        public void  InitializeDbAsync()
        {
            EnsureDatabase.For.SqlDatabase(_connectionString);

            var upgrader = DeployChanges.To.SqlDatabase(_connectionString)
                .WithScriptsAndCodeEmbeddedInAssembly(typeof(DatabaseInitializer).Assembly)
                .LogToConsole()
                .Build();
 

            if (upgrader.IsUpgradeRequired())
            {
                _ = upgrader.PerformUpgrade();
            }
        }

    }
}
