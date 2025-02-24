using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Week_4_Assignment_6_Reflection
{
    [AttributeUsage(AttributeTargets.Constructor)]
    public class InjectAttribute : Attribute { }
    public class DIContainer
    {
        private readonly Dictionary<Type, Type> types = new();

        public void Register<TInterface, TImplementation>()
            where TImplementation : TInterface
        {
            types[typeof(TInterface)] = typeof(TImplementation);
        }
        public T Resolve<T>() => (T)Resolve(typeof(T));

        private object Resolve(Type type)
        {
            if (!types.ContainsKey(type) && !type.IsInterface)
                return Activator.CreateInstance(type);

            Type implementation = types[type];
            ConstructorInfo constructor = implementation.GetConstructors()
                .FirstOrDefault(c => c.GetCustomAttribute<InjectAttribute>() != null)
                ?? implementation.GetConstructors().First();

            object[] parameters = constructor.GetParameters()
                .Select(p => Resolve(p.ParameterType))
                .ToArray();

            return Activator.CreateInstance(implementation, parameters);
        }
    }
  
    public interface IService { void Execute(); }

    public class ServiceA : IService
    {
        public void Execute() => Console.WriteLine("ServiceA executed");
    }
    public class Consumer
    {
        private readonly IService _service;

        [Inject]
        public Consumer(IService service) => _service = service;

        public void Run() => _service.Execute();
    }


    //act like main class
    class InjectionDependency
    {
        public void DependencyInject()
        {
            DIContainer container = new();
            container.Register<IService, ServiceA>();

            Consumer consumer = container.Resolve<Consumer>();
            consumer.Run();
        }
    }

}
