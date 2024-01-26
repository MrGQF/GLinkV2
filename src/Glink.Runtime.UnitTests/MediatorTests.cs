using MediatR;
using NUnit.Framework;

namespace Glink.Runtime.UnitTests
{
    [TestFixture]
    internal class MediatorTests
    {
        private readonly Mediator mediator = new Mediator();

        [Test]
        public void MediatorTest()
        {

        }
    }

    public class Request : IRequest<string>
    {
        public string Data { get; set; }
    }

    public class RequestHandler : IRequestHandler<Request, string>
    {
        public Task<string> Handle(Request request, CancellationToken cancellationToken)
        {
            return Task.FromResult(request.Data);
        }
    }
}
