using StrategyPolicyExample.Business.Policies;

namespace StrategyPolicyExample.Business.Passwords
{
    public interface IPasswordPolicyProvider
    {
        IPolicy[] GetPolicies();
    }
}