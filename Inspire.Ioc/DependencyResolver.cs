using System.Diagnostics.CodeAnalysis;
using Inspire.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Inspire.Ioc
{
    [ExcludeFromCodeCoverage(Justification = "dependency injection")]
    public static class DependencyResolver
    {
        public static void ResolveDependencies(IServiceCollection services)
        {
            services.AddSingleton<IInspireService, InspireService>();
        }
    }
}