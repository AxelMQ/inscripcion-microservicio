using System;

namespace Domain.Exceptions
{
    public class BusinessRuleException : Exception
    {
        public string RuleName { get; }

        public BusinessRuleException(string ruleName, string message) : base(message)
        {
            RuleName = ruleName;
        }

        public BusinessRuleException(string ruleName, string message, Exception innerException) 
            : base(message, innerException)
        {
            RuleName = ruleName;
        }
    }
}

