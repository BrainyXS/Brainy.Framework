using System;
using System.Collections.Generic;
using System.Linq;

namespace Brainy.Framework.Contract.Navigation
{
    public class NavigationContext
    {
        public void AddParam(KeyValuePair<Type, object> keyValuePair)
        {
            _params.Add(keyValuePair);
        }

        private List<KeyValuePair<Type, object>> _params = new List<KeyValuePair<Type, object>>();

        public T OfType<T>()
        {
            return (T) _params.First(p => p.Key == typeof(T)).Value;
        }

        public T[] AllOfType<T>()
        {
            return _params.Where(p => p.Key == typeof(T)).Select(p => (T) p.Value).ToArray();
        }
    }
}