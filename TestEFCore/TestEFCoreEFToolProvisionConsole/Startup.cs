using System;
using Microsoft.Extensions.DependencyInjection;
using TestEFCoreDataAccess.DataAccess;

namespace TestEFCoreEFToolProvisionConsole
{
    public static class Startup
    {
        public static IServiceCollection ConfigureServices()
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddDbContext<PeopleContext>();

            return serviceCollection;
        }
    }
}
