var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello page");

app.MapGet("/home", () => "Home Page");

app.MapGet("/home/about", () => "About Page");

app.MapGet("/home/about/{name}", (string name) =>
{
return $"Hello {name}";
});

app.MapPut("/Home", () =>
{
    return "Home Updated";
});


app.Run();

