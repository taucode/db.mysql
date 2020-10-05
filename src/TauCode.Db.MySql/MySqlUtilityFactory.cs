using MySql.Data.MySqlClient;
using System.Data;

namespace TauCode.Db.MySql
{
    // todo: check schema arg is null
    public class MySqlUtilityFactory : IDbUtilityFactory
    {
        public static MySqlUtilityFactory Instance { get; } = new MySqlUtilityFactory();

        private MySqlUtilityFactory()
        {
        }

        public IDbDialect GetDialect() => MySqlDialect.Instance;

        public IDbScriptBuilder CreateScriptBuilder(string schema) => new MySqlScriptBuilder(schema);
        public IDbConnection CreateConnection() => new MySqlConnection();

        public IDbInspector CreateInspector(IDbConnection connection, string schema) => new MySqlInspector(connection);

        public IDbTableInspector CreateTableInspector(IDbConnection connection, string schema, string tableName) =>
            new MySqlTableInspector(connection, tableName);

        public IDbCruder CreateCruder(IDbConnection connection, string schema) => new MySqlCruder(connection);

        public IDbSerializer CreateSerializer(IDbConnection connection, string schema) => new MySqlSerializer(connection);
    }
}
