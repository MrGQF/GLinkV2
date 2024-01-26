using System.Collections.Concurrent;
using System.Reflection.Emit;
using System.Reflection;
using NUnit.Framework;
using Castle.DynamicProxy;

namespace Glink.Runtime.UnitTests
{
    [TestFixture]
    internal class DynamicProxyTests
    {
        private readonly ProxyGenerator generator = new ProxyGenerator();

        [Test]
        public void DynamicProxyTest()
        {
            var interceptor = new Interceptor();
            var proxy = generator.CreateClassProxy<Command>(interceptor);
            proxy.Print("test");
        }
    }

    internal class Interceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            Console.WriteLine("before print");
            invocation.Proceed();
            Console.WriteLine("after print");
        }
    }
}
