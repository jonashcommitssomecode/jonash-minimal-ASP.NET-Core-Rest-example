var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/myurl", () => "Hello World!");

app.Run();
