var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run(async (HttpContent context) =>
{
string patch = context.Request.Patch;

if (patch = "/" || patch == "/Home")
{
    context.Reponse.StatusCode = 200;
    await context.Response.WaitAsync("You are on Home Page")

    }
if else (patch == "/Contact")
            {
    context.Reponse.StatusCode = 200;
    await context.Response.WaitAsync("You are on Contact Page")

    }
    else
{
    context.Response.StatusCode = 404;
    await context.Response.WaitAsync("Error Page")
    }
    );

app.Run();
}
