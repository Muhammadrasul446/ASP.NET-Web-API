using System.Collections.Generic;
using System.Linq;
using WebApplication.Controllers;
using WebApplication.Models;

namespace WebApplication.Data
{
    public class SqlCommanderRepo : ICommanderRepo
    {
        private readonly CommandContext _context;

        public SqlCommanderRepo(CommandContext context)
        {
            _context = context;
        }
        
        public IEnumerable<Command> GetAllCommands()
        {
            return _context.Commands.ToList();
        }

        public Command GetCommandsById(int id)
        {
            return _context.Commands.FirstOrDefault(p => p.Id == id);
        }
    }
}