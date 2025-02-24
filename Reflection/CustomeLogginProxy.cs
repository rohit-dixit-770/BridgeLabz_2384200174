using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Week_4_Assignment_6_Reflection
{
    public interface IGreeting
    {
        void SayHello(string name);
    }
    public class Greeting : IGreeting
    {
        public void SayHello(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
    public class LoggingProxy<T> : DispatchProxy
    {
        private T _target;

        public static T Create(T target)
        {
            var proxy = Create<T, LoggingProxy<T>>();
            (proxy as LoggingProxy<T>)._target = target;
            return proxy;
        }

        protected override object Invoke(MethodInfo targetMethod, object[] args)
        {
            Console.WriteLine($"[LOG] Calling method: {targetMethod.Name}");
            return targetMethod.Invoke(_target, args);
        }
    }

    //Act like main class

    class Test
    {
        public void CustomeProxy()
        {
            IGreeting greeting = new Greeting();
            IGreeting proxy = LoggingProxy<IGreeting>.Create(greeting);

            proxy.SayHello("Alice");
        }
    }
}
