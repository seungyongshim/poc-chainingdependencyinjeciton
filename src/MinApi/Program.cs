//https://dotnetthoughts.net/minimal-api-in-aspnet-core-mvc6/
var host = Host.CreateDefaultBuilder()
               .Build();



var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
