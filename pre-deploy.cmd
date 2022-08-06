dotnet restore

dotnet build --configuration Debug
dotnet build --configuration Release

dotnet test -c Debug .\test\TauCode.Db.MySql.Tests\TauCode.Db.MySql.Tests.csproj
dotnet test -c Release .\test\TauCode.Db.MySql.Tests\TauCode.Db.MySql.Tests.csproj

nuget pack nuget\TauCode.Db.MySql.nuspec