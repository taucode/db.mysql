﻿using MySql.Data.MySqlClient;
using NUnit.Framework;

namespace TauCode.Db.MySql.LocalTests
{
    [TestFixture]
    public abstract class TestBase
    {
        protected MySqlConnection Connection { get; set; }

        [SetUp]
        public void SetUpBase()
        {
            using var connection = TestHelper.CreateConnection(null);
            if (!connection.SchemaExists("foo"))
            {
                connection.CreateSchema("foo");
            }

            this.Connection = TestHelper.CreateConnection(TestHelper.ConnectionString);
            this.Connection.PurgeDatabase();
        }

        [TearDown]
        public void TearDownBase()
        {
            this.Connection.Dispose();
            this.Connection = null;
        }
    }
}
