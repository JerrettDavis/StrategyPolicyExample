using System;

namespace StrategyPolicyExample.Business.Policies.Factories
{
    public interface IPolicyFactory
    {
        IPolicy Create(PolicyArgs args);
        bool AppliesTo(Type type);
    }
}
