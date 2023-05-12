namespace TauCode.Db.MySql;

// todo regions

public class MySqlUtilityFactory : IUtilityFactory
{
    public static MySqlUtilityFactory Instance { get; } = new();

    private MySqlUtilityFactory()
    {
    }

    public IDialect Dialect { get; } = new MySqlDialect();

    public IScriptBuilder CreateScriptBuilder() => new MySqlScriptBuilder();

    public IExplorer CreateExplorer() => new MySqlExplorer();

    public ICruder CreateCruder() => new MySqlCruder();
}