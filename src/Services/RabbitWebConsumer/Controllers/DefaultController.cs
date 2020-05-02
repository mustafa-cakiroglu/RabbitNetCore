using DotNetCore.CAP;
using Microsoft.AspNetCore.Mvc;
using System;

namespace RabbitWebConsumer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
       
        [HttpGet]
        [CapSubscribe("publisherService")]
        public ActionResult Consumer(Guid guid)
        {
            return Ok(guid);
        }
    }
}