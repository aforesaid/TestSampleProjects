using System;
using Microsoft.Extensions.DependencyInjection;

namespace TestDependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {

            var services = new ServiceCollection();
            services.AddScoped<IService, ServiceA>();
            services.AddScoped<IService, ServiceB>();

            var serviceProvider = services.BuildServiceProvider();
            var iServices = serviceProvider.GetServices<IService>();
        }
    }
}