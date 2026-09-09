var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapGet("/Home", (context) =>
    {
        context.Response.WriteAsync("This is Home Page....");
     });        
});

//app.Map("/Home", () => "Hello World!");
//app.MapGet("/Home", () => "Hellor World! - GET");
//app.MapPost("/Home", () => "Hellor World! - POST");
//app.MapPut("/Home", () => "Hellor World! - PUT");
//app.MapDelete("/Home", () => "Hellor World! - DELETE");


app.Run();
     