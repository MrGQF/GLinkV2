using NUnit.Framework;

namespace Glink.Runtime.UnitTests
{
    // 代理模式、动态代理、中介者模式
    // 简单工厂、抽象工厂、生产消费模式
    // 单例模式
    // 适配器模式
    [TestFixture]
    public class ProxyTests
    {
        [Test]
        public void ProxyTest()
        {
            var command = new Command();
            var proxy = new Proxy(command);
            proxy.Print("test");
        }
    }

    public interface ICommand
    {
        void Print(string message);
    }

    public class Command : ICommand
    {
        public virtual void Print(string message)
        {
            Console.WriteLine($"Command:{message}");
        }
    }

    public class Proxy : ICommand
    {
        private readonly ICommand command;

        public Proxy(ICommand command)
        {
            this.command = command;
        }

        public void Print(string message) 
        {
            Console.WriteLine("before print");
            command.Print(message);
            Console.WriteLine("after print");
        }
    }
}
