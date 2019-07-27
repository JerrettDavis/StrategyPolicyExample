using System;

namespace StrategyPolicyExample.Business.Policies.Factories
{
    public class NumbersPolicyFactory : IPolicyFactory
    {
        public bool AppliesTo(Type type)
        {
            return typeof(NumbersPolicy) == type;
        }

        public IPolicy Create(PolicyArgs args)
        {
            return new NumbersPolicy(args);
        }
    }
}
