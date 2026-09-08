var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

//app.Run(async (context) =>
//{
//    await context.Response.WriteAsync("welcom to asp. core 10");
//});

app.Use(async (context,next) =>
{
    await context.Response.WriteAsync("welcom to asp. core 15");
    await next(context);
});

app.Run(async (context) =>
{
    await context.Response.WriteAsync("grishma patel");
});

app.Run();
