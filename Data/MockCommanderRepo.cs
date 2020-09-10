using System.Collections.Generic;
using WebApplication.Models;

namespace WebApplication.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>()
            {
                new Command() {Id = 1, HowTo = "Stash the changes in a git repository", Line = "git stash", Platform = "Terminal"},
                new Command() {Id = 2, HowTo = "Commit local changes", Line = "git commit -m \"Message\"", Platform = "Terminal"},
                new Command() {Id = 3, HowTo = "Update local repository", Line = "git pull", Platform = "Terminal"},
                new Command() {Id = 4, HowTo = "Update remote repository", Line = "git push", Platform = "Terminal"}
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command() {Id = 1, HowTo = "Stash the changes in a git repository", Line = "Stash", Platform = "Terminal"};
        }

        public void CreateCommand(Command command)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command command)
        {
            throw new System.NotImplementedException();
        }
    }
}