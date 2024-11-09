using dotenv.net;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using PollAPI.Contexts;
using PollAPI.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

DotEnv.Load();

builder.Services.ConfigureContext();

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Poll API",
        Description = "An ASP.NET Core Web API for view, create, and vote on polls"
    });
});

builder.Services.ConfigureAutoMapper();
builder.Services.ConfigureRepositories();
builder.Services.ConfigureServices();
builder.Services.ConfigureValidators();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options => 
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        options.RoutePrefix = string.Empty;
    });
}

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<PostgresContext>();
    context.Database.Migrate();
}

app.MapControllers();
app.UseHttpsRedirection();

app.Run();
