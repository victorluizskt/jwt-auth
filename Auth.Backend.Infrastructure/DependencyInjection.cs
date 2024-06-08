using Auth.Backend.Business.AuthBusiness;
using Auth.Backend.Model.Interface.IAuthBusiness;
using Auth.Backend.Model.Interface.IAuthRepository;
using Auth.Backend.Repository.AuthRepository;
using Microsoft.Extensions.DependencyInjection;

namespace Auth.Backend.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection Injection(IServiceCollection serviceProvider)
        {
            serviceProvider.AddScoped<IAuthBusiness, AuthBusiness>();
            serviceProvider.AddScoped<IAuthRepository, AuthRepository>();

            return serviceProvider;
        }
    }
}
