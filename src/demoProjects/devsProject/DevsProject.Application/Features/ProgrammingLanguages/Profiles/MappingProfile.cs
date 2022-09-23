using AutoMapper;
using DevsProject.Application.Features.ProgrammingLanguages.Commands.CreateProgrammingLanguage;
using DevsProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevsProject.Application.Features.ProgrammingLanguages.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ProgrammingLanguage, CreateProgrammingLanguageCommandRequest>().ReverseMap();
            CreateMap<ProgrammingLanguage, CreateProgrammingLanguageCommandResponse>().ReverseMap();
        }
    }
}
