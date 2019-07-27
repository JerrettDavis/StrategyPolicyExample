using System;

namespace StrategyPolicyExample.Business.Policies.Factories
{
    public class MaximumLengthPolicyFactory : IPolicyFactory
    {
        public bool AppliesTo(Type type)
        {
            return typeof(MaximumLengthPolicy) == type;
        }

        public IPolicy Create(PolicyArgs args)
        {
            return new MaximumLengthPolicy(args);
        }
    }
}
