var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Run(async (HttpContext context) =>
{
    string path = context.Request.Path;

    if (path == "/" || path == "/Home")
    {
        context.Response.StatusCode = 200;
        await context.Response.WriteAsync("You are on Home Page");

    }
    else if (path == "/Contact")
    {
        context.Response.StatusCode = 200;
        await context.Response.WriteAsync("You are on Contact Page");

    }
    else
    {
        context.Response.StatusCode = 404;
        await context.Response.WriteAsync("Error Page");
    }
}
    );

app.Run();
