using Microsoft.Extensions.DependencyInjection;
using StrategyPolicyExample.Business.Passwords;
using StrategyPolicyExample.Tests.Business.Policies;
using Xunit;

namespace StrategyPolicyExample.Tests.Business.Passwords
{
    public class PasswordPolicyVerifierTests
    {
        private readonly IPasswordPolicyVerifier _verifier;

        public PasswordPolicyVerifierTests()
        {
            var provider = PolicyServiceProviderFixture.GetServices().GetService<IPasswordPolicyProvider>();
            _verifier = new PasswordPolicyVerifier(provider);
        }
        [Fact]
        public void VerifyTest_ShouldSucceed()
        {
            const string testPassword = "@Test12345";
            var result = _verifier.Verify(testPassword);

            Assert.True(result.IsValid);
        }

        [Fact]
        public void VerifyTest_TooShort_ShouldFail()
        {
            const string testPassword = "@Te1";
            var result = _verifier.Verify(testPassword);

            Assert.False(result.IsValid);
            Assert.Single(result.Errors);
        }

        [Fact]
        public void VerifyTest_NoUpper_ShouldFail()
        {
            const string testPassword = "@test12345";
            var result = _verifier.Verify(testPassword);

            Assert.False(result.IsValid);
            Assert.Single(result.Errors);
        }

        [Fact]
        public void VerifyTest_NoLower_ShouldFail()
        {
            const string testPassword = "@TEST12345";
            var result = _verifier.Verify(testPassword);

            Assert.False(result.IsValid);
            Assert.Single(result.Errors);
        }

        [Fact]
        public void VerifyTest_NoSpecial_ShouldFail()
        {
            const string testPassword = "Test12345";
            var result = _verifier.Verify(testPassword);

            Assert.False(result.IsValid);
            Assert.Single(result.Errors);
        }
    }
}
