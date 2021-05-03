using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace TestEFCoreEFToolProvisionConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = Startup.ConfigureServices();

            var serviceProvider = services.BuildServiceProvider();
        }
    }
}
