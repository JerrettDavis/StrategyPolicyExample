using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using StrategyPolicyExample.Business.Passwords;
using StrategyPolicyExample.Tests.Business.Policies;
using Xunit;

namespace StrategyPolicyExample.Tests.Business.Passwords
{
    public class PasswordPolicyProviderTests
    {
        [Fact]
        public void GetPolicyTest_ShouldSucceed()
        {
            var provider = PolicyServiceProviderFixture.GetServices().GetService<IPasswordPolicyProvider>();
            var result = provider.GetPolicies();

            Assert.NotNull(result);
            Assert.True(result.Any());
        }
    }
}
