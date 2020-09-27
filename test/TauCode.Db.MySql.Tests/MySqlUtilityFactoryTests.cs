﻿using MySql.Data.MySqlClient;
using NUnit.Framework;
using System.Data;

namespace TauCode.Db.MySql.Tests
{
    [TestFixture]
    public class MySqlUtilityFactoryTests
    {
        [Test]
        public void Members_DifferentArguments_HaveExpectedProps()
        {
            // Arrange
            IDbUtilityFactory utilityFactory = MySqlUtilityFactory.Instance;

            // Act
            IDbConnection connection = new MySqlConnection();
            connection.ConnectionString = TestHelper.ConnectionString;
            connection.Open();

            IDbDialect dialect = utilityFactory.GetDialect();

            IDbScriptBuilder scriptBuilder = utilityFactory.CreateScriptBuilder(null);

            IDbInspector dbInspector = utilityFactory.CreateDbInspector(connection, null);

            IDbTableInspector tableInspector = utilityFactory.CreateTableInspector(connection, null, "language");

            IDbCruder cruder = utilityFactory.CreateCruder(connection, null);

            IDbSerializer dbSerializer = utilityFactory.CreateDbSerializer(connection, null);

            // Assert
            Assert.That(dialect.Name, Is.EqualTo("MySQL"));
            Assert.That(connection, Is.TypeOf<MySqlConnection>());
            Assert.That(dialect, Is.SameAs(MySqlDialect.Instance));

            Assert.That(scriptBuilder, Is.TypeOf<MySqlScriptBuilder>());
            Assert.That(scriptBuilder.CurrentOpeningIdentifierDelimiter, Is.EqualTo('`'));

            Assert.That(dbInspector, Is.TypeOf<MySqlInspector>());
            Assert.That(tableInspector, Is.TypeOf<MySqlTableInspector>());
            Assert.That(cruder, Is.TypeOf<MySqlCruder>());
            Assert.That(dbSerializer, Is.TypeOf<MySqlSerializer>());
        }
    }
}
