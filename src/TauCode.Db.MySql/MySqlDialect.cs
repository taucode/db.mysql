namespace TauCode.Db.MySql;

public class MySqlDialect : Dialect
{
    public override IUtilityFactory Factory => MySqlUtilityFactory.Instance;
    public override string Name => "SQL Server";

    public override string Undelimit(string identifier)
    {
        // todo temp!

        return identifier.Replace("[", "").Replace("]", "");
    }
}
