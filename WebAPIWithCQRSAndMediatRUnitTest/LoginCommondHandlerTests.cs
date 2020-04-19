using NSubstitute;
using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using WebAPIWithCQRSAndMediatR.Commands;
using Xunit;

namespace WebAPIWithCQRSAndMediatRUnitTest
{
   public class LoginCommondHandlerTests
    {
        [Fact]
        public async Task LoginCommandHandler_ShouldReturn_LoginCommandResult()
        {
           // var mockIHttpClientFactory = Substitute.For<IHttpClientFactory>();
            var messageHandler = new MockHttpMessageHandler("As per our requirement we mock string!", HttpStatusCode.OK);
            var httpClient = new HttpClient(messageHandler);
            httpClient.BaseAddress = new Uri("https://www.google.com");
            var handler = new LoginCommandHandler(httpClient);
            var result = await handler.Handle(new LoginCommand(), new CancellationToken());

            Assert.NotNull(result);

        }
    }
}
