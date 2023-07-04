using Commander.Models;

namespace Commander.Data
{
    public interface IcommanderRepo
    {
        IEnumerable<Command> GetAllComands();
        Command GetCommandById(int id);
    }
}