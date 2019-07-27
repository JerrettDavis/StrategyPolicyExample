using System;

namespace StrategyPolicyExample.Business.Policies.Factories
{
    public class UpperCasePolicyFactory: IPolicyFactory
    {
        public bool AppliesTo(Type type)
        {
            return typeof(UpperCasePolicy) == type;
        }

        public IPolicy Create(PolicyArgs args)
        {
            return new UpperCasePolicy(args);
        }
    }
}
