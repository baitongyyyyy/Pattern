using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

public static class MediaRRegistration
{
    public static IServiceCollection AddMediaR(this IServiceCollection services, Assembly[] assemblies)
    {
        services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssemblies(assemblies);
        });

        services.AddTransient(typeof(IPipelineBehavior<,>));
        return services;
    }
}
