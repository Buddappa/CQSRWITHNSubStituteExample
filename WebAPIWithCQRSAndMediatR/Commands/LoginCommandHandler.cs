using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace WebAPIWithCQRSAndMediatR.Commands
{
    public class LoginCommandHandler : IRequestHandler<LoginCommand, LoginCommandResult>
    {
        public readonly HttpClient client;

        public LoginCommandHandler(HttpClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Login Command Handle.
        /// </summary>
        /// <param name="loginCommand">loginCommand</param>
        /// <param name="token">token</param>
        /// <returns></returns>
        public async Task<LoginCommandResult> Handle(LoginCommand loginCommand, CancellationToken token)
        {
            var resullt = await this.client.GetAsync("api/Values");
            var resultString = resullt.Content.ReadAsStringAsync();
            return new LoginCommandResult();
        }
    }
}
