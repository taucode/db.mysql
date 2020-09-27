﻿namespace TauCode.Db.MySql
{
    [DbDialect(
        typeof(MySqlDialect),
        "reserved-words.txt",
        "``")]
    public class MySqlDialect : DbDialectBase
    {
        #region Static

        public static readonly MySqlDialect Instance = new MySqlDialect();

        #endregion

        #region Constructor

        private MySqlDialect()
            : base(DbProviderNames.MySQL)
        {
        }

        #endregion

        #region Overridden

        public override IDbUtilityFactory Factory => MySqlUtilityFactory.Instance;
        
        public override string UnicodeTextLiteralPrefix => "N";

        public override bool CanDecorateTypeIdentifier => false;

        #endregion
    }
}
