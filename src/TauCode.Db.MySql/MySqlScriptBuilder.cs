namespace TauCode.Db.MySql;

public class MySqlScriptBuilder : ScriptBuilder
{
    #region Overridden

    public override IUtilityFactory Factory => MySqlUtilityFactory.Instance;

    #endregion
}