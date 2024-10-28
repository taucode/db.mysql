using MySql.Data.MySqlClient;

namespace TauCode.Db.MySql;

public class MySqlInstructionProcessor : InstructionProcessor
{
    #region ctor

    public MySqlInstructionProcessor()
    {

    }

    public MySqlInstructionProcessor(MySqlConnection connection)
        : base(connection)
    {

    }

    #endregion

    #region Overridden

    public override IUtilityFactory Factory => MySqlUtilityFactory.Instance;

    #endregion
}