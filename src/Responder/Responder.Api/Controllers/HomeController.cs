using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Responder.Service.Domain;

namespace Responder.Api.Controllers
{
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        private readonly Message _message;

        public HomeController(Message message)
        {
            _message = message;
        }

        // GET api/values
        [HttpGet]
        public string Get()
        {
            return _message.Content;
        }

        // PUT api/values/5
        [HttpPut("{message}")]
        public void Put(string message)
        {
            _message.Content = message;
        }
    }
}
