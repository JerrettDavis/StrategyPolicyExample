using Microsoft.Extensions.DependencyInjection;
using StrategyPolicyExample.Business.Passwords;
using StrategyPolicyExample.Business.Policies.Factories;
using StrategyPolicyExample.Business.Policies.Strategy;
using System;

namespace StrategyPolicyExample.Tests.Business.Policies
{
    public static class PolicyServiceProviderFixture
    {
        public static IServiceProvider GetServices()
        {
            var services = new ServiceCollection();

            services.AddTransient<IPolicyFactory, LowerCasePolicyFactory>();
            services.AddTransient<IPolicyFactory, UpperCasePolicyFactory>();
            services.AddTransient<IPolicyFactory, MaximumLengthPolicyFactory>();
            services.AddTransient<IPolicyFactory, MinimumLengthPolicyFactory>();
            services.AddTransient<IPolicyFactory, NumbersPolicyFactory>();
            services.AddTransient<IPolicyFactory, SpecialCharacterPolicyFactory>();
            services.AddTransient<IPolicyStrategy, PolicyStrategy>();
            services.AddTransient<IPasswordPolicyProvider, PasswordPolicyProvider>();

            return services.BuildServiceProvider();
        }
    }
}
