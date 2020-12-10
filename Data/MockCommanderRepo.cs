using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{

    public class MockCommanderRepo : ICommandeRepo
    {
        public IEnumerable<Command> GetAppsCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id=0, HowTo="a", Platform="nanana", Line="dadada"},
                new Command{Id=1, HowTo="b", Platform="nanana", Line="dadada"},
                new Command{Id=2, HowTo="c", Platform="nanana", Line="dadada"},
                new Command{Id=3, HowTo="d", Platform="nanana", Line="dadada"},

            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=0, HowTo="blabla", Platform="nanana", Line="dadada"};
        }
    }
}