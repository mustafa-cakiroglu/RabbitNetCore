using DotNetCore.CAP;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace RabbitWebProducer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        private readonly ICapPublisher _capPublisher;
        public DefaultController(ICapPublisher capPublisher)
        {
            _capPublisher = capPublisher;
        }

        [HttpGet]
        [ProducesResponseType(204)]
        public async Task<IActionResult> Publisher()
        {
            await _capPublisher.PublishAsync("publisherService", Guid.NewGuid()).ConfigureAwait(false);
            return NoContent();
        }
    }
}