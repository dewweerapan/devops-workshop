var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Welcome to Dew Minimal API!");
app.MapGet("/hello/{name}", (string name) => $"Hello, {name}!");
app.MapGet("/person", () => new { Name = "Weerapan Thairak", Age = 31 });

app.Run();
