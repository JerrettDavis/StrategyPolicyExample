using System;

namespace StrategyPolicyExample.Business.Policies.Factories
{
    public class SpecialCharacterPolicyFactory : IPolicyFactory
    {
        public bool AppliesTo(Type type)
        {
            return typeof(SpecialCharacterPolicy) == type;
        }

        public IPolicy Create(PolicyArgs args)
        {
            return new SpecialCharacterPolicy(args);
        }
    }
}
