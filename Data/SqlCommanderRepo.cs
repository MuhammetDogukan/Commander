using Commander.Models;

namespace Commander.Data
{
    public class SqlCommanderRepo : IcommanderRepo
    {
        private readonly CommanderContext _context;

        public SqlCommanderRepo(CommanderContext context)
        {
            _context=context;
        }
        public IEnumerable<Command> GetAllComands()
        {
            return _context.Commands.ToList();
        }

        public Command GetCommandById(int id)
        {
            return _context.Commands.FirstOrDefault(p=> p.Id == id);
        }
    }
}