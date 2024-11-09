using PollAPI.Repositories;
using PollAPI.Services;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using PollAPI.Contexts;
using PollAPI.Validators;

namespace PollAPI.Extensions;

public static class ServiceExtensions
{
    public static void ConfigureRepositories(this IServiceCollection services)
    {
        services.AddScoped<IPollRepository, PollRepositoryPostgres>();
        services.AddScoped<IVoteRepository, VoteRepositoryPostgres>();
    }

    public static void ConfigureServices(this IServiceCollection services)
    {
        services.AddScoped<IPollService, PollService>();
        services.AddScoped<IVoteService, VoteService>();
    }

    public static void ConfigureAutoMapper(this IServiceCollection services)
    {
        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
    }

    public static void ConfigureValidators(this IServiceCollection services)
    {
        services.AddFluentValidation(config =>
            config.RegisterValidatorsFromAssemblyContaining<PollInputValidator>());
    }

    public static void ConfigureContext(this IServiceCollection services)
    {
        var connectionString = Environment.GetEnvironmentVariable("CONNECTION_STRING");
        services.AddDbContext<PostgresContext>(options => options.UseNpgsql(connectionString));
    }
}