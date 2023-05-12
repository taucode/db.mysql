namespace TauCode.Db.MySql;

public static class MySqlExtensions
{
    public static void DropSchema(this MySqlExplorer explorer, string schemaName, bool forceDropSchemaTables = false)
    {
        if (forceDropSchemaTables)
        {
            var tableNames = explorer.GetTableNames(schemaName);
            if (tableNames.Any())
            {
                throw new NotImplementedException();
            }
        }

        explorer.GetOpenConnection().ExecuteSql(@$"DROP SCHEMA {schemaName}");
    }

    public static void ProcessJson(this MySqlInstructionProcessor processor, string json)
    {
        // todo checks

        var instructionReader = new JsonInstructionReader();
        using var jsonTextReader = new StringReader(json);

        var instructions = instructionReader.ReadInstructions(jsonTextReader);

        processor.Process(instructions);
    }
}
