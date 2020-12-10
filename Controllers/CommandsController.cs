using System.Collections.Generic;
using Commander.Models;
using Microsoft.AspNetCore.Mvc;

namespace  Commander.Controllers
{
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {

        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetallCommands()
        {

        }

        //GET api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult <Command> GetCommandById(int id)
        {
            
        }


    }
}