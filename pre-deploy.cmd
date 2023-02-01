dotnet restore

dotnet build TauCode.Db.MySql.sln -c Debug
dotnet build TauCode.Db.MySql.sln -c Release

dotnet test TauCode.Db.MySql.sln -c Debug
dotnet test TauCode.Db.MySql.sln -c Release

nuget pack nuget\TauCode.Db.MySql.nuspec