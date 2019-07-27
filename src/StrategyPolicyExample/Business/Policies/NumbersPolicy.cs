﻿using StrategyPolicyExample.Models.Responses;
using System;
using System.Text.RegularExpressions;

namespace StrategyPolicyExample.Business.Policies
{
    public class NumbersPolicy : IPolicy
    {
        private const string _defaultTitle = "NumericCharacterCount";
        private readonly int _minimumLength;
        private readonly string _errorMessage;
        private readonly string _errorTitle;

        public NumbersPolicy(PolicyArgs args)
        {
            if (args == null)
                throw new ArgumentException();

            const string parameterName = "MinimumLength";
            if (!args.AdditionalParameters.ContainsKey(parameterName))
                throw new ArgumentException("Minimum Length is not provided.");

            if (!int.TryParse(args.AdditionalParameters[parameterName].ToString(), out var minimumLength))
                throw new ArgumentException("Minimum Length is invalid.");

            _minimumLength = minimumLength;
            _errorTitle = args.Title ?? _defaultTitle;
            _errorMessage = args.ErrorMessage ?? $"Input does not meet the numeric character count requirement set by the password policy ({_minimumLength})";
        }

        public (bool, ErrorResponse) Verify(string input)
        {
            var enoughUpper = Regex.Matches(input, @"[0-9]").Count >= _minimumLength;
            return !enoughUpper
                ? (false, new ErrorResponse(_errorTitle, _errorMessage))
                : (true, null);
        }
    }
}
