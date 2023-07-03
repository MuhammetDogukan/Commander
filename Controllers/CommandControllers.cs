using Commander.Data;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Comander.Data;
using Commander.Models;

namespace Commander.Controller
{
    [Route("api/commands")]
    [ApiController]
    public class ComandsController : ControllerBase
    {
        private readonly MockCommanderRepo _repository = new MockCommanderRepo();
        //Get api/commands
        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAllCommands()
        {
            var commandItems= _repository.GetAppComands();

            return Ok(commandItems);
        }
        //Get api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult <Command> GettComandById(int id)
        {
            var comandItem = _repository.GetCommandById(id);

            return Ok(comandItem);
        }
    }
}