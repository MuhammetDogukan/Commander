using Commander.Models;

namespace Commander.Data
{
    public interface IcommanderRepo
    {
        bool SaveChanges();

        IEnumerable<Command> GetAllComands();
        Command GetCommandById(int id);
        void CreateCommand(Command cmd);
    }
}