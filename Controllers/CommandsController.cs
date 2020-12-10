using Microsoft.AspNetCore.Mvc;

namespace  Commander.Controllers
{
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        public ActionResult <IEnumerable<Command>> GetallCommands()
        {

        }

        public ActionResult <Command> GetCommandById(int id)
        {
            
        }


    }
}