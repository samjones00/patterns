using System;
using System.Collections.Generic;
using System.Linq;
using Patterns.Strategy.Extensions;
using Patterns.Strategy.Interfaces;
using Patterns.Strategy.Models;
using Patterns.Strategy.Validators;

namespace Patterns.Strategy
{
    public class ValidatorService
    {
        public bool IsValid(string password)
        {
            var options = new ValidatorOptions(minimumLength: 5, maximumLength: 10);

            var implementations = new List<Type>
            {
                typeof(MinimumLengthValidator),
                typeof(MaximumLengthValidator),
                typeof(IsNotEmptyValidator),
                typeof(ContainsCapitalLetterValidator)
            };

            // getting implementations from the assemblies works too
            var assemblyImplementations = typeof(IValidator).GetImplementations();

            var validators = implementations
                .Select(implementation => (IValidator) Activator.CreateInstance(implementation, options));

            return validators
                .Where(validator => validator != null)
                .Select(validator => validator.IsValid(password))
                .All(isValid => isValid);
        }
    }
}
