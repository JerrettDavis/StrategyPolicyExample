using System;
using System.Collections.Generic;
using System.Linq;
using StrategyPolicyExample.Business.Policies.Factories;

namespace StrategyPolicyExample.Business.Policies.Strategy
{
    public class PolicyStrategy : IPolicyStrategy
    {
        private readonly IEnumerable<IPolicyFactory> _policyFactories;

        public PolicyStrategy(IEnumerable<IPolicyFactory> policyFactories)
        {
            _policyFactories = policyFactories;
        }

        public IPolicy CreatePolicy(Type type, PolicyArgs args)
        {
            var policyFactory = _policyFactories.FirstOrDefault(n => n.AppliesTo(type));

            if (policyFactory == null)
                throw new Exception($"Type not registered {type.Name}");

            return policyFactory.Create(args);
        }
    }
}
