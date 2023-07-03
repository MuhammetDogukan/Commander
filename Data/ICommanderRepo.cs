using Commander.Models;

namespace Commander.Data
{
    public interface IcommanderRepo
    {
        IEnumerable<Command> GetAppComands();
        Command GetCommandById(int id);
    }
}