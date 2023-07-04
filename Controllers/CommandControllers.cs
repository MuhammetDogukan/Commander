using Commander.Data;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Comander.Data;
using Commander.Models;
using AutoMapper;
using Commander.Dtos;

namespace Commander.Controller
{
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly IcommanderRepo _repository;
        private readonly IMapper _mapper;

        public CommandsController(IcommanderRepo repository, IMapper mapper)
        {
            _repository=repository;  
            _mapper=mapper;
        }
        //private readonly MockCommanderRepo _repository = new MockCommanderRepo();
        //Get api/commands
        [HttpGet]
        public ActionResult <IEnumerable<CommandReadDto>> GetAllCommands()
        {
            var commandItem= _repository.GetAllComands();

            return Ok(_mapper.Map<IEnumerable<CommandReadDto>>(commandItem));
        }
        //Get api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult <CommandReadDto> GettComandById(int id)
        {
            var commandItem = _repository.GetCommandById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<CommandReadDto>(commandItem));
            }
            return NotFound();
        }
    }
}