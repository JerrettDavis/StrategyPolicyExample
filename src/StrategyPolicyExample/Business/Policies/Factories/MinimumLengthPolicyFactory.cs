using System;

namespace StrategyPolicyExample.Business.Policies.Factories
{
    public class MinimumLengthPolicyFactory : IPolicyFactory
    {
        public bool AppliesTo(Type type)
        {
            return typeof(MinimumLengthPolicy) == type;
        }

        public IPolicy Create(PolicyArgs args)
        {
            return new MinimumLengthPolicy(args);
        }
    }
}
