namespace WebAPIWithCQRSAndMediatR.Controllers
{
    using MediatR;
    using Microsoft.AspNetCore.Mvc;
    using WebAPIWithCQRSAndMediatR.Commands;

    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        /// <summary>
        /// interface IMediator
        /// </summary>
        public IMediator mediator;

        /// <summary>
        /// ValuesController.
        /// </summary>
        /// <param name="mediator"></param>
        public ValuesController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<LoginCommandResult> Get()
        {
            LoginCommand loginCommand = new LoginCommand();
            var result=  mediator.Send(loginCommand);
            return result.Result;
        }
    }
}
