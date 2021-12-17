using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLocatorDesignPattern.Services
{
    public static class ServiceLocator
    {
        private static readonly Dictionary<Type, object> _registeredServices = new Dictionary<Type, object>();

        public static T GetService<T>()
        {
            return (T) _registeredServices[typeof(T)];
        }

        public static void RegisterService<T>(T service)
        {
            if (service == null)
                throw new ArgumentNullException();

            _registeredServices.Add(typeof(T), service);
        }

        public static int Count
        {
            get { return _registeredServices.Count; }
        }
    }
}
