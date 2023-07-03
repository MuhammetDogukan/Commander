using Commander.Models;
using Commander.Data;

namespace Comander.Data
{
    class MockCommanderRepo : IcommanderRepo
    {
        public IEnumerable<Command> GetAppComands()
        {
             var commands = new List<Command>
            {
                new Command{Id=0, HowTo="Boil an egg", Line="Boil water", Platform="Kettle & Pan"},
                new Command{Id=1, HowTo="Cut bread", Line="Get a knife", Platform="knife & chopping board"},
                new Command{Id=2, HowTo="Make cup of tea", Line="Place teabag in cup", Platform="Kettle & cup"}
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=0, HowTo= "Boil an egg", Line="Boil Water", Platform="Kettle & Pan"};
        }
    }
}