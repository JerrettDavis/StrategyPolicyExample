using System;

namespace StrategyPolicyExample.Business.Policies.Factories
{
    public class LowerCasePolicyFactory : IPolicyFactory
    {
        public bool AppliesTo(Type type)
        {
            return typeof(LowerCasePolicy) == type;
        }

        public IPolicy Create(PolicyArgs args)
        {
            return new LowerCasePolicy(args);
        }
    }
}
