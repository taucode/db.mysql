using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace TauCode.Db.MySql
{
    // todo: check schemaName arg is null
    public class MySqlUtilityFactory : IDbUtilityFactory
    {
        public static MySqlUtilityFactory Instance { get; } = new MySqlUtilityFactory();

        private MySqlUtilityFactory()
        {
        }

        public IDbDialect GetDialect() => MySqlDialect.Instance;

        public IDbScriptBuilder CreateScriptBuilder(string schemaName)
        {
            if (schemaName != null)
            {
                throw new ArgumentException($"'{nameof(schemaName)}' must be null.", nameof(schemaName));
            }

            return new MySqlScriptBuilder();
        }

        public IDbConnection CreateConnection() => new MySqlConnection();

        public IDbInspector CreateInspector(IDbConnection connection, string schemaName) => new MySqlInspector(connection);

        public IDbTableInspector CreateTableInspector(IDbConnection connection, string schemaName, string tableName) =>
            new MySqlTableInspector(connection, tableName);

        public IDbCruder CreateCruder(IDbConnection connection, string schemaName) => new MySqlCruder(connection);

        public IDbSerializer CreateSerializer(IDbConnection connection, string schemaName) => new MySqlSerializer(connection);
    }
}
