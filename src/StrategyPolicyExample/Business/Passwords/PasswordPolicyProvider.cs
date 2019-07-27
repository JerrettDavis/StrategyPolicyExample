using System.Collections.Generic;
using System.Threading.Tasks;
using StrategyPolicyExample.Business.Policies;
using StrategyPolicyExample.Business.Policies.Strategy;

namespace StrategyPolicyExample.Business.Passwords
{
    public class PasswordPolicyProvider : IPasswordPolicyProvider
    {
        private readonly IPolicyStrategy _policyStrategy;

        public PasswordPolicyProvider(IPolicyStrategy policyStrategy)
        {
            _policyStrategy = policyStrategy;
        }

        public IPolicy[] GetPolicies()
        {
            return new []
            {
                _policyStrategy.CreatePolicy(typeof(LowerCasePolicy), GetArgs("MinimumLength", 1)),
                _policyStrategy.CreatePolicy(typeof(UpperCasePolicy), GetArgs("MinimumLength", 1)),
                _policyStrategy.CreatePolicy(typeof(NumbersPolicy), GetArgs("MinimumLength", 1)),
                _policyStrategy.CreatePolicy(typeof(SpecialCharacterPolicy), GetArgs("MinimumLength", 1)),
                _policyStrategy.CreatePolicy(typeof(MinimumLengthPolicy), GetArgs("MinimumLength", 8)),
            };
        }

        public Task<IPolicy[]> GetPoliciesAsync()
        {
            return Task.FromResult(GetPolicies());
        }

        private static PolicyArgs GetArgs(string argument, int value)
        {
            return new PolicyArgs(new KeyValuePair<string, object>(argument, value));
        }
    }
}
