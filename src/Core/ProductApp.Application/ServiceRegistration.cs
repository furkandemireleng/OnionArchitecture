using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace ProductApp.Application;

public static class ServiceRegistration
{

    public static void AddApplicationRegistiration(this IServiceCollection services)
    {

        var asse = Assembly.GetExecutingAssembly();
        services.AddAutoMapper(asse);
        services.AddMediatR(cfg=>cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
        //services.AddMediatR(asse);

    }
    
}