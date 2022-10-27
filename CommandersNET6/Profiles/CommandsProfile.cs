using AutoMapper;
using CommandersNET6.Dtos;
using CommandersNET6.Models;
using System.Runtime.CompilerServices;

namespace CommandersNET6.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            CreateMap<Command, CommandReadDto>();
            CreateMap<CommandCreateDto, Command>();
            CreateMap<CommandUpdateDto, Command>();
        }
    }
}
