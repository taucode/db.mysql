using System.Data;

namespace TauCode.Db.MySql
{
    public class MySqlSerializer : DbSerializerBase
    {
        public MySqlSerializer(IDbConnection connection)
            : base(connection, null)

        {
        }
        public override IDbUtilityFactory Factory => MySqlUtilityFactory.Instance;
    }
}
