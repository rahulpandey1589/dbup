using DbUp;
namespace db_up.Data;

public class PostgresDbInitializer
{
    private readonly string _connectionString;
    
    public PostgresDbInitializer(string connectionString)
    {
        _connectionString = connectionString;   
    }
    
    public void  InitializeDbAsync()
    {
        EnsureDatabase.For.PostgresqlDatabase(_connectionString);

        var baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
        
        
        var upgrader = DeployChanges.To.PostgresqlDatabase(_connectionString)
            .WithScriptsFromFileSystem(baseDirectory + "/Postgres")
            .LogToConsole()
            .Build();
 

        if (upgrader.IsUpgradeRequired())
        {
            _ = upgrader.PerformUpgrade();
        }
    }

}