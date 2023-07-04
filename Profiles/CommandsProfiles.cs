using AutoMapper;
using Commander.Dtos;
using Commander.Models;

namespace Comander.Profiles
{
    public class CommandsProfiles: Profile
    {
        public CommandsProfiles()
        {
            CreateMap<Command, CommandReadDto>();
        }
    }
    
}