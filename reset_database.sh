dotnet ef database drop -f -v
rm -f Migrations/*
dotnet ef migrations add InitialWithFakeData
dotnet ef database update