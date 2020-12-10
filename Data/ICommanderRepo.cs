using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{

    public interface ICommandeRepo
    {
        IEnumerable<Command> GetAppsCommands();
        Command GetCommandById(int id);
    }
}