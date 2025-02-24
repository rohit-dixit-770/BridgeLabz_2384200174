using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Week_4_Assignment_6_Annotion
{
    public class CacheResultAttribute : Attribute { }

    public class CacheHelper
    {
        private static readonly Dictionary<string, object> _cache = new();

        public static object InvokeWithCache(object obj, MethodInfo method, object[] args)
        {
            string key = $"{method.Name}-{string.Join(",", args)}";

            if (_cache.TryGetValue(key, out var cachedValue))
            {
                Console.WriteLine("Returning cached result.");
                return cachedValue;
            }

            var result = method.Invoke(obj, args);
            _cache[key] = result;
            return result;
        }
    }

    public class ExpensiveCalculator
    {
        [CacheResult]
        public int Compute(int x, int y)
        {
            Console.WriteLine("Computing...");
            return x * y; // Simulate expensive computation
        }
    }
}
