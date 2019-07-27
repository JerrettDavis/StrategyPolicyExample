using System.Collections.Generic;

namespace StrategyPolicyExample.Models.Responses
{
    public interface IValidationResult
    {
        bool IsValid { get; }
        IEnumerable<ErrorResponse> Errors { get; }
    }
}
