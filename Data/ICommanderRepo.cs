using System.Collections.Generic;
using WebApplication.Models;

namespace WebApplication.Data
{
    public interface ICommanderRepo
    {
        bool SaveChanges();
        
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);

        void CreateCommand(Command command);
        void UpdateCommand(Command command);
    }
}