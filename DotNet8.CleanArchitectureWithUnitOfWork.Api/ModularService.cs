namespace DotNet8.CleanArchitectureWithUnitOfWork.Api;

public static class ModularService
{
    public static IServiceCollection AddFeatures(
        this IServiceCollection services,
        WebApplicationBuilder builder
    )
    {
        services
            .AddDbContextService(builder)
            .AddRepositoryService()
            .AddUnitOfWorkService()
            .AddJsonService();

        return services;
    }

    private static IServiceCollection AddDbContextService(
        this IServiceCollection services,
        WebApplicationBuilder builder
    )
    {
        builder.Services.AddDbContext<AppDbContext>(
            opt =>
            {
                opt.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
                opt.UseSqlServer(builder.Configuration.GetConnectionString("DbConnection"));
            },
            ServiceLifetime.Transient
        );

        return services;
    }

    private static IServiceCollection AddUnitOfWorkService(this IServiceCollection services)
    {
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        return services;
    }

    private static IServiceCollection AddRepositoryService(this IServiceCollection services)
    {
        services
            .AddScoped<IAuthRepository, AuthRepository>()
            .AddScoped<IBlogRepository, BlogRepository>();
        return services;
    }

    private static IServiceCollection AddJsonService(this IServiceCollection services)
    {
        services
            .AddControllers()
            .AddJsonOptions(opt =>
            {
                opt.JsonSerializerOptions.PropertyNamingPolicy = null;
            });
        return services;
    }
}
