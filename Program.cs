var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/doobie", () => "Hello World!");

app.Run();
