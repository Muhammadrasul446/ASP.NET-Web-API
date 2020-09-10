using System.Collections.Generic;
using WebApplication.Models;

namespace WebApplication.Data
{
    public interface ICommanderRepo
    {
        bool SaveChanges();
        
        IEnumerable<Command> GetAllCommands();
        Command GetCommandsById(int id);

        void CreateCommand(Command command);
    }
}