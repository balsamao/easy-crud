using Microsoft.Extensions.DependencyInjection;
using System;

namespace EasyCrud.Infra.Tests
{
    public class DependenceInjectionTest
    {
        public static IServiceProvider Make()
        {
            var provider = new ServiceCollection();
            provider.AddEntityFrameworkInMemoryDatabase();

            return provider.BuildServiceProvider();
        }
    }
}
