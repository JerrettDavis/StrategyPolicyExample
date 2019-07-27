using System;

namespace StrategyPolicyExample.Business.Policies.Strategy
{
    public interface IPolicyStrategy
    {
        IPolicy CreatePolicy(Type type, PolicyArgs args);
    }
}