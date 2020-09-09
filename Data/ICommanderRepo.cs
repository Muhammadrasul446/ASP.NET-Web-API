using System.Collections.Generic;
using WebApplication.Models;

namespace WebApplication.Data
{
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetAllCommands();
        Command GetCommandsById(int id);
    }
}