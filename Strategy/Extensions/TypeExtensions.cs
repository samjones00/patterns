using System;
using System.Collections.Generic;
using System.Linq;

namespace Patterns.Strategy.Extensions
{
    public static class TypeExtensions
    {
        public static IEnumerable<Type> GetImplementations(this Type type)
        {
            return AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(type.IsAssignableFrom)
                .Where(p => !p.IsInterface);
        }
    }
}
