using StrategyPolicyExample.Models.Responses;

namespace StrategyPolicyExample.Business.Policies
{
    public interface IPolicy
    {
        (bool, ErrorResponse) Verify(string input);
    }
}
