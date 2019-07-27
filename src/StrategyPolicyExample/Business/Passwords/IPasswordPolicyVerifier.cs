using StrategyPolicyExample.Models.Responses;

namespace StrategyPolicyExample.Business.Passwords
{
    public interface IPasswordPolicyVerifier
    {
        IValidationResult Verify(string password);
    }
}