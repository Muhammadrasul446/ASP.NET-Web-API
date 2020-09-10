using System;
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

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public IEnumerable<Command> GetAllCommands()
        {
            return _context.Commands.ToList();
        }

        public Command GetCommandsById(int id)
        {
            return _context.Commands.FirstOrDefault(p => p.Id == id);
        }

        public void CreateCommand(Command command)
        {
            if (command == null)
            {
                throw new ArgumentNullException();
            }

            _context.Commands.Add(command);
        }
    }
}