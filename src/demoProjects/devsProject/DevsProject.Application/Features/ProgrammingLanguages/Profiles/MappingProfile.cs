using AutoMapper;
using Core.Persistence.Paging;
using DevsProject.Application.Features.ProgrammingLanguages.Commands.CreateProgrammingLanguage;
using DevsProject.Application.Features.ProgrammingLanguages.Commands.DeleteProgrammingLanguage;
using DevsProject.Application.Features.ProgrammingLanguages.Commands.UpdateProgrammingLanguage;
using DevsProject.Application.Features.ProgrammingLanguages.Dtos;
using DevsProject.Application.Features.ProgrammingLanguages.Queries.GetByIdProgrammingLanguageQuery;
using DevsProject.Application.Features.ProgrammingLanguages.Queries.GetListProgrammingLanguageQuery;
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

            CreateMap<ProgrammingLanguage, DeleteProgrammingLanguageCommandResponse>().ReverseMap();

            CreateMap<ProgrammingLanguage, UpdateProgrammingLanguageCommandRequest>().ReverseMap();
            CreateMap<ProgrammingLanguage, UpdateProgrammingLanguageCommandResponse>().ReverseMap();

            CreateMap<ProgrammingLanguage, GetByIdProgrammingLanguageQueryRequest>().ReverseMap();
            CreateMap<ProgrammingLanguage, GetByIdProgrammingLanguageQueryResponse>().ReverseMap();

            CreateMap<ProgrammingLanguage, ProgrammingLanguageListDto>().ReverseMap();
            CreateMap<IPaginate<ProgrammingLanguage>, GetListProgrammingLanguageQueryResponse>().ReverseMap();

        }
    }
}
