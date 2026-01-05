using Form.Ambulancias247.Core.Facade;
using Form.Ambulancias247.Core.Interfaces;
using Form.Ambulancias247.Core.Services;

namespace Form.Ambulancias247.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<IGeneratePdfFacade, GeneratePdfFacade>();
        services.AddScoped<IGeneratePdfService, GeneratePdfService>();

        return services;
    }
}
